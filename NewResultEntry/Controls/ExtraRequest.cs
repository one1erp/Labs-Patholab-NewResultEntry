using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Patholab_DAL_V1;
using System.IO;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Patholab_XmlService;
using LSSERVICEPROVIDERLib;
using System.Text.RegularExpressions;
using NewResultEntry.Controls.Extra_req_Entities;
using Patholab_Common;
using Patholab_DAL_V1.Enums;

namespace NewResultEntry.Controls
{
    public partial class ExtraRequest : Telerik.WinControls.UI.RadForm
    {
        #region Fields

        public bool HasReq { get; set; }
        public BindingList<ColNum> dataSource;
        public List<OPERATOR> Operators;
        private MoreActionsCtrl moreActCtrl;
        List<Advisor> advisors;
        List<BlockWrapper> blockWrappers;
        private DataLayer _dal;
        private SDG _sdg;
        private INautilusServiceProvider _sp;
        private INautilusUser _ntlsUser;
        private INautilusDBConnection _ntlsCon;
        const string ADD_SLIDE = "Add Slide";
        private long sid;
        private SDG_DETAILS _sdgDtls, oldSDGdtls;
        public List<int> QuantityColList { get; set; }
        private Dictionary<string, string> exrqstatusList;
        private Dictionary<string, string> exrqtypeList;
        private List<ExWrapper> extr4sdg;
        private FrmColor colormin;
        private const int TreeItemHeight = 19;
        private BlockWrapper selectedBlock;
        private ListData listData;
        #endregion

        #region Initilaize
        public ExtraRequest(DataLayer dal, SDG sdg, LSSERVICEPROVIDERLib.INautilusServiceProvider sp, long sid, ListData ld)
        {


            try
            {


                blockWrappers = new List<BlockWrapper>();

                QuantityColList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                this._dal = dal;
                this._sdg = sdg;
                this._sp = sp;
                this.sid = sid;
                _ntlsUser = Utils.GetNautilusUser(_sp);
                this.listData = ld;

                //   _dal.ReloadEntity ( _sdg );



                InitializeComponent();
                sdgTree.ItemHeight = TreeItemHeight;

                var userID = Convert.ToInt64(_ntlsUser.GetOperatorId());
                var userName = dal.FindBy<OPERATOR>(op => op.OPERATOR_ID == userID).FirstOrDefault().FULL_NAME;



                moreActCtrl = new MoreActionsCtrl(dal, sdg) { Dock = DockStyle.Fill };
                //בעיית ביצועים חמורה
                tab_moreActions.Controls.Add(moreActCtrl);
                //
                listData.SetPhrase2Combo(cmbDoct, "Sign By");
                //        cmbDoct.DisplayMember = "PHRASE_DESCRIPTION";
                cmbDoct.ValueMember = "PHRASE_NAME";
                //    cmbDoct.DataSource = dal.GetPhraseByName ( "" ).PHRASE_ENTRY.ToList ( );

                cmbDoct.GotFocus += (s, e) => zLang.Hebrew();
                AutoCompleteModE(cmbDoct);



                LoadAdvisor();
                exrqstatusList = dal.GetPhraseByName("Extra Request Status").PhraseEntriesDictonary;
                exrqtypeList = dal.GetPhraseByName("Extra Request Type").PhraseEntriesDictonary;
                //exrqtypeList.Add("null", "");

                //    reqTypeStatus = dal.GetPhraseByName("Extra Request Status").PhraseEntriesDictonary;
                Operators = dal.GetAll<OPERATOR>().Include(a => a.OPERATOR_USER).ToList();


                SetDefAdvisorText();

                LoadTree();
                LoadgridExtra();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                Logger.WriteLogFile(x);
            }
        }

        private PHRASE_ENTRY findCreatedBy()
        {
            var phraseOperators = _dal.GetPhraseEntries("Sign By");
            var operIdString = Convert.ToString(_sdg.SDG_USER.U_PATHOLOG);
            return phraseOperators.FirstOrDefault(x => x.PHRASE_NAME.Equals(operIdString));
        }


