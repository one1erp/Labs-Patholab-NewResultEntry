using LSExtensionWindowLib;
using LSSERVICEPROVIDERLib;
using NewResultEntry.Controls;
using NewResultEntry.Controls.PAP;
using ONE1_richTextCtrl;
using Patholab_Common;
using Patholab_DAL_V1;
using Patholab_XmlService;

//using PacsDigital;
using PreviewLetter;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

//using VB6Bridge;
using Path = System.IO.Path;
using Timer = System.Windows.Forms.Timer;

namespace NewResultEntry
{
    public partial class NewResultEntryCls : UserControl, IExtensionWindow
    {
        #region Ctor

        public NewResultEntryCls()
        {
            InitializeComponent();
            hisCytTabs = new List<TabPage>() { tab_diag, tab_Imp_diag, tab_macro, tab_micro, tab_snomed };
            BackColor = Color.FromName("Control");
            gbConsulation.BringToFront();

            txtBarcodeName.Focus();
            this.Disposed += NewResultEntryCls_Disposed;
            RemoveAllTabs();
        }

        private void RemoveAllTabs()
        {
            try
            {
                foreach (TabPage item in Tab.TabPages)
                {
                    if (Tab.TabPages.Contains(item))
                        Tab.TabPages.Remove(item);
                }
            }
            catch (Exception ex)
            {
                //       MessageBox.Show ( ex.Message );
            }
        }

        private void NewResultEntryCls_Disposed(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        #endregion Ctor

        #region Private fields

        private IExtensionWindowSite2 _ntlsSite;
        private INautilusServiceProvider _sp;
        private INautilusDBConnection _ntlsCon;
        private INautilusUser _ntlsUser;

        // private Connection _con;
        private DataLayer _dal;

        private Timer _timerFocus = null;
        private TextTemplateCtrl templateCtrl;

        // private SdgType sdgType;
        private bool _ispap;

        // private SDG _sdg, oldSDG;
        private SDG_DETAILS _sdgDtls, oldSDGdtls;

        private PapManger _papManager;
        private RTF_Manger _rtfManager;
        private List<WrapperRtf> _currentResults = new List<WrapperRtf>();

        //   List<SDG_RESULTS> _currentResults = new List<SDG_RESULTS>();
        private List<TabPage> hisCytTabs;

        private bool _ft = true;
        private Dictionary<string, string> _genderDic;
        private Dictionary<string, string> _priorityDic;

        //      private string _dicLangLoc;
        public bool DEBUG;

        private Timer _bckgrndSaver;
        private List<OPERATOR> Pathologists;
        private List<OPERATOR> Cytoscariners;

        private PHRASE_HEADER _InterfaceParams;

        private string _prevScreener, _prevPatholog;
        private PreviewLetterCls PreviewLetter;

        #endregion Private fields

        #region Initilaize

        /// <summary>
        /// From wf RE extension
        /// </summary>
        /// <param name="ntlp"></param>
        /// <param name="sdgName">Sdg name</param>
        public void runByWf(INautilusServiceProvider ntlp, string sdgName)
        {
            this._sp = ntlp;

            _ntlsCon = Utils.GetNtlsCon(_sp);
            _ntlsUser = Utils.GetNautilusUser(_sp);
            Init();
            txtBarcodeName.Text = sdgName;
            LoadSdg();
        }

        public void Init()
        {
            _dal = new DataLayer();
            if (DEBUG)
            {
                _dal.MockConnect();
                txtBarcodeName.Text = "P000004/21";

                _sdgDtls = _dal.Get_SDG_DETAILS(178978);
            }
            else
            {
                _dal.Connect(_ntlsCon);
            }
            button1.Visible = DEBUG;
            _InterfaceParams = _dal.GetPhraseByName("PacsDigital");

            InitilaizeData();
            InitSdgAttachments();

            InitilaizeRichSpellCtrl();
            txtBarcodeName.GotFocus += (s, e) => zLang.English();
            LoadDoctors();
            historyCtl1.ItemSelected += historyCtl_ItemSelected;

            SartBckgrTimer();
        }

        private void LoadDoctors()
        {
            var qDoctors =
  _dal.FindBy<OPERATOR>(o => o.LIMS_ROLE.NAME == "DOCTOR" || o.LIMS_ROLE.NAME == "Cytoscreener")
                              .Include(a => a.LIMS_ROLE)
                                .Include(x => x.OPERATOR_USER).OrderBy(x => x.NAME);

            var Doctors = qDoctors.ToList();//.First().OPERATOR_USER.U_HEBREW_NAMEOPERATOR_ID;

            CmbPatholog.DisplayMember = "FULL_NAME";
            CmbPatholog.ValueMember = "OPERATOR_ID";

            Pathologists = Doctors.Where(x => x.LIMS_ROLE.NAME == "DOCTOR").ToList();
            Cytoscariners = Doctors.Where(x => x.LIMS_ROLE.NAME == "Cytoscreener").ToList();

            CmbPatholog.DataSource = Doctors; //new List<string> { "test1","test2"};
            CmbPatholog.Text = "";
        }

        //Ashi 1/9/19
        //public ObservableCollection<OPERATOR> GetOperatoes ( string tag )
        //{
        //    ObservableCollection<OPERATOR> oper;

        //    if ( tag == "C" )
        //        oper = dal.FindBy<OPERATOR> ( o => o.LIMS_ROLE.NAME == "Cytoscreener" )
        //            //&& o.OPERATOR_USER.U_ORDER > 0)
        //            .Include ( op => op.OPERATOR_USER )
        //            .Include ( a => a.LIMS_ROLE )
        //            .OrderBy ( x => x.OPERATOR_USER.U_HEBREW_NAME )
        //            .ToObservableCollection ( );
        //    else if ( tag == "P" )
        //        oper = dal.FindBy<OPERATOR> ( o => o.LIMS_ROLE.NAME == "DOCTOR" )
        //            //&& o.OPERATOR_USER.U_ORDER > 0)
        //            .Include ( op => op.OPERATOR_USER )
        //            .Include ( a => a.LIMS_ROLE )
        //            .OrderBy ( x => x.OPERATOR_USER.U_HEBREW_NAME )
        //            .ToObservableCollection ( );
        //    else
        //        oper = dal.FindBy<OPERATOR> ( o => o.LIMS_ROLE.NAME == "DOCTOR"
        //                                           || o.LIMS_ROLE.NAME == "Cytoscreener"
        //                                           && o.OPERATOR_USER.U_ORDER > 0 )
        //            .Include ( op => op.OPERATOR_USER )
        //            .Include ( a => a.LIMS_ROLE )
        //            .OrderBy ( x => x.OPERATOR_USER.U_HEBREW_NAME )
        //            .ToObservableCollection ( );

        //    return oper;
        //}

        private void InitSdgAttachments()
        {
            this.sdgSttachmentsCtrl1.NautilusServiceProvider = this._sp;
            this.sdgSttachmentsCtrl1.dal = this._dal;
        }

        #region Focus Timer

        private void FirstFocus()
        {
            //First focus because nautius's bag
            _timerFocus = new Timer
            {
                Interval = 20000
            };
            _timerFocus.Tick += timerFocus_Tick;
            _timerFocus.Start();
            txtBarcodeName.Focus();
        }

        private void timerFocus_Tick(object sender, EventArgs e)
        {
            txtBarcodeName.Focus();
            _timerFocus.Stop();
            _timerFocus.Dispose();
        }

        #endregion Focus Timer

        private ListData listData;

        private async void InitilaizeData()
        {
            CrateADODB_CON();

            listData = new ListData(_dal);

            //    MessageBox.Show("לבדוק אם עזר האסינכרוני");
            await snomedCtrl1.InitilaizeData(listData, _dal);

            string[] test4tab = { "Recommendations", "Results", "Clinical info", "Adequacy" };

            List<TabPage> papTabs = new List<TabPage>();
            papTabs.Add(tab_clinic);
            papTabs.Add(tabAdeq);
            papTabs.Add(tab_Papres);
            papTabs.Add(tab_recom);
            tabAdeq.Controls.Add(new FlowLayoutPanel() { Name = PapConstants.Test_Adequacy, Dock = DockStyle.Fill });
            tab_clinic.Controls.Add(new FlowLayoutPanel() { Name = PapConstants.Test_Clinical_info, Dock = DockStyle.Fill });
            tab_Papres.Controls.Add(new FlowLayoutPanel() { Name = PapConstants.Test_Results, Dock = DockStyle.Fill });
            tab_recom.Controls.Add(new FlowLayoutPanel() { Name = PapConstants.Test_Recommendations, Dock = DockStyle.Fill });

            hpvManager.Init(_dal, _sp);
            _papManager = new PapManger(papTabs, tabFreeTxt, tabHPV, _dal);

            await _papManager.InitilaizeData(listData);

            try
            {
                //    _dicLangLoc = _dal.GetPhraseByName("System Parameters").PHRASE_ENTRY.FirstOrDefault(x => x.PHRASE_NAME == "LangDic").PHRASE_DESCRIPTION;
                _genderDic = _dal.GetPhraseByName("Gender").PhraseEntriesDictonary;
                _priorityDic = _dal.GetPhraseByName("Priority").PhraseEntriesDictonary;
            }
            catch (Exception exception)
            {
                Logger.WriteLogFile(exception);
            }
        }

        private void InitilaizeRichSpellCtrl()
        {
            _rtfManager = new RTF_Manger(_dal, rich_diag, rich_impDiag, rich_mic, rich_mac, rich_FreeTxt);
            _rtfManager.TemplatesClicked += RtfManager_tmcclicked;
        }

        private void RtfManager_tmcclicked()
        {
            var sdg = _dal.FindBy<SDG>(s => s.SDG_ID == _sdgDtls.SDG_ID).FirstOrDefault();

            #region extracted to another class

            string All_organs = "ALL";
            string l = sdg.NAME[0].ToString();

            //If has organ get it, else get "All
            var organs4Sdg = sdg.SAMPLEs.Select(SM => SM.SAMPLE_USER.U_ORGAN ?? All_organs).Distinct().ToList();
            if (!organs4Sdg.Contains(All_organs))
                organs4Sdg.Add(All_organs);

            var organsList = (from item in _dal.GetAll<U_NLIST_USER>()
                              where item.U_SDG_TYPE == l
                              select item).ToList();

            List<U_NLIST_USER> list4Show = new List<U_NLIST_USER>();
            foreach (var item in organsList)
            {
                foreach (var org in organs4Sdg)
                {
                    if (item.U_ORGANS != null && item.U_ORGANS.Contains(org))
                    {
                        list4Show.Add(item);
                    }
                }
            }
            var organs4Show = list4Show.Select(SM => SM.U_TEXT).ToList().Distinct();
            if (organs4Show.Count() < 1)
            {
                MessageBox.Show(".לא קיימים טמפלייטים", Constants.MboxCaption, MessageBoxButtons.OK,
                          MessageBoxIcon.Hand);
                return;
            }

            #endregion extracted to another class

            templateCtrl = new TextTemplateCtrl(organs4Show);
            templateCtrl.ShowDialog();
            if (Tab.SelectedTab != null && !string.IsNullOrEmpty(templateCtrl.SelectedText))
            {
                RichSpellCtrl r = Tab.SelectedTab.Controls.OfType<RichSpellCtrl>().ToList()[0];
                if (r != null)
                    r.AppendText(templateCtrl.SelectedText);
            }
        }

        private void pb_Load(object sender, EventArgs e)
        {
            //Set default zoom to 120
            RichSpellCtrl richSpell = sender as RichSpellCtrl;
            if (richSpell != null)
            {
                //    richSpell.ZoomTo(1.8F);
            }
        }

        private void CrateADODB_CON()
        {
            try
            {
                if (requestRemarkControl1 == null)
                {
                    requestRemarkControl1 = new RequestRemarkNet.RequestRemarkControl();
                }
                //double oid = _ntlsUser != null ? _ntlsUser.GetOperatorId() : 1;
                requestRemarkControl1.GetConnectionParams(_ntlsCon, _ntlsSite, _ntlsUser);
                requestRemarkControl1.InitializeConnection();
                requestRemarkControl1.StatusChanged += delegate
                {
                    if (_sdgDtls != null && _sdgDtls.STATUS != "A")
                    {
                        btnAuth.Enabled =
                        requestRemarkControl1.GetRemarkStatus(_sdgDtls.SDG_NAME) !=
                        "P";
                    }
                };
            }
            catch (Exception ex)
            {
                Logger.WriteLogFile(ex);
            }
        }

        #endregion Initilaize

        #region Events

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                GC.Collect();
                openPacsBrowser1.Refresh_Sectra();
                _bckgrndSaver.Stop();
                LoadSdg();
                StartBcgrnd();
            }
        }

