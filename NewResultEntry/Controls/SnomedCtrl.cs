using Patholab_Common;
using Patholab_DAL_V1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;
using Control = System.Windows.Forms.Control;

namespace NewResultEntry.Controls
{
    public partial class SnomedCtrl : UserControl
    {
        #region PRIVATE FIELDS

        private Dictionary<string, RadControl> _result2Snomed;
        public List<PHRASE_ENTRY> _smList { get; set; }
        public List<PHRASE_ENTRY> _sTList { get; set; }
        public List<PHRASE_ENTRY> _signByList { get; set; }
        public List<PHRASE_ENTRY> TumorBList { get; set; }
        private List<PHRASE_ENTRY> _infectedList;
        private ListData ld;

        public SDG_DETAILS _sdgDet { get; set; }
        private bool _userChangedMalig;
        private DataLayer dal;
        #endregion

        #region LOADING
        public SnomedCtrl()
        {
            InitializeComponent();



            _result2Snomed = new Dictionary<string, RadControl>
                {

                    {Constants.SnomedT, cmbST},
                    {Constants.SnomedM, cmbSM},
                    {Constants.Malignant, cbMalig},
                    {Constants.Sign1St, cmbSign1},
                    {Constants.Sign2Nd, cmbSign2},
                    {Constants.Lymphnodespresent,nudPres},
                    {Constants.Lymphnodescarcinoma,NudCarcinoma},
                    {Constants.TumorBehavior,cmbTubh}
        

        //      {Constants.Infected_lymph_nodes, cmbInfected_LN}

                };

        }

        internal Task InitilaizeData(ListData listData, DataLayer dal1)
        //internal Task InitilaizeData(ListData listData)
        {
            this.dal = dal1;
            InitCombo();
            this.ld = listData;

            _signByList = ld.SetPhrase2Combo(cmbSign1, "Sign By");
            ld.SetExistsList2Combo(cmbSign2, _signByList);


            _smList = ld
               .SetPhrase2Combo(cmbSM, "SNOMED M");
            ld.SetExistsList2Combo(cmbSM2, _smList);
            ld.SetExistsList2Combo(cmbSM3, _smList);

            _sTList = ld.SetPhrase2Combo(cmbST, "SNOMED T");
            ld.SetExistsList2Combo(cmbST2, _sTList);
            ld.SetExistsList2Combo(cmbST3, _sTList);

            TumorBList = ld.SetPhrase2Combo(cmbTubh, "Tumor behavior");

            EmptyAllCombos();
            return Task.FromResult(0);
        }
        #endregion

        #region DATA

        public void LoadSnomedResults(List<WrapperRtf> currentResults)
        {
            HasResult4Sdg();
            var snomedResults1 = from res in currentResults where res.TestName == "SNOMED" select res;

            //LOADS     snomed TO LIST
            foreach (var res in snomedResults1)
            {
                var rr = currentResults.FirstOrDefault(x => x.Result_.RESULT_ID == res.ResultId);
                if (rr != null)
                {
                    if (_result2Snomed.ContainsKey(res.Name))
                    {
                        //rr.FormattedResult = res.Result_.FormattedResult;
                        var ctl = _result2Snomed[res.Name];
                        RadCheckBox r = ctl as RadCheckBox;
                        if (r != null)
                        {
                            r.IsChecked = (res.Result_.FORMATTED_RESULT == "True" || res.Result_.FORMATTED_RESULT == "T");
                            continue;
                        }

                        RadSpinEditor spinEditor = ctl as RadSpinEditor;
                        if (spinEditor != null && res.Result_.FORMATTED_RESULT != null)
                        {
                            spinEditor.Value = decimal.Parse(res.Result_.FORMATTED_RESULT);

                        }

                        else //is combo box
                        {
                            PHRASE_ENTRY pe_res = null;
                            RadDropDownList CMB = ctl as RadDropDownList;
                            if (res.Name == Constants.SnomedM)
                            {
                                LoadSnomedM(res);
                            }
                            else if (res.Name == Constants.SnomedT)
                            {
                                LoadSnomedT(res);
                            }

                            else if (res.Name == Constants.Sign1St || res.Name == Constants.Sign2Nd)
                            {
                                pe_res = _signByList.SingleOrDefault(x => x.PHRASE_NAME == res.Result_.FORMATTED_RESULT);
                                if (CMB != null)
                                {
                                    if (pe_res != null)
                                        CMB.SelectedValue = pe_res.PHRASE_NAME;

                                    else
                                        CMB.Text = res.Result_.FORMATTED_RESULT;
                                }
                            }
                            else if (res.Name == Constants.TumorBehavior)
                            {
                                pe_res = TumorBList.SingleOrDefault(x => x.PHRASE_NAME == res.Result_.FORMATTED_RESULT);
                                if (CMB != null)
                                {
                                    if (pe_res != null)
                                        CMB.SelectedValue = pe_res.PHRASE_NAME;

                                    else
                                        CMB.Text = res.Result_.FORMATTED_RESULT;
                                }
                            }

                       
                        }
                    }
                }
            }
        }