        //הגדרת הטקסט שיופיע בראש הרשימה ושמירה האם יש רופא משויך מהרשימה 
        private void SetDefAdvisorText()
        {
            cmbDoct.SelectedItem = null;
            var a = findCreatedBy();

            if (a != null)
            {
                cmbDoct.Text = a.PHRASE_DESCRIPTION.ToString();
            }
            else
            {
                cmbDoct.Text = "אנא בחר רופא ";
            }
             

        }
        private void LoadAdvisor()
        {

            var AdvisorQuery = from item in _dal.FindBy<LIMS_ROLE>(OPE => OPE.NAME == "External Advisor")
                               select item.OPERATORs1;
            advisors = new List<Advisor>();
            foreach (var DD in AdvisorQuery.ToList())
            {
                foreach (var op in DD)
                {
                    Advisor adv = new Advisor() { opAdv = op };
                    advisors.Add(adv);
                    this.lbox_advisers.Items.Add(adv);

                }

            }

        }
        //Load sdg
        public void LoadTree()
        {
            //Clear
            blockWrappers.Clear();
            //          lbox_Blocks.Items.Clear ( );
            // gridBlocks.DataSource = null;
            sdgTree.Nodes.Clear();
            string path = Patholab_Common.Utils.GetResourcePath();
            sdgTree.Nodes.Add(_sdg.NAME);
            var icon = new Bitmap(Path.Combine(path, "sdg" + _sdg.STATUS + ".ico"));
            sdgTree.Nodes[_sdg.NAME].Image = icon;




            var samples = _dal.FindBy<SAMPLE>(sm => sm.SDG_ID == _sdg.SDG_ID);

            foreach (var sample in samples)
            {
                sdgTree.FindNodes(_sdg.NAME).First().Nodes.Add(sample.NAME);
                sdgTree.FindNodes(sample.NAME).First().Image = new Bitmap(Path.Combine(path + "sample" + sample.STATUS + ".ico"));

                //Get blocks
                var blocks = sample.ALIQUOTs.Where(x => x.ALIQ_FORMULATION_PARENT.Count < 1).OrderBy(al => al.ALIQUOT_ID);


                foreach (var aliquot in blocks)
                {
                    //11.1.1
                    //                    lbox_Blocks.Items.Add ( aliquot.NAME.Substring ( aliquot.NAME.Length - 3, 3 ) );
                    int e11 = 11;
                    var bw = (new BlockWrapper()
                    {
                        sample =
                           aliquot.NAME.Substring(e11, 1),// aliquot.NAME.Length - 3, 1 ),
                        block =
                           aliquot.NAME.Substring(e11, aliquot.NAME.Length - e11)
                           ,
                        AliquotStatus = aliquot.STATUS
                    });
                    blockWrappers.Add(bw);




                    sdgTree.FindNodes(sample.NAME).First().Nodes.Add(aliquot.NAME);
                    var nd = sdgTree.FindNodes(aliquot.NAME).First();
                    if (nd != null)
                    {

                        nd.Image = new Bitmap(Path.Combine(path + "aliquot" + aliquot.STATUS + ".ico"));
                    }

                    //Get Slides
                    var children = aliquot.ALIQ_FORMULATION_CHILD.OrderBy(a => a.CHILD_ALIQUOT_ID);
                    foreach (var child in children)
                    {
                        string nodeName = string.Format("{0} ({1})"
                            , child.PARENT.NAME,
                            child.PARENT.ALIQUOT_USER.U_COLOR_TYPE);

                        nd.Nodes.Add(nodeName);// ()
                        sdgTree.FindNodes(nodeName).First().Image = new Bitmap
                            (Path.Combine(path + "aliquot" + child.PARENT.STATUS + ".ico"));

                    }

                }
            }

            FillGrid(blockWrappers);

            sdgTree.ExpandAll();
        }