        private void StartBcgrnd()
        {
            if (_sdgDtls != null && "VPCI".Contains(_sdgDtls.STATUS))
                _bckgrndSaver.Start();
            else
            {
                _bckgrndSaver.Stop();
            }
        }

        private void LoadSdg()
        {
            try
            {
                // if (_sdg != null)
                //{
                //  oldSDG = _sdg;
                // }
                // _sdg = null;
                if (_sdgDtls != null)
                {
                    oldSDGdtls = _sdgDtls;
                }
                _sdgDtls = null;
                var tb = txtBarcodeName;
                if (tb == null || string.IsNullOrEmpty(tb.Text))
                    return;

                string sn = tb.Text.Replace(".", "/").ToUpper();

                _sdgDtls = _dal.Get_SDG_DETAILS(sn);

                if (_sdgDtls == null || _sdgDtls.STATUS == "U")
                //  if (_sdg == null)
                {
                    MessageBox.Show(".דרישה לא קיימת או לא התקבלה", Constants.MboxCaption, MessageBoxButtons.OK,
                                    MessageBoxIcon.Hand);

                    ClearScreen();
                    return;
                }
                else
                {
                    //Todo:select from view
                    //openPacsBrowser1.InitializeData(_sdg, _InterfaceParams);
                    //    MessageBox.Show("Todo:select from view");

                    LoadExtraMaterialCtrl();

                    LoadConsultVal();

                    ClearScreen();

                    noNeedToLoadSdg = false;
                    LoadNewSdg();

                    if (_ft)
                    {
                        rich_diag.SetRichDefenitions();
                        _ft = false;
                    }
                }
            }
            catch
                (Exception
                    ex)
            {
                MessageBox.Show(".שגיאה בטעינת הדרישה" + ex.Message,
                                Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLogFile(ex);
            }
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var tt = this.Tab.SelectedTab;
                if (tt == null)
                    return;

                if (tt.Controls.Count < 1)
                {
                    return;
                }
                RichSpellCtrl t = tt.Controls[0] as RichSpellCtrl;
                if (t != null)
                {
                    if (t.Name == "rich_impDiag")
                    {
                        zLang.Hebrew();
                    }
                    else
                    {
                        zLang.English();
                    }
                    t.Focus();
                }
            }
            catch (Exception exception)
            {
                Logger.WriteLogFile(exception);
                MessageBox.Show("Error on tab_SelectedIndexChanged \n " + exception.Message);
            }
        }