        public void SaveSnomedTab(SDG c_sdg, List<WrapperRtf> _currentResults)
        {
            int i = 0;
            foreach (var res in _currentResults)//.Where(x => x.ResultType == ResultType.Snomed))
            {
                string val = "";
                if (_result2Snomed.ContainsKey(res.Name))
                {

                    RadCheckBox r = _result2Snomed[res.Name] as RadCheckBox;

                    if (r != null) //is check box
                    {
                        val = r.IsChecked ? "T" : "F";
                    }
                    else if (_result2Snomed[res.Name] as RadSpinEditor != null)
                    {
                        var spinEditor = _result2Snomed[res.Name] as RadSpinEditor;
                        val = spinEditor.Value.ToString();
                    }
                    else if (res.Name == Constants.SnomedM)
                    {
                        var list_M = GetSnomedM_value();

                        foreach (string entry in list_M)
                            val = val + (entry + ";");


                    }
                    else if (res.Name == Constants.SnomedT)
                    {
                        var list_T = GetSnomedT_value();

                        foreach (string entry in list_T)
                            val = val + (entry + ";");


                    }
                    else //is not check box
                    {


                        RadDropDownList cmb = _result2Snomed[res.Name] as RadDropDownList; //.se.Text;
                        if (cmb != null)
                        {

                            var bilbi = cmb.DataSource as List<PHRASE_ENTRY>;
                            if (bilbi != null)
                            {
                                PHRASE_ENTRY cmbVal = bilbi.FirstOrDefault(x => x.PHRASE_DESCRIPTION == cmb.Text);

                                if (cmbVal != null)
                                    val = cmbVal.PHRASE_NAME;
                                else
                                {
                                    val = cmb.Text;
                                }
                            }

                        }

                        else
                        {
                            MessageBox.Show("Error");
                            break;
                        }
                    }

                    RESULT res2Update = dal.FindBy<RESULT>(x => x.RESULT_ID == res.ResultId).SingleOrDefault();

                 // RESULT res2Update = _currentResults.Select(x => x.Result_).SingleOrDefault(x => x.RESULT_ID == res.ResultId);
                    if (res2Update != null)
                    {
                        res2Update.FORMATTED_RESULT = val;
                        res2Update.ORIGINAL_RESULT = val;
                    }
                    if (i == 0) //first time add node for test ID
                    {
                        //         resultEntry.CreateResultEntryXml((long)res.TestId, res.ResultId, val);
                    }
                    else
                    {
                        //        resultEntry.AddResultEntryElem(res.ResultId.ToString(), val);
                    }
                    i++;

                }
            }
            c_sdg.SDG_USER.U_TUMOR_SIZE = txtTumorSize.Text;

            //  var b = resultEntry.ProcssXml();

            //  if (!b)
            //    {
            //      MessageBox.Show("Error on save Snomed by result entry xml " + resultEntry.ErrorResponse,
            //      Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Logger.WriteLogFile(resultEntry.ErrorResponse);
            //   }



        }

     

        internal void LoadSdgDetails(SDG_DETAILS sdgdet)
        {
            this._sdgDet = sdgdet;
            if (sdgdet.U_TUMOR_SIZE != null)
                txtTumorSize.Text = sdgdet.U_TUMOR_SIZE;
        }
        #endregion

        #region Private SNOMED helper