        private void FillGrid(List<BlockWrapper> blockWrappers)
        {
            gridBlocks.Rows.Clear();

            //add order by sample and block

            //bl.block.Split('.')[1] oriyat 18/08/22 
            //מיון לפי מספור בלוק כשיש יותר מ 10 בלוקים ל צנצנת
            foreach (BlockWrapper wrapper in blockWrappers.OrderBy(bl => int.Parse(bl.block.Split('.')[1])).OrderBy(bl => int.Parse(bl.block.Split('.')[0])).Where(bl => !"XS".Contains(bl.AliquotStatus)))
            {


                var row = gridBlocks.Rows.AddNew();
                row.Cells[0].Value = wrapper.sample;
                row.Cells[1].Value = wrapper.block;

            }

            if (_sdg.SdgType == SdgType.Pap)
            {
                gridBlocks.Columns["cmdopen"].IsVisible = false;
            }
        }

        private void LoadgridExtra()
        {
            //cmbDoct.NullText = SetDefaultPatholaog();



            extr4sdg = (from ru in _sdg.U_EXTRA_REQUEST_USER
                        from rdu in ru.U_EXTRA_REQUEST.U_EXTRA_REQUEST_DATA_USER
                            //     where rdu.U_EXTRA_REQUEST_ID equals rdu.
                        where rdu.U_STATUS != "X"

                        orderby rdu.U_EXTRA_REQUEST_DATA_ID
                        select new ExWrapper
                        {
                            ID = rdu.U_EXTRA_REQUEST_DATA_ID,
                            Entity_NAME = rdu.U_EXTRA_REQUEST_DATA.NAME.Split(';')[0],
                            Action = ru.U_EXTRA_REQUEST.NAME.Split(';')[0],
                            Details = rdu.U_REQUEST_DETAILS,
                            Status = rdu.U_STATUS,//exrqstatusList[rdu.U_STATUS]
                            Created_By = Operators.FirstOrDefault(x => x.OPERATOR_ID == ru.U_CREATED_BY.Value).NAME,
                            Created_on = ru.U_CREATED_ON,
                            Request_Type = rdu.U_REQ_TYPE,//==null?"":exrqtypeList[rdu.U_REQ_TYPE]
                            Remarks = rdu.U_REMARKS,
                            //string opName=     GetOperatorById ( cmbDoct.SelectedValue.ToString ( ) );
                            //   DESCRIPTION = ru.U_EXTRA_REQUEST.DESCRIPTION,

                            //  ru.U_CREATED_BY.Value

                        }).ToList();
            HasReq = extr4sdg != null && extr4sdg.Count > 0;
            if (HasReq)
            {
                foreach (var item in extr4sdg)
                {
                    item.Status = item.Status == null || !exrqstatusList.ContainsKey(item.Status) ? "" : exrqstatusList[item.Status];
                    //item.Request_Type = item.Request_Type == null ? "" : exrqtypeList[item.Request_Type];
                    item.Request_Type = item.Request_Type == null || !exrqtypeList.ContainsKey(item.Request_Type) ? "" : exrqtypeList[item.Request_Type];

                }
            }
            gridExtraReq.DataSource = extr4sdg;

        }




        #endregion


        #region Add slide
        bool flagAdvisor = false;
        bool flagPTG = false;
        private void btnAddSlideColor_Click(object sender, EventArgs e)
        {
            HideLabels();

            //בדיקה האם נבחר רופא מהרשימה 
            if (cmbDoct.Text.Equals("אנא בחר רופא "))
            {

                MessageBox.Show("אנא בחר רופא!");
                return;

            }

            if (blockWrappers.TrueForAll(x => x.Colors4add == null || x.Colors4add.Count == 0))
                return;
            foreach (BlockWrapper blockWrapper in blockWrappers)
            {

                if (blockWrapper.Colors4add == null)
                    continue;


                var selectedAliq = _sdg.NAME + "." + blockWrapper.block;

                ALIQUOT blockAliqParent = GetParentId(selectedAliq);


                foreach (var item in blockWrapper.Colors4add)
                {
                    for (int i = 0; i < item.Value /*quantity*/; i++)
                    {
                        AddSlide(blockAliqParent, item.Key);
                    }
                }

            }


            if (_ntlsCon == null)
            { _ntlsCon = Patholab_Common.Utils.GetNtlsCon(_sp); }
            _dal.Close();

            _dal = new DataLayer();
            _dal.Connect(_ntlsCon);

            _sdg = _dal.FindBy<SDG>(x => x.SDG_ID == _sdg.SDG_ID)
                                         .Include(x => x.SDG_USER).SingleOrDefault();

            HideLabels();
            lblMessage.Visible = true;
            LoadTree();
            LoadgridExtra();

        }