        private void radButtonAuthorise_Click(object sender, EventArgs e)
        {
            try
            {
                //First Save
                if (!SaveRequest())
                    return;

                _bckgrndSaver.Stop();

                //And then check if can authorize
                string validMsg = CanAuthorise();

                if (!string.IsNullOrEmpty(validMsg))
                {
                    MessageBox.Show(validMsg, Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    EnableControls(_sdgDtls.STATUS != "A");
                    return;
                }

                if (_ispap)
                {
                    var sdg = _dal.FindBy<SDG>(s => s.SDG_ID == _sdgDtls.SDG_ID).FirstOrDefault();
                    sdg.SDG_USER.U_WEEK_NBR = 909;
                    //MessageBox.Show("Todo:select from view");
                    _dal.SaveChanges();
                }
                else //is not pap
                {
                    var autoSdg = new FireEventXmlHandler(_sp, "Authorized SDG");
                    autoSdg.CreateFireEventXml("SDG", _sdgDtls.SDG_ID, "ToAuthoriseHis");
                    var s = autoSdg.ProcssXmlWithOutSave();

                    if (!s)
                    {
                        MessageBox.Show(autoSdg.ErrorResponse);
                        return;
                    }
                }

                //Ashi-08-07-21
                //Anyway print
                PrintPDFLetter();

                _dal.InsertToSdgLog(_sdgDtls.SDG_ID, "RE.AUTH", (long)_ntlsCon.GetSessionId(), "מסך הכנסת תוצאות - אוטוריזציה");
                ClearScreen();
                EnableControls(false);

                txtBarcodeName.Focus();
            }
            catch (Exception ex)
            {
                EnableControls(true);
                MessageBox.Show("Error on Authorise Click" + ex.Message, Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLogFile(ex);

                noNeedToLoadSdg = false;
                LoadNewSdg();
            }
        }

        private string CanAuthorisePap()
        {
            if (_ispap)
            {
                //First check the HPV test
                if (hpvManager.Is_HPV_request && !hpvManager.CanSave())
                {
                    return "הזנת תוצאות HPV אינה תקינה";
                }

                //And then check other results
                string sql = "select LIMS.PAP_MANDATORY_RESULT('" + _sdgDtls.SDG_ID + "') as res from  dual";
                var res = _dal.GetDynamicStr(sql);
                if (res != "True" && res != "T")
                {
                    return res;
                }
            }
            return null;
        }

        private string CanAuthorise()
        {
            string stopMsg = "";
            if (_ispap)
            {
                stopMsg = this.CanAuthorisePap();
            }
            else
            {
                if (string.IsNullOrEmpty(rich_mic.GetOriginalText()))
                {
                    stopMsg = "Micro is mandatory" + "\n";
                }
                stopMsg += snomedCtrl1.CanAuthorise();
            }
            return stopMsg;
        }

        private void PrintPDFLetter()
        {
            var www = new FireEventXmlHandler(_sp, "Print PDF Letter");
            www.CreateFireEventXml("SDG", _sdgDtls.SDG_ID, "Print PDF Letter");
            var sSs = www.ProcssXmlWithOutSave();
            if (!sSs)
            {
                Logger.WriteLogFile(www.ErrorResponse);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (_ntlsSite != null)
                _ntlsSite.CloseWindow();
        }

        #endregion Events

        #region Load  SDG

        private void LoadNewSdg()
        {
            long sdgId = _sdgDtls.SDG_ID;
            _sdgDtls = null;

            _sdgDtls = _dal.Get_SDG_DETAILS(sdgId);

            var sdg = _dal.FindBy<SDG>(s => s.SDG_ID == sdgId).FirstOrDefault();

            openPacsBrowser1.InitializeData(sdg, _InterfaceParams);

            HasRevision();

            _ispap = _sdgDtls.SDG_NAME[0] == 'P';

            if (_sdgDtls.STATUS == "A")
            {
                MessageBox.Show("Sdg is Authorised, No changes can be made!",
                    Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            EnableControls(_sdgDtls.STATUS != "A");

            //AE CODE

            //Load sdg details for sdg
            LoadSdgDetails(sdg);

            ////Get results by sdg ID
            //var currentResultsTemp = (from rl in _dal.FindBy<RESULT>(x => x.TEST.ALIQUOT.SAMPLE.SDG_ID == _sdgDtls.SDG_ID)
            //                          where rl.TEST.STATUS != "X"
            //                          select new WrapperRtf()
            //                          {
            //                              Result_ = rl,
            //                              Name = rl.NAME,
            //                              NewDescRow = rl.RESULT_TEMPLATE.U_NEW_RE_DESC_USER.FirstOrDefault(),
            //                              //NewDescRow = _ispap ? (rl.NAME equals newReDesc.RESULT_TEMPLATE.NAME) : null
            //                              //NewDescRow = rl.RESULT_TEMPLATE.PARENT_VERSION_ID
            //                              //     FormattedResult = rl.FORMATTED_RESULT,
            //                              ResultId = rl.RESULT_ID,
            //                              //TestId = rl.TEST_ID,
            //                              //AliquotId = rl.TEST.ALIQUOT_ID,
            //                              TestName = rl.TEST.NAME
            //                          }).ToList();

            //Get results by sdg ID

            var currentResultsTemp = (from rl in _dal.Get_SDG_RESULTS(_sdgDtls.SDG_ID)
                                      where rl.TESTSTATUS != "X"
                                      select new WrapperRtf()
                                      {
                                          Result_ = rl,
                                      }).ToList();

            _currentResults.Clear();

            var maligRes = currentResultsTemp.FirstOrDefault(x => x.Name == Constants.Malignant);
            if (maligRes != null)
            {
                picMalig.Visible = (maligRes.Result_.FORMATTED_RESULT != null && maligRes.Result_.FORMATTED_RESULT.StartsWith("T"));
            }

            if (_ispap)
            {
                _currentResults = currentResultsTemp.ToList(); // or - I added .ToList() because we need deep copy and not shallow copy.
                //_currentResults = currentResultsTemp;
                LoadPrevData();

                hpvManager.LoadHPVrequest(sdg);
                //      MessageBox.Show("Todo:select from view");

                _papManager.LoadResults(_currentResults, hpvManager.Is_HPV_request);
            }

            //Dont move it UP, because hpv tab
            if (!noNeedToLoadSdg)
            {
                UI_By_Type();
                noNeedToLoadSdg = false;
            }

            foreach (WrapperRtf rl in currentResultsTemp)
            {
                if (_rtfManager._result2RichText.ContainsKey(rl.Name) && !_currentResults.Any(res => res.ResultId == rl.ResultId) || (!_ispap && snomedCtrl1.ContainsResult(rl.Name)))
                {
                    _currentResults.Add(rl);
                }
            }
            _rtfManager.LoadResults(sdg, _currentResults);

            if (!_ispap)
            {
                snomedCtrl1.EmptyAllCombos();
                snomedCtrl1.LoadSnomedResults(_currentResults);
            }

            sdgSttachmentsCtrl1.Sdg = sdg;

            if (!noNeedToLoadSdg)
            {
                var Historylist = _dal.FindBy<SDG_USER>(x => x.U_PATIENT.Value == sdg.SDG_USER.U_PATIENT.Value)
    .Include(x => x.CLIENT).Include(a => a.SDG);
                historyCtl1.LoadData(sdg.NAME, Historylist);
                noNeedToLoadSdg = false;
            }

            try
            {
                //     WriteMemory();
                // requestRemarksBridge1.sampleInput(_sdg.NAME);
                //   WriteMemory();
                //  btAuth.Enabled = requestRemarksBridge1.GetRequestStatus(_sdg.NAME) != "P";

                requestRemarkControl1.sampleInput(_sdgDtls.SDG_NAME);
            }
            catch (Exception ex12)
            {
                Logger.WriteLogFile(ex12);
            }

            if (!DEBUG)
                _dal.InsertToSdgLog(_sdgDtls.SDG_ID, "RE.SELECT",
                    (long)_ntlsCon.GetSessionId(), "מסך הכנסת תוצאות - שליפה");

            //pop

            rich_diag.SetConstZoom();
            if (Tab.TabCount > 0)
                Tab.SelectTab(0);

            _papManager.SetFocus();

            GC.Collect();
        }

        private void HasRevision()
        {
            //    string sw = _sdg.NAME.Substring(0, 10);
            string sw = _sdgDtls.SDG_NAME.Substring(0, 10);
            bool b = _dal.FindBy<SDG>(s => s.NAME.Contains(sw)).Count() > 1;
            lblRev.Visible = b && _sdgDtls.SDG_NAME.Length == 10;
            ;
        }

        private void historyCtl_ItemSelected(string obj)
        {
            _bckgrndSaver.Stop();

            var q = (from item in _dal.FindBy<SDG_USER>(x => x.U_PATHOLAB_NUMBER == obj)
                     select new { item.SDG_ID, item.U_PDF_PATH }).FirstOrDefault();

            if (q != null)
            {
                _bckgrndSaver.Start();
                var SDG_ID = q.SDG_ID;
                var U_PDF_PATH = q.U_PDF_PATH;
                PreviewLetter = new PreviewLetterCls();
                PreviewLetter.runPreviewLetter(SDG_ID, U_PDF_PATH, _ntlsCon, _dal);
                _bckgrndSaver.Stop();
            }
            StartBcgrnd();
        }

        #region UI

        private void ClearScreen()
        {
            EnableControls(false);
            sdgSttachmentsCtrl1.Reset();
            // requestRemarksBridge1.Reset();
            requestRemarkControl1.Reset();
            _currentResults.Clear();
            if (historyCtl1 != null)
                historyCtl1.ClearList();

            pictureBox1.Image = new Bitmap(Path.Combine(Utils.GetResourcePath(), "sdgU.ico"));

            lblPathoName.Text = string.Empty;
            CmbPatholog.Text = string.Empty;

            gbClient.Controls.OfType<RadTextBox>().Foreach(x => x.Text = string.Empty);
            gbOrder.Controls.OfType<RadTextBox>().Foreach(x => x.Text = string.Empty);
            gbDates.Controls.OfType<RadDateTimePicker>().Foreach(x => x.SetToNullValue());// default ( DateTime ) );
            //gbDates.Controls.OfType<RadDateTimePicker> ( ).Foreach ( x => x.Text = string.Empty );

            snomedCtrl1.ClearScreen();
            _papManager.ClearScreen();
            //hpvManager.ClearScreen();
            _rtfManager.ClearScreen();
            hpvManager.ClearScreen();

            txtBarcodeName.Text = string.Empty;
            if (Tab.TabCount > 0)
                Tab.SelectTab(0);
        }

        private void EnableControls(bool p)
        {
            //snomed tab
            snomedCtrl1.EnableControls(p);
            _papManager.EnableControls(p);
            _rtfManager.EnableControls(p);
            hpvManager.EnableControls(p);

            //buttons
            btnAuth.Enabled = p;
            btnSave.Enabled = p;
        }

        private void UI_By_Type()
        {
            try
            {
                //  BtnSetDef_pap.Visible = _ispap && _sdg.STATUS == "V";
                BtnSetDef_pap.Visible = _ispap && _sdgDtls.STATUS == "V";

                //נתנאל ביקש שתמיד יתאפשר כפתור אישור
                //if ( _ispap )
                //    btnAuth.Visible = ( "IC" ).Contains ( _sdg.STATUS );
                //else
                //{
                //    btnAuth.Visible = true;
                //}
                btnAttach.Visible = true;

                //BtnExtReq.Visible = !ispap;
                //radButton2.Visible = BtnExtReq.Visible;
                //Show relevant tabs

                if (_ispap)
                {
                    Tab.RightToLeft = RightToLeft.No;

                    OrderTabs(_papManager.RelevantTabs, hisCytTabs, hpvManager.Is_HPV_request);
                }
                else
                {
                    Tab.RightToLeft = RightToLeft.Yes;
                    OrderTabs(hisCytTabs, _papManager.RelevantTabs);
                }
            }
            catch (Exception e)
            {
                Logger.WriteLogFile(e);
                MessageBox.Show("חובה לאתחל את המסך. " + e.Message, "Nautilus - Critical Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderTabs(List<TabPage> tabs2Add, List<TabPage> tabs2Remove, bool hpvTab = false)
        {
            //IntPtr h = this.Tab.Handle;

            //if (_sdg.SAMPLEs.FirstOrDefault().ALIQUOTs.FirstOrDefault().TESTs.FirstOrDefault().NAME == "Cobas HPV" && _sdg.SAMPLEs.FirstOrDefault().ALIQUOTs.FirstOrDefault().TESTs.Count == 1)
            //{
            //    HideTabPage(tab_clinic);
            //    HideTabPage(tab_Papres);
            //    HideTabPage(tab_recom);
            //    HideTabPage(tabAdeq);
            //}
            //if (oldSDG == null || (!"HistologyCytology".Contains(_sdg.SdgType.ToString()) || !"HistologyCytology".Contains(oldSDG.SdgType.ToString())) && _sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_PARTS.NAME != oldSDG.SDG_USER.U_ORDER.U_ORDER_USER.U_PARTS.NAME)
            if (oldSDGdtls == null || (_sdgDtls.SDG_NAME[0] == 'P' || oldSDGdtls.SDG_NAME[0] == 'P') && _sdgDtls.PARTS_NAME != oldSDGdtls.PARTS_NAME)
            {
                foreach (TabPage tab in Tab.TabPages)
                {
                    HideTabPage(tab);
                }

                if (tabs2Add != null)
                {
                    foreach (var item in tabs2Add)
                    {
                        ShowTabPage(item);
                    }
                }
                if (hpvTab)
                    ShowTabPage(tabHPV);
                else
                {
                    HideTabPage(tabHPV);
                    if (_sdgDtls.PARTS_NAME != null && !_sdgDtls.PARTS_NAME.Contains("פאפ דק"))
                    //if (!_sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_PARTS.NAME.Contains("פאפ דק"))
                    {
                        HideTabPage(tabFreeTxt);
                    }
                }
            }

            //if (tabs2Remove != null)
            //{
            //    foreach (var item in tabs2Remove)
            //    {
            //        HideTabPage(item);
            //    }

            //    //NOT working by run by wf,dont know
            //}
        }

        #endregion UI

        #region Load SDG Details

        private Color defColor = Color.FromArgb(232, 241, 252);

        private void setbtnColor(RadButton radButton1, bool change)
        {
            Color color;
            if (change)
            {
                color = Color.GreenYellow;
            }
            else
            {
                color = Color.FromArgb(232, 241, 252);
                ;
            }

            ((FillPrimitive)radButton1.GetChildAt(0).GetChildAt(0)).BackColor =
                color;
            ((FillPrimitive)radButton1.GetChildAt(0).GetChildAt(0)).BackColor2 =
                color;
            ((FillPrimitive)
                radButton1.GetChildAt(0).GetChildAt(0)).BackColor3 = color;
            ((FillPrimitive)
                radButton1.GetChildAt(0).GetChildAt(0)).BackColor4 = color;
            ((FillPrimitive)radButton1.GetChildAt(0).GetChildAt(0)).BackColor =
                color;
        }

        private void LoadSdgDetails(SDG sdg)
        {
            picQC.Visible = _sdgDtls.U_IS_QC == "T";
            //setbtnColor(btnAttach, _sdg.SDG_USER.U_ATFILENM != null);
            //setbtnColor(btnLetter, _sdg.SDG_USER.U_PDF_PATH != null);
            setbtnColor(btnLetter, _sdgDtls.U_PDF_PATH != null);
            setbtnColor(btnLetter, _sdgDtls.U_ATFILENM != null);

            LoadDates();
            LoadPatientDetails();
            LoadPhysiciansDetails();
            snomedCtrl1.LoadSdgDetails(_sdgDtls);
            //bool hasReq = false;

            //hasReq = _sdgDtls.EXTRAREQ_COUNT > 0;

            //my code (AE)

            var exReqID = sdg?.U_EXTRA_REQUEST_USER?.FirstOrDefault()?.U_EXTRA_REQUEST_ID;

            bool isValueFound = false;

            if (exReqID != null)
            {
                var count = _dal.FindBy<U_EXTRA_REQUEST_DATA_USER>(x => x.U_EXTRA_REQUEST_ID == exReqID && (x.U_REQ_TYPE.Equals("H")) || x.U_REQ_TYPE.Equals("O") || x.U_REQ_TYPE.Equals("I")).Count();
                if (count > 0)
                {
                    isValueFound = true;
                }
            }

            //Ashi 21/5/20 Cahnge condition for button color
            //foreach ( var sample in _sdg.U_EXTRA_REQUEST_USER.Count>0.SAMPLEs )
            //{
            //    foreach ( var aliquoT in sample.ALIQUOTs )
            //    {
            //        if ( aliquoT.ALIQUOT_USER.U_GLASS_TYPE == "S" )
            //        {
            //            hasReq = true;
            //            break;
            //        }
            //    }
            //}
            setbtnColor(BtnExtReq, isValueFound);
        }

        private void LoadDates()
        {
            //הפניה
            //     var dd = _sdg.SDG_USER.U_REQUEST_DATE;
            var dd = _sdgDtls.DATE_HAFNAYA;
            if (dd.HasValue)
                dtHafnaya.Text = dd.Value.ToShortDateString();

            try//זמני
            {
                if (_sdgDtls.SDG_NAME[0] == 'B')// && _sdg.SdgType == SdgType.Histology)
                {
                    //הגעה
                    if (!string.IsNullOrEmpty(_sdgDtls.CONTAINER_NAME))
                    //if (_sdg.SDG_USER.U_CONTAINER_ID.HasValue)                //.U_CONTAINER != null )Is more expensive to check on relation than ID
                    {
                        //   var ddg = (from item in _dal.FindBy<U_CONTAINER_USER>(x =>
                        //       x.U_CONTAINER_ID == _sdg.SDG_USER.U_CONTAINER_ID)
                        //         select item.U_RECEIVED_ON).FirstOrDefault();

                        //      dd = _sdg.SDG_USER.U_CONTAINER.U_CONTAINER_USER; ;
                        //      if (ddg.HasValue)
                        //  dtAgaa.Value = ddg.Value;

                        dtAgaa.Value = _sdgDtls.CONTAINER_RECEIVE.Value;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //קבלה
            //    dd = _sdg.CREATED_ON;
            //  if (dd.HasValue)
            //    dtKabala.Text = dd.Value.ToShortDateString();
            if (_sdgDtls.DATE_KABALA.HasValue)
            { dtKabala.Text = _sdgDtls.DATE_KABALA.Value.ToShortDateString(); }

            //הדפסה
            //   dd = _sdg.COMPLETED_ON;
            //  if (dd.HasValue)
            //    dtCompl.Text = dd.Value.ToShortDateString();
            if (_sdgDtls.DATE_COMPLETED.HasValue)
            {
                dtCompl.Text = _sdgDtls.DATE_COMPLETED.Value.ToShortDateString();
            }

            //אישור
            //dd = _sdg.AUTHORISED_ON;
            //if (dd.HasValue)
            //    dtAuthOn.Text = dd.Value.ToShortDateString();

            if (_sdgDtls.DATE_AUTHORISED.HasValue)
                dtAuthOn.Text = _sdgDtls.DATE_AUTHORISED.Value.ToShortDateString();
        }

        private void LoadPatientDetails()
        {
            //pictureBox1.Image = new Bitmap(Path.Combine(Patholab_Common.Utils.GetResourcePath(), "sdg" + _sdgDtls.STATUS + ".ico"));
            pictureBox1.Image = new Bitmap(Path.Combine(Patholab_Common.Utils.GetResourcePath(), "sdg" + _sdgDtls.STATUS + ".ico"));

            //var client = (from c in _dal.FindBy<CLIENT_USER>(x => x.CLIENT_ID == _sdg.SDG_USER.U_PATIENT)
            //              select new
            //              {
            //                  c.U_FIRST_NAME,
            //                  c.U_LAST_NAME,
            //                  c.CLIENT.NAME,
            //                  c.U_GENDER,
            //                  c.U_DATE_OF_BIRTH
            //              }
            //    ).SingleOrDefault();
            //if (client == null)
            //{
            //    MessageBox.Show("לא הוגדר פציינט לדרישה.");
            //    return;
            //}

            try
            {
                //_dal.ReloadEntity ( client );
            }
            catch (Exception exc)
            {
            }

            //  string cln = client.U_FIRST_NAME + " " + client.U_LAST_NAME + " - " + client.NAME + " ";
            string cln = _sdgDtls.CLIENT_FNAME + " " + _sdgDtls.CLIENT_LNAME + " ";
            //   lblPathoName.Text = string.Format("{0} - {1}", cln, _sdg.SDG_USER.U_PATHOLAB_NUMBER);
            lblPathoName.Text = string.Format("{0} - {1}", cln, _sdgDtls.PATHOLAB_NUMBER);

            //Left side
            // txtFN.Text = string.Format("{0} {1}", client.U_FIRST_NAME, client.U_LAST_NAME);
            txtFN.Text = string.Format("{0} {1}", _sdgDtls.CLIENT_FNAME, _sdgDtls.CLIENT_LNAME);

            txtGender.Text = _genderDic.ContainsKey(_sdgDtls.CLIENT_GENDER) ? _genderDic[_sdgDtls.CLIENT_GENDER] : "";

            // txtIdentity.Text = client.NAME;
            txtIdentity.Text = _sdgDtls.CLIENT_NAME;

            // if (client.U_DATE_OF_BIRTH.HasValue)
            //   txtDB.Text = client.U_DATE_OF_BIRTH.Value.ToShortDateString();

            if (_sdgDtls.CLIENT_BDAY.HasValue)
                txtDB.Text = _sdgDtls.CLIENT_BDAY.Value.ToShortDateString();
        }

        private bool IsPap()
        {
            return _sdgDtls.SDG_NAME[0] == 'P';
        }

        private void LoadPhysiciansDetails()
        {
            if (IsPap())//_sdg.SdgType == SdgType.Pap)
            {
                CmbPatholog.DataSource = Cytoscariners;
            }
            else
            {
                CmbPatholog.DataSource = Pathologists;
            }
            //physicians
            // if ( _sdg.SDG_USER.REFERRING_PHYSIC != null )
            //   txtREf.Text = _sdg.SDG_USER.REFERRING_PHYSIC.NAME;
            //if (_sdg.SDG_USER.IMPLEMENTING_PHYSICIAN != null)
            //{
            //    var supp = _sdg.SDG_USER.IMPLEMENTING_PHYSICIAN.SUPPLIER_USER;
            //    txtImp.Text = string.Format("{0} {1} {2}", supp.U_DEGREE, supp.U_FIRST_NAME, supp.U_LAST_NAME);
            //}
            txtImp.Text = _sdgDtls.IMPLEMENTING_PHYSICIAN_FULL_NAME;

            //Loda customers
            //   if (_sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_CUSTOMER1 != null)
            //   txtCust1st.Text = _sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_CUSTOMER1.NAME;
            txtCust1st.Text = _sdgDtls.CUSTOMER_NAME;//.SDG_USER.U_ORDER.U_ORDER_USER.U_CUSTOMER1.NAME;
            try
            {
                //string sql = "select LIMS.FUNC_COMPLET_BY('" + _sdg.SDG_ID + "') as res from  dual";
                //sql = "select LIMS.FUNC_COMPLET_BY('" + _sdgDtls.SDG_ID + "') as res from  dual";
                //var res = _dal.GetDynamicStr(sql);

                //    txtKaldanit.Text = res;
                txtKaldanit.Text = _sdgDtls.TYPED_BY;
            }
            catch (Exception exq)
            {
                Logger.WriteLogFile(exq);
                txtKaldanit.Text = "";
            }
            //    if ( _sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_CUSTOMER2 != null ) txt2cust.Text = _sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_CUSTOMER2.NAME;

            // if (_sdg.SDG_USER.U_PRIORITY != null)
            if (!string.IsNullOrEmpty(_sdgDtls.PRIORITY))
            {
                //  txtPriority.Text = _priorityDic.ContainsKey(_sdg.SDG_USER.U_PRIORITY.ToString()) ? _priorityDic[_sdg.SDG_USER.U_PRIORITY.ToString()] : "";
                txtPriority.Text = _priorityDic.ContainsKey(_sdgDtls.PRIORITY) ? _priorityDic[_sdgDtls.PRIORITY.ToString()] : "";
            }

            //    txtClinic.Text = _sdg.SDG_USER.IMPLEMENTING_CLINIC != null ? _sdg.SDG_USER.IMPLEMENTING_CLINIC.NAME : null;
            txtClinic.Text = _sdgDtls.IMPLEMENTING_CLINIC;

            //   CmbPatholog.Text = _sdg.SDG_USER.PATHOLOG != null ? _sdg.SDG_USER.PATHOLOG.OPERATOR_USER.OPERATOR.FULL_NAME : null;
            CmbPatholog.Text = _sdgDtls.INTENDED_PATHOLOG;
        }

        #endregion Load SDG Details

        #endregion Load  SDG

        #region Save methods

        private void btnSave_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            try
            {
                SaveRequest();
            }
            catch (Exception ex)
            {
                EnableControls(true);

                MessageBox.Show("Error on btnSave_Click" + ex.Message, Constants.MboxCaption, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Logger.WriteLogFile(ex);
            }
            txtBarcodeName.Focus();
        }

        //my code (AE)
        private void LoadConsultVal()
        {
            chk_isConsult.Checked = _sdgDtls.u_isConsult == "T";
            var sdg_user = _dal.FindBy<SDG_USER>(x => x.SDG_ID == _sdgDtls.SDG_ID);
            string consult_description = sdg_user.FirstOrDefault().U_CONSULT_DESC;
            txt_consult_desc.Text = consult_description;
        }

        private void SaveCounsult(SDG s)
        {
            var a = s.STATUS;
            var currentSDG_user = s.SDG_USER;

            currentSDG_user.U_CONSULT_DESC = txt_consult_desc.Text;
            currentSDG_user.U_ISCONSULT = chk_isConsult.Checked ? "T" : "F";

            _dal.SaveChanges();
        }

        private bool SaveRequest()
        {
            _bckgrndSaver.Stop();

            var sdg = _dal.FindBy<SDG>(s => s.SDG_ID == _sdgDtls.SDG_ID).FirstOrDefault();

            SaveCounsult(sdg);

            if (_ispap) //Is pap request
            {
                //Save HPV if exists
                if (hpvManager.Is_HPV_request)
                    hpvManager.Save();

                //Save others results for pap
                _papManager.SaveResults(_currentResults);
            }
            else // Save Snomed for his and cyt request.
            {
                snomedCtrl1.SaveSnomedTab(sdg, _currentResults);
            }

            //Saving rtf is for every type of sdg
            _rtfManager.SaveResults(_currentResults);
            _rtfManager.SaveAsText(_currentResults);

            //Save data for next sdg
            //It must be here before changing status
            SavePreviousData(sdg);

            //Set status for all tree to Completed
            SetStatusToC();

            //Insert to sdg log
            long sid = 1;

            if (!DEBUG)
            {
                sid = (long)_ntlsCon.GetSessionId();
            }

            string strOldPatholog = "";
            string strNewPatholog = CmbPatholog.Text;

            if (!string.IsNullOrEmpty(_sdgDtls.INTENDED_PATHOLOG))
            {
                strOldPatholog = _sdgDtls.INTENDED_PATHOLOG;// _sdg.SDG_USER.PATHOLOG.OPERATOR_USER.OPERATOR.FULL_NAME;
            }

            if (strOldPatholog != strNewPatholog)
            {
                sdg.SDG_USER.U_PATHOLOG = (long)CmbPatholog.SelectedValue;

                _dal.InsertToSdgLog(sdg.SDG_ID, "PATHOLOG.UPD", sid, "New: " + strNewPatholog + " , Old: " + strOldPatholog);
            }

            _dal.InsertToSdgLog(sdg.SDG_ID, "RE.SAVE", sid, "מסך חדש הכנסת תוצאות - שמירה");
            _dal.SaveChanges();

            //_dal = new DataLayer();
            //if (!DEBUG)
            //    _dal.Connect(_ntlsCon);
            //else _dal.MockConnect();

            //Reload the sdg after saving
            noNeedToLoadSdg = true;
            LoadNewSdg();//This row  must to be here

            StartBcgrnd();

            return true;
        }

        //שומר ערכים שיישתלו אוטומטית בבדיקה הבאה
        private void SavePreviousData(SDG sdg, string statusList = "V")
        {
            if (_ispap && sdg != null && statusList.Contains(sdg.STATUS))
            {
                var p = _currentResults.FirstOrDefault(x => x.Name == PapConstants.Sign_by_1_screener);
                if (p != null)
                    _prevScreener = p.Result_.FORMATTED_RESULT;

                p = _currentResults.FirstOrDefault(x => x.Name == PapConstants.SignbyPatholog);
                if (p != null)
                    _prevPatholog = p.Result_.FORMATTED_RESULT;
            }
        }

        private void LoadPrevData(string statusList = "V")
        {
            if (statusList.Contains(_sdgDtls.STATUS))
            {
                var p = _currentResults.FirstOrDefault(x => x.Name == PapConstants.Sign_by_1_screener);
                if (p != null && string.IsNullOrEmpty(p.Result_.FORMATTED_RESULT))
                    p.Result_.FORMATTED_RESULT = _prevScreener;

                p = _currentResults.FirstOrDefault(x => x.Name == PapConstants.SignbyPatholog);
                if (p != null && string.IsNullOrEmpty(p.Result_.FORMATTED_RESULT))
                    p.Result_.FORMATTED_RESULT = _prevPatholog;
            }
        }

        private void SetStatusToC()
        {
            //string sql = "UPDATE lims.RESULT SET lims.RESULT.STATUS = 'C' WHERE lims.RESULT.RESULT_ID IN (SELECT lims.RESULT.RESULT_ID FROM lims.RESULT INNER JOIN lims.TEST ON lims.RESULT.TEST_ID = lims.TEST.TEST_ID INNER JOIN lims.ALIQUOT " +
            //            "ON lims.ALIQUOT.ALIQUOT_ID = lims.TEST.ALIQUOT_ID INNER JOIN lims.SAMPLE ON lims.SAMPLE.SAMPLE_ID = lims.ALIQUOT.SAMPLE_ID WHERE lims.RESULT.STATUS != 'X' AND lims.SAMPLE.SDG_ID = " + _sdgDtls.SDG_ID + ")";
            //_dal.ExecuteScalar(sql);

            //sql = "UPDATE lims.TEST SET lims.TEST.STATUS = 'C' WHERE lims.TEST.TEST_ID IN (SELECT lims.TEST.TEST_ID FROM lims.TEST INNER JOIN lims.ALIQUOT " +
            //            "ON lims.ALIQUOT.ALIQUOT_ID = lims.TEST.ALIQUOT_ID INNER JOIN lims.SAMPLE ON lims.SAMPLE.SAMPLE_ID = lims.ALIQUOT.SAMPLE_ID WHERE lims.TEST.STATUS != 'X' AND lims.SAMPLE.SDG_ID = " + _sdgDtls.SDG_ID + ")";

            //_dal.ExecuteScalar(sql);

            //sql = "UPDATE lims.ALIQUOT SET lims.ALIQUOT.STATUS = 'C' WHERE lims.ALIQUOT.ALIQUOT_ID IN (SELECT lims.ALIQUOT.ALIQUOT_ID FROM lims.ALIQUOT INNER JOIN lims.SAMPLE ON lims.SAMPLE.SAMPLE_ID = lims.ALIQUOT.SAMPLE_ID "
            //+ "WHERE ALIQUOT.STATUS != 'X' AND SAMPLE.SDG_ID = " + _sdgDtls.SDG_ID + ")";

            //_dal.ExecuteScalar(sql);

            //sql = "UPDATE lims.SAMPLE SET lims.SAMPLE.STATUS = 'C' WHERE lims.SAMPLE.SAMPLE_ID IN (SELECT lims.SAMPLE.SAMPLE_ID FROM lims.SAMPLE WHERE lims.SAMPLE.STATUS != 'X' AND lims.SAMPLE.SDG_ID = " + _sdgDtls.SDG_ID + ")";
            //_dal.ExecuteScalar(sql);
            (from rl in
                 _dal.FindBy<RESULT>(x => x.TEST.ALIQUOT.SAMPLE.SDG_ID == _sdgDtls.SDG_ID && x.STATUS != "X")
             select rl).Foreach(x => x.STATUS = "C");
            (from rl in
                 _dal.FindBy<TEST>(x => x.ALIQUOT.SAMPLE.SDG_ID == _sdgDtls.SDG_ID && x.STATUS != "X")
             select rl).Foreach(x => x.STATUS = "C");
            (from rl in
                 _dal.FindBy<ALIQUOT>(x => x.SAMPLE.SDG_ID == _sdgDtls.SDG_ID && x.STATUS != "X")
             select rl).Foreach(x => x.STATUS = "C");
            (from rl in
                 _dal.FindBy<SAMPLE>(x => x.SDG_ID == _sdgDtls.SDG_ID && x.STATUS != "X")
             select rl).Foreach(x => x.STATUS = "C");
            (from rl in
                 _dal.FindBy<SDG>(x => x.SDG_ID == _sdgDtls.SDG_ID && x.STATUS != "X")
             select rl).Foreach(x => x.STATUS = "C");
            _dal.SaveChanges();
        }

        #endregion Save methods

        #region IExtension window

        public void SetSite(object site)
        {
            _ntlsSite = (IExtensionWindowSite2)site;
            _ntlsSite.SetWindowInternalName("NewResultEntry");
            _ntlsSite.SetWindowRegistryName("NewResultEntry");
            _ntlsSite.SetWindowTitle("NewResultEntry");
        }

        public void SetServiceProvider(object serviceProvider)
        {
            _sp = serviceProvider as NautilusServiceProvider;
            _ntlsCon = Utils.GetNtlsCon(_sp);
        }

        public void RestoreSettings(int hKey)
        {
        }

        public bool SaveData()
        {
            return true;
        }

        public void SaveSettings(int hKey)
        {
        }

        public void SetParameters(string parameters)
        {
            bckgrndinterval = 10000;//Default time if isn't interval in parameters command(setparametres function)
            int.TryParse(parameters, out bckgrndinterval);
        }

        public bool CloseQuery()
        {
            var dgr1 = MessageBox.Show(@"?האם אתה בטוח שברצונך לצאת ",
                Constants.MboxCaption, MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (dgr1 == DialogResult.Yes)
            {
                if (_bckgrndSaver != null)

                    _bckgrndSaver.Stop();
                if (_dal != null)
                {
                    _dal.Close();
                    _dal = null;
                }
                //if (_con != null)
                //{
                //    _con.Close();
                //    _con = null;
                //}
                if (_bckgrndSaver != null)
                    _bckgrndSaver.Dispose();

                this.Dispose(true);

                GC.Collect();

                return true;
            }
            else
            {
                return false;
            }
        }

        public WindowRefreshType DataChange()
        {
            return WindowRefreshType.windowRefreshNone;
        }

        public WindowButtonsType GetButtons()
        {
            return WindowButtonsType.windowButtonsNone;
        }

        public void Internationalise()
        {
        }

        public void PreDisplay()
        {
            //     xmlProcessor = Utils.GetXmlProcessor(_sp);

            _ntlsUser = Utils.GetNautilusUser(_sp);

            Init();
            EnableControls(false);
            FirstFocus();
        }

        public void Setup()
        {
            //   Logger.WriteLogFile("START RE - SETUP");
            //  throw new NotImplementedException();
        }

        public WindowRefreshType ViewRefresh()
        {
            return WindowRefreshType.windowRefreshNone;
        }

        public void refresh()
        {
        }

        #endregion IExtension window

        private int bckgrndinterval = 10000;//Default time if isn't interval in parameters command(setparametres function)

        private void SartBckgrTimer()
        {
            _bckgrndSaver = new Timer();
            _bckgrndSaver.Interval = bckgrndinterval;
            _bckgrndSaver.Tick += BckgrndSaver_Tick;
            StartBcgrnd();
        }

        private int showMsgcnt = 0;
        private object recordId;

        private void BckgrndSaver_Tick(object sender, EventArgs e)
        {
            if (DEBUG || _sdgDtls == null)
                return;

            try
            {
                if ("ARXU".Contains(_sdgDtls.STATUS))
                    return;

                _rtfManager.SaveResults(_currentResults);
                _dal.SaveChanges();
            }
            catch (Exception exception)
            {
                if (showMsgcnt < 2)//Show message from timer just 2 times
                {
                    MessageBox.Show("Exception " + exception.Message);
                    showMsgcnt++;
                }
            }
        }

        #region Button events

        private void PrintLetter_Click(object sender, EventArgs e)
        {
            PrintPDFLetter();
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            var client = _dal.FindBy<CLIENT>(x => x.NAME == _sdgDtls.CLIENT_NAME).SingleOrDefault();

            EditClientFrm updatPat = new EditClientFrm(client, _genderDic, _sp);
            updatPat.PatientEdited += updatPat_PatientEdited;
            updatPat.ShowDialog();
        }

        private void updatPat_PatientEdited(CLIENT clientUp)
        {
            var client = clientUp.CLIENT_USER;
            string cln = client.U_FIRST_NAME + " " + client.U_LAST_NAME + " - " + clientUp.NAME + " ";
            lblPathoName.Text = string.Format("{0} - {1}", cln, _sdgDtls.PATHOLAB_NUMBER);

            //Left side
            txtFN.Text = string.Format("{0} {1}", client.U_FIRST_NAME, client.U_LAST_NAME);
            txtGender.Text = _genderDic.ContainsKey(client.U_GENDER) ? _genderDic[client.U_GENDER] : "";
            if (client.U_DATE_OF_BIRTH.HasValue)
                txtDB.Text = client.U_DATE_OF_BIRTH.Value.ToShortDateString().ToString();
        }

        private void ExtraReq_Click(object sender, EventArgs e)
        {
            long sid = 1;

            if (_sdgDtls == null)
                return;
            if (!DEBUG)
            {
                sid = (long)_ntlsCon.GetSessionId();
            }
            _bckgrndSaver.Stop();
            var sdg = _dal.FindBy<SDG>(s => s.SDG_ID == _sdgDtls.SDG_ID).FirstOrDefault();
            ExtraRequest extra = new ExtraRequest(_dal, sdg, _sp, sid, listData);

            extra.FormClosed += extra_FormClosed;
            extra.WindowState = FormWindowState.Maximized;
            extra.ShowDialog();
        }

        private void extra_FormClosed(object sender, FormClosedEventArgs e)
        {
            var extWindow = sender as ExtraRequest;
            setbtnColor(BtnExtReq, extWindow.HasReq);
            //if (extWindow!=null && extWindow.)

            StartBcgrnd();
        }

        #region PDF

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (_sdgDtls == null)
                return;

            try
            {
                if (_sdgDtls.U_ATFILENM != null)
                //if (_sdg.SDG_USER.U_ATFILENM != null)
                {
                    var pdf = new PdfViewerFrm(_sdgDtls.U_ATFILENM);
                    //  var pdf = new PdfViewerFrm(_sdg.SDG_USER.U_ATFILENM);
                    pdf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("לא קיים מסמך מצורף.", Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Load pdf!" + ex.Message, Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLogFile(ex);
            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            //if (_sdgDtls == null)
            //    return;

            //try
            //{
            //    //  if (_sdg.SDG_USER.U_PDF_PATH != null)
            //    if (_sdgDtls.U_PDF_PATH != null)
            //    {
            //        //var pdf = new PdfViewerFrm(_sdg.SDG_USER.U_PDF_PATH);
            //        var pdf = new PdfViewerFrm(_sdgDtls.U_PDF_PATH);
            //        pdf.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("לא קיים מכתב תשובה.", Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error on Load pdf! " + ex.Message, Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Logger.WriteLogFile(ex);

            //}

            try
            {
                if (_sdgDtls == null) return;

                _bckgrndSaver.Start();
                PreviewLetter = new PreviewLetter.PreviewLetterCls();
                PreviewLetter.runPreviewLetter(_sdgDtls.SDG_ID, _sdgDtls.U_PDF_PATH, _ntlsCon, _dal);
                _bckgrndSaver.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Load pdf! " + ex.Message, Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLogFile(ex);
            }
        }

        #endregion PDF

        #endregion Button events

        private const string Pap_Quick_Answer = "Pap Quick Answer";

        private void BtnSetDef_pap_Click(object sender, EventArgs e)
        {
            double opid = 1;
            if (!"VP".Contains(_sdgDtls.STATUS))
            {
                MessageBox.Show("Error. The SDG needs to be in status 'Received' or 'In Progress' to use this key.");
                return;
            }
            if (!DEBUG)
            {
                opid = _ntlsUser.GetOperatorId();
                OPERATOR co = _dal.FindBy<OPERATOR>(x => x.OPERATOR_ID == opid).SingleOrDefault();
                if (co != null)
                {
                    bool pqa = co.OPERATOR_GROUP.Any(x => x.LIMS_GROUP.NAME == Pap_Quick_Answer);
                    if (!pqa && opid != 1)
                    {
                        MessageBox.Show(string.Format("Error. You need to be in '{0}' group to use this key.", Pap_Quick_Answer));
                        return;
                    }
                }
            }

            // string sql = "select LIMS.SET_DEFAULT_FOR_PAP('" + _sdg.SDG_ID + "','" + opid + "') as res from  dual";
            //var res = _dal.GetDynamicStr ( sql );
            var res = _dal.OK_PAP_RESULT(_sdgDtls.SDG_ID);
            if (!res)
            {
                MessageBox.Show("Error putting results in SDG");
                return;
            }

            //_dal = new DataLayer();
            //if (!DEBUG)
            //    _dal.Connect(_ntlsCon);
            //else _dal.MockConnect();

            //למה לא עובד
            //  LoadPrevData();

            SetStatusToC();

            LoadNewSdg();
        }

        private void sdgSttachmentsCtrl1_Load(object sender, EventArgs e)
        {
        }

        #region Tab Manipulation

        private void HideTabPage(TabPage tp)
        {
            if (Tab.TabPages.Contains(tp))
                Tab.TabPages.Remove(tp);
        }

        private void ShowTabPage(TabPage tp)
        {
            ShowTabPage(tp, Tab.TabPages.Count);
        }

        private void ShowTabPage(TabPage tp, int index)
        {
            if (Tab.TabPages.Contains(tp))
                return;
            InsertTabPage(tp, index);
        }

        private void InsertTabPage(TabPage tabpage, int index)
        {
            if (index < 0 || index > Tab.TabCount)
                throw new ArgumentException("Index out of Range.");
            Tab.TabPages.Add(tabpage);
            if (index < Tab.TabCount - 1)
                do
                {
                    SwapTabPages(tabpage, (Tab.TabPages[Tab.TabPages.IndexOf(tabpage) - 1]));
                }
                while (Tab.TabPages.IndexOf(tabpage) != index);
            Tab.SelectedTab = tabpage;
        }

        private void SwapTabPages(TabPage tp1, TabPage tp2)
        {
            if (Tab.TabPages.Contains(tp1) == false || Tab.TabPages.Contains(tp2) == false)
                throw new ArgumentException("TabPages must be in the TabControls TabPageCollection.");

            int Index1 = Tab.TabPages.IndexOf(tp1);
            int Index2 = Tab.TabPages.IndexOf(tp2);
            Tab.TabPages[Index1] = tp2;
            Tab.TabPages[Index2] = tp1;

            //Uncomment the following section to overcome bugs in the Compact Framework
            //Tab.SelectedIndex = Tab.SelectedIndex;
            //string tp1Text, tp2Text;
            //tp1Text = tp1.Text;
            //tp2Text = tp2.Text;
            //tp1.Text=tp2Text;
            //tp2.Text=tp1Text;
        }

        #endregion Tab Manipulation

        private void txtBarcodeName_TextChanged(object sender, EventArgs e)
        {
        }

        public bool noNeedToLoadSdg
        {
            get;
            set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ExtraReq_Click(null, null);
            btnSave_Click(null, null);
        }

        private void LoadExtraMaterialCtrl()
        {
            var sdg = _dal.FindBy<SDG>(s => s.SDG_ID == _sdgDtls.SDG_ID).FirstOrDefault();

            if (sdg != null)
            {
                long sid = 1;
                if (!DEBUG)
                    sid = (long)_ntlsCon.GetSessionId();

                extraMaterialCtrl1.init(_dal, sdg, _sp, _ntlsUser, sid);
            }
        }

        private void extraMaterialCtrl1_Load(object sender, EventArgs e)
        {
        }

        private void rich_diag_Load(object sender, EventArgs e)
        {
        }

        private void chk_isConsult_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pnlDetails_Paint(object sender, PaintEventArgs e)
        {
        }

        private void radLabel19_Click(object sender, EventArgs e)
        {
        }

        private void chk_isConsult_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void radLabel6_Click(object sender, EventArgs e)
        {
        }

        private void CmbPatholog_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
        }

        private void rich_diag_Load_1(object sender, EventArgs e)
        {
        }

        private void btnConsultSave_Click(object sender, EventArgs e)
        {
        }

        private void chk_isConsult_CheckedChanged_2(object sender, EventArgs e)
        {
        }

        private void txt_consult_desc_TextChanged(object sender, EventArgs e)
        {
        }

        private void gbConsulation_Enter(object sender, EventArgs e)
        {
        }

        private void radLabel19_Click_1(object sender, EventArgs e)
        {
        }

        private void gbDates_Enter(object sender, EventArgs e)
        {
        }

        private void btnConsultSave_Click_1(object sender, EventArgs e)
        {
            var sdg = _dal.FindBy<SDG>(s => s.SDG_ID == _sdgDtls.SDG_ID).FirstOrDefault();
            SaveCounsult(sdg);
        }

        private void openPacsBrowser1_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void historyCtl1_Load(object sender, EventArgs e)
        {
        }

        private void NewResultEntryCls_Load(object sender, EventArgs e)
        {
        }
    }
}