        private void LoadSnomedM(WrapperRtf res)
        {
            var typ = res.Result_.FORMATTED_RESULT;
            if (typ != null)
            {
                var split = typ.Split(';');
                if (split.Length > 0)
                {
                    LoadSnmdInner(_smList, cmbSM, split[0]);

                    if (split.Length > 1)
                    {
                        LoadSnmdInner(_smList, cmbSM2, split[1]);


                        if (split.Length > 2)
                        {
                            LoadSnmdInner(_smList, cmbSM3, split[2]);
                        }
                    }
                }
            }
        }

        private void LoadSnomedT(WrapperRtf res)
        {
            var typ = res.Result_.FORMATTED_RESULT;
            if (typ != null)
            {
                var split = typ.Split(';');
                if (split.Length > 0)

                    LoadSnmdInner(_sTList, cmbST, split[0]);

                if (split.Length > 1)
                {
                    LoadSnmdInner(_sTList, cmbST2, split[1]);


                    if (split.Length > 2)
                        LoadSnmdInner(_sTList, cmbST3, split[2]);
                }

            }
        }






        private void LoadSnmdInner(List<PHRASE_ENTRY> snmdList, RadDropDownList cmb, string existsVal)
        {
            var p = (snmdList.FirstOrDefault(x => x.PHRASE_NAME == existsVal));
            if (p != null)
            {
                cmb.SelectedValue = existsVal;
            }
            else
            {
                cmb.Text = existsVal;
            }

        }

        private List<string> GetSnomedT_value()
        {

            List<string> ST_list = new List<string>();
            ST_list.AddRange(new List<string>
            { GetSnmdVal(cmbST),
                GetSnmdVal(cmbST2),
                GetSnmdVal(cmbST3)
            });
            return ST_list;
        }

        private List<string> GetSnomedM_value()
        {

            List<string> SM_list = new List<string>();
            SM_list.AddRange(new List<string>
                {
                    GetSnmdVal(cmbSM),
                    GetSnmdVal(cmbSM2),
                    GetSnmdVal(cmbSM3)
                });
            return SM_list;

        }

        private string GetSnmdVal(RadDropDownList cmb)
        {
            if (cmb.SelectedItem != null)
            {
                PHRASE_ENTRY snmd = cmb.SelectedItem.DataBoundItem as PHRASE_ENTRY;
                if (snmd != null)
                {
                    if (snmd.PHRASE_DESCRIPTION != cmb.Text)
                    {
                        return (cmb.Text);

                    }
                    return (snmd.PHRASE_NAME);
                }
            }
            else
            {
                return (cmb.Text);
            }
            return "";
        }

        private List<PHRASE_ENTRY> GetSnomedM_valueObj()
        {

            List<PHRASE_ENTRY> SM_list = new List<PHRASE_ENTRY>();
            if (cmbSM.SelectedItem != null)
            {
                PHRASE_ENTRY snomedM = cmbSM.SelectedItem.DataBoundItem as PHRASE_ENTRY;
                if (snomedM != null)
                {
                    SM_list.Add(snomedM);
                }
            }

            if (cmbSM2.SelectedItem != null)
            {
                PHRASE_ENTRY snomedM2 = cmbSM2.SelectedItem.DataBoundItem as PHRASE_ENTRY;
                if (snomedM2 != null)
                {
                    SM_list.Add(snomedM2);
                }
            }

            if (cmbSM3.SelectedItem != null)
            {
                PHRASE_ENTRY snomedM3 = cmbSM3.SelectedItem.DataBoundItem as PHRASE_ENTRY;

                if (snomedM3 != null)
                {
                    SM_list.Add(snomedM3);
                }
            }
            return SM_list;
        }



        #endregion

        #region UI

        public void EmptyAllCombos()
        {
            cmbSign1.Text = string.Empty;
            cmbSign2.Text = string.Empty;
            //  cmbInfected_LN.Text = string.Empty;
            cmbST.Text = string.Empty;
            cmbST2.Text = string.Empty;
            cmbST3.Text = string.Empty;
            cmbSM.Text = string.Empty;
            cmbSM2.Text = string.Empty;
            cmbSM3.Text = string.Empty;
            cmbTubh.Text = string.Empty;
        }