        private void AddSlide(ALIQUOT blockAliqParent, string color)
        {
            // System.Diagnostics.Debugger.Launch ( );
            //Create new slide by xml
            var addsildexml = new FireEventXmlHandler(_sp, ADD_SLIDE);
            addsildexml.CreateFireEventXml("ALIQUOT", blockAliqParent.ALIQUOT_ID, "Add Slide");
            var success = addsildexml.ProcssXml();
            if (!success)
            {
                MessageBox.Show("Error on add slide " + addsildexml.ErrorResponse);
                return;
            }
            else
            {
                try
                {

                    _dal.InsertToSdgLog(_sdg.SDG_ID, "EXTRA.CREATED", sid, "Add slide " + color);
                }
                catch (Exception e)
                {

                    Logger.WriteLogFile(e);
                    MessageBox.Show("Error on InsertToSdgLog" + e.Message);
                }

                var parentId = addsildexml.GetValueByTagName("ALIQUOT_ID");

                #region If is nautilus 9.4



                //object newChildId;
                //try
                //{
                //    //error
                //    newChildId = addsildexml.GetValueByTagName ( "ALIQUOT_ID", 1 );
                //}
                //catch ( Exception ex1 )
                //{
                //    Logger.WriteLogFile ( ex1 );
                //    MessageBox.Show ( "Error on GetValueByTagName 1" + ex1.Message );
                //    return;
                //}

                //// long pid;
                ////  long.TryParse ( parentId, out pid );
                //long cid;
                //long.TryParse ( newChildId.ToString ( ), out cid );

                #endregion

                #region Leave this here maybe for production environment

                //Get block's children 
                var children = _dal.FindBy<ALIQUOT_FORMULATION>(x => x.PARENT_ALIQUOT_ID == blockAliqParent.ALIQUOT_ID)
                    .OrderByDescending(a1 => a1.CHILD_ALIQUOT_ID);
                var asda = children.Count();

                //Update new slide name(override also the old aliquots)
                int cnt = 0;
                foreach (var child in children.OrderBy(a1 => a1.CHILD_ALIQUOT_ID))
                {
                    cnt++;
                    child.PARENT.NAME = blockAliqParent.NAME + "." + cnt;
                }


                #endregion

                //Update the new slide color
                var new_aliq = children.OrderByDescending(a1 => a1.CHILD_ALIQUOT_ID).First().PARENT;
                //    _dal.FindBy<ALIQUOT> ( nl => nl.NAME == blockAliqParent.NAME + "." + cnt ).FirstOrDefault ( );
                if (new_aliq == null)
                {
                    MessageBox.Show("New child is null??");
                    return;
                }


                //  new_aliq.NAME = blockAliqParent.NAME + "." + asda;
                new_aliq.ALIQUOT_USER.U_COLOR_TYPE = color;



                if (cmbDoct.SelectedItem != null)
                {
                    _dal.Ex_Req_Logic(_sdg.SDG_ID, new_aliq.NAME, ExtraRequestType.H, Convert.ToInt32(cmbDoct.SelectedValue.ToString()), color, radTextBoxRemarks.Text);
                    _dal.InsertToSdgLog(_sdg.SDG_ID, "Extra Request", sid, "Extra request for " + Convert.ToInt32(cmbDoct.SelectedValue.ToString()));
                    _dal.SaveChanges();
                }
                else
                {
                    var a = findCreatedBy();
                    _dal.Ex_Req_Logic(_sdg.SDG_ID, new_aliq.NAME, ExtraRequestType.H, Convert.ToInt32(a.PHRASE_NAME), color, radTextBoxRemarks.Text);
                    _dal.InsertToSdgLog(_sdg.SDG_ID, "Extra Request", sid, "Extra request for " + a.PHRASE_NAME);
                    _dal.SaveChanges();
                }






                //הקוד שהיה קודם
                //Get operator name from combo box

                //long doc = Convert.ToInt64(cmbDoct.SelectedValue);
                //Enter u_extra_request
                //_dal.Ex_Req_Logic(_sdg.SDG_ID, new_aliq.NAME, ExtraRequestType.H, doc, color, radTextBoxRemarks.Text);

                ////    U_EXTRA_REQUEST nr = EnterNewRequest(ADD_SLIDE, new_aliq.NAME, doc);

                ////   if (nr == null) return;

                //_dal.InsertToSdgLog(_sdg.SDG_ID, "Extra Request", sid, "Extra request for " + cmbDoct.Text);

                ////Enter u_extra_request_data
                ////     EnterNewRequestData(nr, blockAliqParent.NAME, "Block", color, new_aliq.NAME);


                //_dal.SaveChanges();

            }
        }

