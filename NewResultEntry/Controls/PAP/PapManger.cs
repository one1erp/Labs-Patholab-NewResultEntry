using Patholab_Common;
using Patholab_DAL_V1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NewResultEntry.Controls.PAP
{
    internal class PapManger
    {

        #region Private fields

        public List<TabPage> RelevantTabs
        {
            get;
            private set;
        }

        List<TabPage> _tabs;
        private TabPage tabFreeTxt;
        private TabPage tab_HPV;
        private ListData _listData;
        List<RadGroupBox> groupBoxList = new List<RadGroupBox>();
        private DataLayer dal;


        #endregion

        #region Loading
        public PapManger(List<TabPage> pagesDic, TabPage tabFreeTxt, TabPage tab_HPV, DataLayer dal1)
        {
            RelevantTabs = new List<TabPage>();
            this.dal = dal1;
            _tabs = new List<TabPage>();
            _tabs = pagesDic;
            //_tabs.Insert(_tabs.Count > 2 ? _tabs.Count - 2 : 0, tabFreeTxt);
            this.tabFreeTxt = tabFreeTxt;
            //tabFreeTxt.Controls.Add(new FlowLayoutPanel() { Name = PapConstants.Test_PapFreeTxt, Dock = DockStyle.Fill });
            this.tab_HPV = tab_HPV;
        }

        internal async Task InitilaizeData(ListData listData)
        {
            this._listData = listData;
            ClearScreen();
        }
        #endregion

        #region Data


        internal void LoadResults(List<WrapperRtf> currentResults, bool isHpv)
        {
            RelevantTabs.Clear();
            //            RelevantTabs.Add(tabFreeTxt);

            foreach (var item in _tabs)
            {
                var pnl = item.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();

                //pnl.Margin = new Padding(3, 3, 3, 10);
                if (pnl == null)
                {
                    //if (item.Name.Equals("tabFreeTxt"))
                    //{
                    //    //foreach(
                    //    RelevantTabs.Add(item);
                    //    continue;
                    //}
                    //else
                    //    break;
                    continue;
                }



                var results4page = new List<WrapperRtf>();
                foreach (var wrp in currentResults)
                {
                    U_NEW_RE_DESC_USER nrd = _listData.newReDescList.
                        Where(x => x.RESULT_TEMPLATE.NAME == wrp.Result_.RESULT_TEMPLATE_NAME).FirstOrDefault();
                    if (nrd != null && wrp.TestName == pnl.Name)
                    {
                        wrp.NewDescRow = nrd;
                        results4page.Add(wrp);
                    }
                }

                if (results4page.Count() == 0)
                {
                    continue;
                }
                else
                {
                    RelevantTabs.Add(item);
                }


                //Place controls on screen
                BuildControls(pnl, results4page);

                //Get them
                var resultControls = GetCbox(item);


                //visible/hide HPV controls if they appear on other tab
                ShowHpvControls(isHpv, resultControls);



                foreach (var res in results4page)
                {
                    // Checks for each result if it has associated control
                    if (resultControls.FirstOrDefault(x => x.Name == res.Name) == null)
                        continue;


                    var ctl = res.Ctl;

                    //SHOW CONTROL ONLY FOR HPV REQUEST
                    if (ctl.Tag != null && ctl.Tag.ToString() == PapConstants.HPV_TAG)
                    {
                        ctl.Visible = isHpv;
                    }

                    //Load existing results
                    RadDropDownList cmb = ctl as RadDropDownList;
                    if (cmb != null)
                    {
                        PHRASE_ENTRY pe_res = null;

                        var listEntry = cmb.DataSource as List<PHRASE_ENTRY>;

                        //Check if result is phrase name or description
                        pe_res = listEntry.SingleOrDefault(x => x.PHRASE_NAME == res.Result_.FORMATTED_RESULT
                                                           || x.PHRASE_DESCRIPTION == res.Result_.FORMATTED_RESULT);

                        if (pe_res != null)
                        {
                            cmb.SelectedValue = pe_res.PHRASE_NAME;
                        }
                        else
                            cmb.Text = res.Result_.FORMATTED_RESULT;
                    }
                    else if (ctl as RadCheckBox != null)
                    {
                        RadCheckBox cb = ctl as RadCheckBox;
                        cb.IsChecked = (res.Result_.FORMATTED_RESULT == "True" || res.Result_.FORMATTED_RESULT == "T");

                    }
                }
            }

            if (isHpv)
                RelevantTabs.Add(tab_HPV);






            if (RelevantTabs.Count > 2)
            {
                RelevantTabs.Insert(RelevantTabs.Count > 1 ? RelevantTabs.Count - 1 : 0, tabFreeTxt);
            }


            var clinicalTab = RelevantTabs.Where(key => key.Name.Contains("tab_clinic")).FirstOrDefault();
            if (clinicalTab != null)
            {
                setSpecimenSelectedItem(clinicalTab);
            }


        }

        public void setSpecimenSelectedItem(TabPage clinicalTab)
        {
            try
            {
                var panel = clinicalTab.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                RadGroupBox gb = panel.Controls.OfType<RadGroupBox>().Where(grb => grb.Name.ToLower().Contains("specimen")).FirstOrDefault();
                FlowLayoutPanel innerPanel = gb.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                RadDropDownList list = innerPanel.Controls.OfType<RadDropDownList>().Where(cb => cb.Name.ToLower().Contains("specimen")).FirstOrDefault();

                if (list != null)
                {
                    var LBcytology = list.Items.Where(item => item.Text.Contains("LB cytology")).FirstOrDefault();

                    if (LBcytology != null && list.SelectedItem == null)
                    {
                        list.SelectedItem = LBcytology;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public void groupBox_VisibilityChangeed(object sender, EventArgs e)
        {
            // set the height of the groupbox according to the controls inside.
            var gb = sender as RadGroupBox;

            if (gb != null)
            {
                var panel = gb.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();

                if (panel != null)
                    gb.Height = gb.Controls.OfType<FlowLayoutPanel>().FirstOrDefault().Height + 50;
            }
        }

        private List<RadControl> GetCbox(TabPage item)
        {
            List<RadControl> controls = new List<RadControl>();

            var layoutPanel = item.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (layoutPanel == null)
            {
                return null;//Error
            }

            //Gets the controls that are on the panel
            foreach (var cmb in layoutPanel.Controls.OfType<RadDropDownList>())
            {
                controls.Add(cmb);
            }
            foreach (var cb in layoutPanel.Controls.OfType<RadCheckBox>())
            {
                controls.Add(cb);
            }

            //Gets the controls that are within a group
            foreach (var rd in layoutPanel.Controls.OfType<RadGroupBox>())
            {
                foreach (var fp in rd.Controls.OfType<FlowLayoutPanel>())
                {
                    foreach (var cmb in fp.Controls.OfType<RadDropDownList>())
                    {
                        controls.Add(cmb);
                    }
                    foreach (var cb in fp.Controls.OfType<RadCheckBox>())
                    {
                        controls.Add(cb);
                    }
                }
            }

            return controls;
        }

        private void BuildControls(FlowLayoutPanel panelTab, IEnumerable<WrapperRtf> results4page)
        {

            panelTab.Controls.Clear();

            results4page = results4page.OrderBy(x => x.NewDescRow.U_ORDER).ThenBy(x => x.NewDescRow.U_GROUP).ToList();

            groupBoxList.Clear();

            foreach (var item in results4page)
            {
                //Gets the panel to place the control/
                var flowPanel = BuildGrpbx(panelTab, item);

                if (item.Result_.PHRASE_ID.HasValue)
                {

                    //Get phrase

               
                    var ph = _listData.GetPhraseByID(item.Result_.PHRASE_ID.Value);

                    //Build Label
                    RadLabel lbl;// = BuildLabel(item);

                    //Build Combo box
                    RadDropDownList cb;// = BuildComboBox(item);

                    //                    item.Ctl = cb;

                    //_listData.SetExistsList2Combo(cb, ph.PHRASE_ENTRY.ToList());

                    if (flowPanel != null)
                    {
                        lbl = BuildLabel(item, flowPanel);
                        cb = BuildComboBox(item, flowPanel);
                        flowPanel.Controls.Add(lbl);
                        flowPanel.Controls.Add(cb);
                        flowPanel.SetFlowBreak(cb, true);
                    }
                    else
                    {
                        lbl = BuildLabel(item, panelTab);
                        cb = BuildComboBox(item, panelTab);
                        panelTab.Controls.Add(lbl);
                        panelTab.Controls.Add(cb);
                        panelTab.SetFlowBreak(cb, true);

                    }

                    //System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("([0-9]+)");

                    //System.Text.RegularExpressions.Match mtach = reg.Match(

                    //list.Sort(System.Collections.Generic.Comparer<PHRASE_ENTRY>.Create((i1, i2) => i1.ORDER_NUMBER.HasValue && i2.ORDER_NUMBER.HasValue ? (int)(i1.ORDER_NUMBER.Value - i2.ORDER_NUMBER.Value) : -1));

                    var entries = ph.PHRASE_ENTRY.OrderBy(entry => entry.ORDER_NUMBER).ToList();

                    _listData.SetExistsList2Combo(cb, entries);
                    item.Ctl = cb;

                }
                else if (item.Result_.RESULT_TYPE == "B")
                {
                    var cbx = BuildCheckBox(item);

                    if (flowPanel != null)
                    {

                        flowPanel.Controls.Add(cbx);
                        flowPanel.SetFlowBreak(cbx, true);
                    }
                    else
                    {

                        panelTab.Controls.Add(cbx);
                        panelTab.SetFlowBreak(cbx, true);

                    }

                }
            }

        }

        private RadDropDownList BuildComboBox(WrapperRtf item, FlowLayoutPanel panel)
        {
            //var test = panel != null && panel.Controls.Count >= 2;
            var cb = new RadDropDownList()
            {
                Margin = panel != null && panel.Controls.Count >= 2 ? new Padding(2, 18, 2, 2) : new Padding(2),
                Width = 550,
                Height = 99,
                Name = item.Name,
                AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend,
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)

            };
            cb.ListElement.Font = new Font("Arial", 11f, FontStyle.Bold);
            cb.DropDownMinSize = new Size(cb.Width, 330);
            cb.GotFocus += (s, e) => zLang.English();
            AutoCompleteModE(cb);
            item.Ctl = cb;
            return cb;
        }

        private static RadLabel BuildLabel(WrapperRtf item, FlowLayoutPanel panel)
        {
            //var test = panel != null && panel.Controls.Count >= 2;
            RadLabel lbl = new RadLabel()
            {
                Margin = panel != null && panel.Controls.Count >= 2 ? new Padding(2, 18, 2, 2) : new Padding(2),
                Text = item.NewDescRow.U_NEW_RE_DESC.DESCRIPTION,
                Height = 99,
                Width = 300,
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
            };
            return lbl;
        }

        private static RadCheckBox BuildCheckBox(WrapperRtf item)
        {
            RadCheckBox chck = new RadCheckBox()
            {
                //Margin = new System.Windows.Forms.Padding(2),
                Text = item.NewDescRow.U_NEW_RE_DESC.DESCRIPTION,
                Height = 99,
                Name = item.Name,
                Width = 300,
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold),
                Margin = new Padding(10, 35, 0, 0),
            };
            chck.ButtonElement.CheckMarkPrimitive.CheckElement.UseFixedCheckSize = false;
            chck.ButtonElement.CheckMarkPrimitive.CheckElement.MinSize = new Size(15, 15);

            item.Ctl = chck;
            return chck;
        }

        //private void test(object sender, EventArgs e)
        //{
        //    var test = sender as RadGroupBox;
        //    Console.WriteLine(test.Text);

        //}

        private FlowLayoutPanel BuildGrpbx(FlowLayoutPanel panelTab, WrapperRtf item)
        {
            string grpName = item.NewDescRow.U_GROUP;
            if (grpName != null)
            {
                RadGroupBox rgb = groupBoxList.FirstOrDefault(x => x.Name == grpName);
                if (rgb == null)//If group down't exist on panel.
                {
                    //Build groupBox
                    rgb = new RadGroupBox()
                    {
                        Name = grpName,
                        Text = grpName,
                        Width = 1000,
                        Height = 250,
                        Dock = DockStyle.Top,
                        Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                        //Margin = new System.Windows.Forms.Padding(4),//new Padding(10,10,10,15),
                        Margin = new Padding(4, 22, 0, 0),
                        Padding = new Padding(4, 40, 4, 4),//new System.Windows.Forms.Padding(4),
                        RightToLeft = RightToLeft.No,
                    };

                    //rgb.Click += test1;
                    rgb.VisibleChanged += groupBox_VisibilityChangeed;
                    //Place GroupBox on panel
                    panelTab.Controls.Add(rgb);

                    //Create new FlowLayoutPanel to place on group box                    
                    var fp = new FlowLayoutPanel()
                    {
                        Location = new Point(4, 40),
                        Dock = DockStyle.None,
                        AutoSize = true,
                        AutoSizeMode = AutoSizeMode.GrowAndShrink
                    };

                    //Place inner FlowLayoutPanel on group box
                    rgb.Controls.Add(fp);

                    //A new line between the groups
                    panelTab.SetFlowBreak(rgb, true);

                    groupBoxList.Add(rgb);

                    //Return the inner FlowLayoutPanel
                    return rgb.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                }
                else
                {
                    //Returns the inner FlowLayoutPanel in case of exist
                    return rgb.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                }
            }
            //If is without group
            return null;
        }

        private void ShowHpvControls(bool isHpv, List<RadControl> resultControls)
        {

            resultControls.Where(x => x.Tag != null && x.Tag.ToString() == PapConstants.HPV_TAG)
                .Foreach(a => a.Visible = isHpv);
        }

        internal void SaveResults(List<WrapperRtf> currentResults)
        {
            foreach (var tab in _tabs)
            {
                //First child on tab is FlowLayoutPanel.
                var tabPanel = tab.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                if (tabPanel == null) { break; }


                var results4page = from res in currentResults
                                   where res.TestName == tabPanel.Name
                                   select res;
                var resultControls = GetCbox(tab);

                foreach (var res in results4page)
                {

                    var resLine = resultControls.FirstOrDefault(x => x.Name == res.Name);
                    if (resLine == null)
                        continue;


                    string val = "";
                    RadCheckBox r = resLine as RadCheckBox;

                    if (r != null) //is check box
                    {
                        val = r.IsChecked ? "T" : "F";
                    }

                    RadDropDownList cmb = resLine as RadDropDownList; //.se.Text;
                    if (cmb != null)
                    {

                        var entries = cmb.DataSource as List<PHRASE_ENTRY>;
                        if (entries != null)
                        {
                            PHRASE_ENTRY cmbVal = entries.FirstOrDefault(x => x.PHRASE_DESCRIPTION == cmb.Text);

                            if (cmbVal != null)
                                val = cmbVal.PHRASE_NAME;
                            else
                            {
                                val = cmb.Text;
                            }


                        }
                    }
                    //    RESULT res2Update = currentResults.Select(x => x.Result_).Where(x => x.RESULT_ID == res.ResultId).SingleOrDefault();
                    RESULT res2Update = dal.FindBy<RESULT>(x => x.RESULT_ID == res.ResultId).SingleOrDefault();

                    if (res2Update != null)
                    {
                        res2Update.FORMATTED_RESULT = val;
                        res2Update.ORIGINAL_RESULT = val;
                        dal.SaveChanges();
                    }


                }
            }

        }






        #endregion

        #region UI
        internal void EnableControls(bool p)
        {
            foreach (var item in _tabs)
            {
                var uc = item.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                if (uc == null)
                {
                    break;
                }

                uc.Enabled = p;
            }
        }
        internal void ClearScreen()
        {
            //   foreach ( var item in pages )
            foreach (var item in _tabs)
            {
                var uc = item.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                if (uc == null)
                {
                    break;
                }
                foreach (var cmb in uc.Controls.OfType<RadDropDownList>())
                {

                    cmb.Text = "";
                }

                foreach (var rd in uc.Controls.OfType<RadGroupBox>())
                {
                    foreach (var fp in rd.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (var cmb in fp.Controls.OfType<RadDropDownList>())
                        {

                            cmb.Text = "";
                        }
                    }
                }
            }


        }
        private void AutoCompleteModE(RadDropDownList rd)
        {
            rd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    rd.AutoCompleteMode = AutoCompleteMode.Suggest;
            rd.DropDownListElement.AutoCompleteSuggest = new CustomAutoCompleteSuggestHelper(rd.DropDownListElement);
            rd.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }



        #endregion
        internal void SetFocus()
        {
            //Todo:Set focus on first control on each tab
        }


    }
}