        internal void ClearScreen()
        {
            _userChangedMalig = false;
            cbMalig.IsChecked = false;
            EmptyAllCombos();
            txtTumorSize.Text = string.Empty;
            nudPres.Value = 0;
            NudCarcinoma.Value = 0;
        }

        internal void EnableControls(bool p)
        {
            this.Controls.OfType<RadDropDownList>().Foreach(x => x.Enabled = p);
            grp_snomedM.Controls.OfType<RadDropDownList>().Foreach(x => x.Enabled = p);
            grp_snomedT.Controls.OfType<RadDropDownList>().Foreach(x => x.Enabled = p);

            txtTumorSize.Enabled = p;
            nudPres.Enabled = p;
            NudCarcinoma.Enabled = p;
            cbMalig.Enabled = p;
        }

        #endregion

        private void HasResult4Sdg()
        {
            bool afterUpgradeCarcinoma = _sdgDet.SDG_ID > 202460;
            cbCarcinoma.Visible = afterUpgradeCarcinoma;
            nudPres.Visible = afterUpgradeCarcinoma;
            NudCarcinoma.Visible = afterUpgradeCarcinoma;
            cbPres.Visible = afterUpgradeCarcinoma;

            bool afterUpgradeTumor = _sdgDet.SDG_ID > 202500;
            lblTb.Visible = afterUpgradeTumor;
            cmbTubh.Visible = afterUpgradeTumor;
        }

        internal bool ContainsResult(string str)
        {
            return _result2Snomed.ContainsKey(str);
        }

        internal string CanAuthorise()
        {

            string errMsg = string.Empty;
            var ds = cmbSign1.DataSource as List<PHRASE_ENTRY>;
            PHRASE_ENTRY pe = ds.FirstOrDefault(x => x.PHRASE_DESCRIPTION == cmbSign1.Text);

            if (pe == null)
            {
                errMsg += "Sign by 1st is mandatory field." + Environment.NewLine;
            }

            if (_sdgDet.SDG_NAME.StartsWith("B"))
            {
                if (cmbST.SelectedItem == null)
                {
                    errMsg += "Snomed T is mandatory field." + Environment.NewLine;
                }

                if (cmbSM.SelectedItem == null)
                {
                    errMsg += "Snomed M is mandatory field.";
                }

            }
            return errMsg;
        }

        #region Events

        private void cmbSM_SelectedIndexChanged_1(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //If user changes malignant to positive value,
            //then malignant value not changed by snomed M event.
            if (!_userChangedMalig)
            {


                if (_sdgDet != null && _sdgDet.STATUS != "A")
                {
                    var SM_list = GetSnomedM_valueObj();
                    var malignantValue = SM_list.Any(sn => sn.PHRASE_INFO == "y"); // ? "T" : "F";
                    cbMalig.IsChecked = malignantValue;
                }
            }
        }

        private void cbMalig_MouseUp(object sender, MouseEventArgs e)
        {
            //Value changed by user

            if (cbMalig.IsChecked == false)
            {
                //Doesn't allow user to set false if value is y
                var SM_list = GetSnomedM_valueObj();
                var malignantValue = SM_list.Any(sn => sn.PHRASE_INFO == "y"); // ? "T" : "F";
                cbMalig.IsChecked = malignantValue;
                _userChangedMalig = false;

            }
            else
            {
                _userChangedMalig = true;
            }




        }

        #endregion


        //Snomed
        void InitCombo()
        {
            cmbSign1.GotFocus += (s, e) => zLang.Hebrew();
            cmbSign2.GotFocus += (s, e) => zLang.Hebrew();
            AutoCompleteModE(cmbSign1);
            AutoCompleteModE(cmbSign2);

            foreach (var item in this.Controls)
            {
                GroupBox grp = item as GroupBox;
                if (grp == null) continue;


                foreach (var rd in grp.Controls.OfType<RadDropDownList>())
                {

                    AutoCompleteModE(rd);
                    rd.GotFocus += (s, e) => zLang.English();
                }

            }

        }
        private void AutoCompleteModE(RadDropDownList rd)
        {

            rd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // rd.AutoCompleteMode = AutoCompleteMode.Suggest;
            rd.DropDownListElement.AutoCompleteSuggest = new CustomAutoCompleteSuggestHelper(rd.DropDownListElement);
            rd.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

    }


}