        private string GetOperatorById(string p)
        {
            long opid = long.Parse(p);
            var op = _dal.FindBy<OPERATOR>(o => o.OPERATOR_ID == opid);
            if (op != null)
            {
                return op.SingleOrDefault().NAME;

            }
            return "Null";
        }

        private ALIQUOT GetParentId(string selectedAliq)
        {
            foreach (var sample in _sdg.SAMPLEs)
            {
                foreach (var item in sample.ALIQUOTs)
                {
                    if (item.NAME == selectedAliq && item.ALIQ_FORMULATION_PARENT.Count < 1)

                    { return item; }
                }
            }
            return null;
        }
        #endregion

        #region Grid events

        private void gridExtraReq_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {


            ExWrapper exrq = (e.Rows[0]).DataBoundItem as ExWrapper;


            var b = _dal.FindBy<ALIQUOT>(al => al.NAME == exrq.Entity_NAME && al.STATUS == "V");
            if (b != null)
            {
                e.Cancel = true;
            }
            else
            {
                _dal.FindBy<U_EXTRA_REQUEST_DATA_USER>(x => x.U_EXTRA_REQUEST_DATA_ID == exrq.ID)
                               .FirstOrDefault().U_STATUS = "X";
                _dal.SaveChanges();
            }





        }

        #endregion

        #region שליחה להתייעצות
        private void adviseRequest_Click(object sender, EventArgs e)
        {
            HideLabels();

            if (lbox_advisers.SelectedItem == null)
            {
                MessageBox.Show(" אנא בחר יועץ");
                return;
            }
            if (lbox_entities.Items.Count < 1)
            {
                MessageBox.Show(" אנא בחר ישות");
                return;
            }

            //Get selected operator from list
            Advisor selectedAdv = lbox_advisers.SelectedItem as Advisor;
            if (selectedAdv == null) return;
            long opid = selectedAdv.opAdv.OPERATOR_ID;

            foreach (var item in lbox_entities.Items)
            {
                var entityName = item.ToString();

                int dots = entityName.Where(x => x == '.').Count();
                //   var dots=Regex.Matches ( aliqName, "." ).Count;

                string entityType;
                if (dots == 1) entityType = "Sample";
                else if (dots == 2) entityType = "Block";
                else entityType = "Slide";





                long currentOperator = (long)_ntlsUser.GetOperatorId();


                _dal.Ex_Req_Logic(_sdg.SDG_ID, entityName, ExtraRequestType.T, currentOperator, lbox_advisers.SelectedItem.ToString(), txtConsultRemark.Text);


                //     var newext = EnterNewRequest("Send to Consultant", "", (long)currentOperator);


                //     if (newext == null) return;

                _dal.InsertToSdgLog(_sdg.SDG_ID, "Extra Request", sid, "Send to Consultant " + lbox_advisers.SelectedItem.ToString());
                // _dal.InsertToSdgLog ( sdg.SDG_ID, 

                //           sdg_log.InsertLog(rsSdg("sdg_id"), "EXTRA.CREATED", "Send " & _
                //    lstSelectedObjects.ListCount & " item(s) to consultant")
                // EnterNewRequestData(newext, entityName, entityType, lbox_advisers.SelectedItem.ToString(), "");

                lblMsgAdv.Visible = true;
                //  LoadTree ( );
                LoadgridExtra();
            }


        }
        #endregion

        private void btnAddSynamic_Click(object sender, EventArgs e)
        {
            if (sdgTree.SelectedNode != null)
            //&& lbox_entities4Advisers.Items.Contains ( sdgTree.SelectedNode.Text ) == false )
            {
                string nameOnly = sdgTree.SelectedNode.Text.Split('(')[0].Trim();
                if (!lbox_entities.Items.Contains(nameOnly))
                    lbox_entities.Items.Add(nameOnly);
            }
            lblCont4adv.Text = lbox_entities.Items.Count.ToString();
        }

        private void btnRemoveDynamic_Click(object sender, EventArgs e)
        {
            if (lbox_entities.SelectedItem != null)
            {
                lbox_entities.Items.Remove(lbox_entities.SelectedItem);
            }
            lblCont4adv.Text = lbox_entities.Items.Count.ToString();
        }



        void HideLabels()
        {
            lblMessage.Visible = false;
            lblMsgAdv.Visible = false;
            if (moreActCtrl != null)
            {
                moreActCtrl.HideLabels();
            }
        }

        private void gridBlocks_CommandCellClick(object sender, EventArgs e)
        {
            if (this._sdg.SdgType == SdgType.Pap)
            {
                return;
            }
            HideLabels();
            //     var cmd = ( ( Telerik.WinControls.UI.GridCommandCellElement ) ( sender ) ).CommandButton.Name;

            var tx = ((Telerik.WinControls.UI.GridViewCellEventArgsBase)(e));
            var ali = tx.Row.Cells[1].Value;
            selectedBlock = blockWrappers.FirstOrDefault(x => x.block == (string)ali);
            if (selectedBlock == null) return;
            if (tx.ColumnIndex == 2)
            {

                if (colormin == null)
                {
                    colormin = new FrmColor(_dal, _sdg);

                }
                else
                {
                    colormin.LoadBlockData(selectedBlock.Colors4add);
                }
                colormin.ShowDialog();
                if (colormin.approved)
                {
                    selectedBlock.AddColors(colormin.SelectedColors);
                    tx.Row.Cells[3].Value =
                        selectedBlock.Colostr; //.SelectedColors.ColumnInfo as GridViewComboBoxColumn;
                }
            }
            else if (tx.ColumnIndex == 4)
            {
                if (selectedBlock.Colors4add != null)
                {
                    selectedBlock.Colors4add.Clear();
                    tx.Row.Cells[3].Value = null;
                    tx.Row.Cells[3].Value = selectedBlock.Colostr;

                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabExtraRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideLabels();
        }

        private void AutoCompleteModE(RadDropDownList rd)
        {

            rd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // rd.AutoCompleteMode = AutoCompleteMode.Suggest;
            rd.DropDownListElement.AutoCompleteSuggest = new CustomAutoCompleteSuggestHelper(rd.DropDownListElement);
            rd.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void gridBlocks_Click(object sender, EventArgs e)
        {

        }
        string selectedObjectValue;
        private void cmbDoct_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //selectedObjectValue = (string)cmbDoct.SelectedItem.Value;
        }
        //galina 07/11/2023
        private void gridExtraReq_CommandCellClick(object sender, EventArgs e)
        {
            var action = ((Telerik.WinControls.UI.GridViewCellEventArgsBase)(e)).Row.Cells[2].Value;
            if (action.ToString() != "Add Slide")
            {
                return;
            }
            HideLabels();

            long id = ((NewResultEntry.Controls.Extra_req_Entities.ExWrapper)((Telerik.WinControls.UI.GridViewCellEventArgsBase)e).Row.DataBoundItem).ID;
            if (id > 0)
            {
                var tup = _dal.FindBy<U_EXTRA_REQUEST_DATA_USER>(x => x.U_EXTRA_REQUEST_DATA_ID == id)
                               .FirstOrDefault();
                tup.U_STATUS = "V";
                tup.U_EXTRA_REQUEST.U_EXTRA_REQUEST_USER.U_CREATED_ON = DateTime.Now;
                ;
                _dal.SaveChanges();
                var tx = ((Telerik.WinControls.UI.GridViewCellEventArgsBase)(e));
                tx.Row.Cells[6].Value = "חדש";
                tx.Row.Cells[5].Value = DateTime.Now;

            }

        }



    }
}