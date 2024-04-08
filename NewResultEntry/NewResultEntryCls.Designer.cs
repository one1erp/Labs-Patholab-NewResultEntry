
using System.Windows.Forms;
using Telerik.WinControls;

namespace NewResultEntry
{
    partial class NewResultEntryCls
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewResultEntryCls));
            this.Tab = new System.Windows.Forms.TabControl();
            this.tab_diag = new System.Windows.Forms.TabPage();
            this.rich_diag = new ONE1_richTextCtrl.RichSpellCtrl();
            this.tab_Imp_diag = new System.Windows.Forms.TabPage();
            this.rich_impDiag = new ONE1_richTextCtrl.RichSpellCtrl();
            this.tab_macro = new System.Windows.Forms.TabPage();
            this.rich_mac = new ONE1_richTextCtrl.RichSpellCtrl();
            this.tab_micro = new System.Windows.Forms.TabPage();
            this.rich_mic = new ONE1_richTextCtrl.RichSpellCtrl();
            this.tab_snomed = new System.Windows.Forms.TabPage();
            this.snomedCtrl1 = new NewResultEntry.Controls.SnomedCtrl();
            this.tab_clinic = new System.Windows.Forms.TabPage();
            this.tabAdeq = new System.Windows.Forms.TabPage();
            this.tab_Papres = new System.Windows.Forms.TabPage();
            this.tab_recom = new System.Windows.Forms.TabPage();
            this.tabHPV = new System.Windows.Forms.TabPage();
            this.hpvManager = new HPV_RE.HPV_RE_Manager();
            this.tabFreeTxt = new System.Windows.Forms.TabPage();
            this.rich_FreeTxt = new ONE1_richTextCtrl.RichSpellCtrl();
            this.pnlSdgDetails = new Telerik.WinControls.UI.RadPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBarcodeName = new Telerik.WinControls.UI.RadTextBox();
            this.picMalig = new System.Windows.Forms.PictureBox();
            this.lblRev = new Telerik.WinControls.UI.RadLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPathoName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picQC = new System.Windows.Forms.PictureBox();
            this.gbConsulation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultSave = new System.Windows.Forms.Button();
            this.txt_consult_desc = new System.Windows.Forms.TextBox();
            this.chk_isConsult = new System.Windows.Forms.CheckBox();
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.txtKaldanit = new Telerik.WinControls.UI.RadTextBox();
            this.dtCompl = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtHafnaya = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtAuthOn = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtAgaa = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtKabala = new Telerik.WinControls.UI.RadDateTimePicker();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPriority = new Telerik.WinControls.UI.RadTextBox();
            this.txtClinic = new Telerik.WinControls.UI.RadTextBox();
            this.CmbPatholog = new Telerik.WinControls.UI.RadDropDownList();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCust1st = new Telerik.WinControls.UI.RadTextBox();
            this.txtImp = new Telerik.WinControls.UI.RadTextBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.txtDB = new Telerik.WinControls.UI.RadTextBox();
            this.BTNcLIENT = new Telerik.WinControls.UI.RadButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGender = new Telerik.WinControls.UI.RadTextBox();
            this.txtIdentity = new Telerik.WinControls.UI.RadTextBox();
            this.txtFN = new Telerik.WinControls.UI.RadTextBox();
            this.pnlButtons = new Telerik.WinControls.UI.RadPanel();
            this.extraMaterialCtrl1 = new ExtraMaterialControl.ExtraMaterialCtrl();
            this.BtnExtReq = new Telerik.WinControls.UI.RadButton();
            this.BtnSetDef_pap = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnAuth = new Telerik.WinControls.UI.RadButton();
            this.btnLetter = new Telerik.WinControls.UI.RadButton();
            this.BtnExit = new Telerik.WinControls.UI.RadButton();
            this.btnAttach = new Telerik.WinControls.UI.RadButton();
            this.requestRemarkControl1 = new RequestRemarkNet.RequestRemarkControl();
            this.openPacsBrowser1 = new PacsDigital.OpenPacsBrowser();
            this.sdgSttachmentsCtrl1 = new SdgAttachments.SdgSttachmentsCtrl();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.DetTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabhistor = new System.Windows.Forms.TabPage();
            this.historyCtl1 = new NewResultEntry.Controls.HistoryCtl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.Tab.SuspendLayout();
            this.tab_diag.SuspendLayout();
            this.tab_Imp_diag.SuspendLayout();
            this.tab_macro.SuspendLayout();
            this.tab_micro.SuspendLayout();
            this.tab_snomed.SuspendLayout();
            this.tabHPV.SuspendLayout();
            this.tabFreeTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSdgDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcodeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMalig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPathoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQC)).BeginInit();
            this.gbConsulation.SuspendLayout();
            this.gbDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaldanit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHafnaya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAuthOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAgaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKabala)).BeginInit();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPatholog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCust1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImp)).BeginInit();
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNcLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExtReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSetDef_pap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            this.DetTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabhistor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.tab_diag);
            this.Tab.Controls.Add(this.tab_Imp_diag);
            this.Tab.Controls.Add(this.tab_macro);
            this.Tab.Controls.Add(this.tab_micro);
            this.Tab.Controls.Add(this.tab_snomed);
            this.Tab.Controls.Add(this.tab_clinic);
            this.Tab.Controls.Add(this.tabAdeq);
            this.Tab.Controls.Add(this.tab_Papres);
            this.Tab.Controls.Add(this.tab_recom);
            this.Tab.Controls.Add(this.tabHPV);
            this.Tab.Controls.Add(this.tabFreeTxt);
            this.Tab.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Tab.Location = new System.Drawing.Point(413, 118);
            this.Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Tab.Name = "Tab";
            this.Tab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tab.RightToLeftLayout = true;
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1385, 894);
            this.Tab.TabIndex = 3;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tab_diag
            // 
            this.tab_diag.Controls.Add(this.rich_diag);
            this.tab_diag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tab_diag.Location = new System.Drawing.Point(4, 39);
            this.tab_diag.Margin = new System.Windows.Forms.Padding(4);
            this.tab_diag.Name = "tab_diag";
            this.tab_diag.Padding = new System.Windows.Forms.Padding(4);
            this.tab_diag.Size = new System.Drawing.Size(1377, 851);
            this.tab_diag.TabIndex = 0;
            this.tab_diag.Tag = "HIS";
            this.tab_diag.Text = "אבחנה ופרטים קליניים";
            this.tab_diag.UseVisualStyleBackColor = true;
            // 
            // rich_diag
            // 
            this.rich_diag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_diag.DocumentRtl = System.Windows.Forms.RightToLeft.Yes;
            this.rich_diag.Font = new System.Drawing.Font("Arial", 12F);
            this.rich_diag.Location = new System.Drawing.Point(4, 4);
            this.rich_diag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rich_diag.Name = "rich_diag";
            this.rich_diag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rich_diag.Size = new System.Drawing.Size(1369, 843);
            this.rich_diag.TabIndex = 0;
            this.rich_diag.Load += new System.EventHandler(this.rich_diag_Load_1);
            // 
            // tab_Imp_diag
            // 
            this.tab_Imp_diag.Controls.Add(this.rich_impDiag);
            this.tab_Imp_diag.Location = new System.Drawing.Point(4, 39);
            this.tab_Imp_diag.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Imp_diag.Name = "tab_Imp_diag";
            this.tab_Imp_diag.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Imp_diag.Size = new System.Drawing.Size(1377, 851);
            this.tab_Imp_diag.TabIndex = 6;
            this.tab_Imp_diag.Tag = "HIS";
            this.tab_Imp_diag.Text = "חומר לבדיקה";
            this.tab_Imp_diag.UseVisualStyleBackColor = true;
            // 
            // rich_impDiag
            // 
            this.rich_impDiag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_impDiag.DocumentRtl = System.Windows.Forms.RightToLeft.No;
            this.rich_impDiag.Font = new System.Drawing.Font("Arial", 12F);
            this.rich_impDiag.Location = new System.Drawing.Point(4, 4);
            this.rich_impDiag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rich_impDiag.Name = "rich_impDiag";
            this.rich_impDiag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rich_impDiag.Size = new System.Drawing.Size(1369, 843);
            this.rich_impDiag.TabIndex = 1;
            // 
            // tab_macro
            // 
            this.tab_macro.Controls.Add(this.rich_mac);
            this.tab_macro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tab_macro.Location = new System.Drawing.Point(4, 39);
            this.tab_macro.Margin = new System.Windows.Forms.Padding(4);
            this.tab_macro.Name = "tab_macro";
            this.tab_macro.Padding = new System.Windows.Forms.Padding(4);
            this.tab_macro.Size = new System.Drawing.Size(1377, 851);
            this.tab_macro.TabIndex = 1;
            this.tab_macro.Tag = "HIS";
            this.tab_macro.Text = "מאקרו";
            this.tab_macro.UseVisualStyleBackColor = true;
            // 
            // rich_mac
            // 
            this.rich_mac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_mac.DocumentRtl = System.Windows.Forms.RightToLeft.No;
            this.rich_mac.Font = new System.Drawing.Font("Arial", 12F);
            this.rich_mac.Location = new System.Drawing.Point(4, 4);
            this.rich_mac.Margin = new System.Windows.Forms.Padding(4);
            this.rich_mac.Name = "rich_mac";
            this.rich_mac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rich_mac.Size = new System.Drawing.Size(1369, 843);
            this.rich_mac.TabIndex = 1;
            // 
            // tab_micro
            // 
            this.tab_micro.Controls.Add(this.rich_mic);
            this.tab_micro.Location = new System.Drawing.Point(4, 39);
            this.tab_micro.Margin = new System.Windows.Forms.Padding(4);
            this.tab_micro.Name = "tab_micro";
            this.tab_micro.Padding = new System.Windows.Forms.Padding(4);
            this.tab_micro.Size = new System.Drawing.Size(1377, 851);
            this.tab_micro.TabIndex = 5;
            this.tab_micro.Tag = "HIS";
            this.tab_micro.Text = "מיקרו";
            this.tab_micro.UseVisualStyleBackColor = true;
            // 
            // rich_mic
            // 
            this.rich_mic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_mic.DocumentRtl = System.Windows.Forms.RightToLeft.No;
            this.rich_mic.Font = new System.Drawing.Font("Arial", 12F);
            this.rich_mic.Location = new System.Drawing.Point(4, 4);
            this.rich_mic.Margin = new System.Windows.Forms.Padding(4);
            this.rich_mic.Name = "rich_mic";
            this.rich_mic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rich_mic.Size = new System.Drawing.Size(1369, 843);
            this.rich_mic.TabIndex = 1;
            // 
            // tab_snomed
            // 
            this.tab_snomed.Controls.Add(this.snomedCtrl1);
            this.tab_snomed.Location = new System.Drawing.Point(4, 39);
            this.tab_snomed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_snomed.Name = "tab_snomed";
            this.tab_snomed.Size = new System.Drawing.Size(1377, 851);
            this.tab_snomed.TabIndex = 7;
            this.tab_snomed.Tag = "HIS";
            this.tab_snomed.Text = "איזורי בדיקה ואבחנות";
            // 
            // snomedCtrl1
            // 
            this.snomedCtrl1._sdgDet = null;
            this.snomedCtrl1._signByList = null;
            this.snomedCtrl1._smList = null;
            this.snomedCtrl1._sTList = null;
            this.snomedCtrl1.AutoScroll = true;
            this.snomedCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snomedCtrl1.Location = new System.Drawing.Point(0, 0);
            this.snomedCtrl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snomedCtrl1.Name = "snomedCtrl1";
            this.snomedCtrl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.snomedCtrl1.Size = new System.Drawing.Size(1377, 851);
            this.snomedCtrl1.TabIndex = 0;
            this.snomedCtrl1.TumorBList = null;
            // 
            // tab_clinic
            // 
            this.tab_clinic.Location = new System.Drawing.Point(4, 39);
            this.tab_clinic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_clinic.Name = "tab_clinic";
            this.tab_clinic.Size = new System.Drawing.Size(1377, 851);
            this.tab_clinic.TabIndex = 8;
            this.tab_clinic.Tag = "PAP";
            this.tab_clinic.Text = "Clinical";
            // 
            // tabAdeq
            // 
            this.tabAdeq.Location = new System.Drawing.Point(4, 39);
            this.tabAdeq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdeq.Name = "tabAdeq";
            this.tabAdeq.Size = new System.Drawing.Size(1377, 851);
            this.tabAdeq.TabIndex = 9;
            this.tabAdeq.Tag = "PAP";
            this.tabAdeq.Text = "Adequency";
            // 
            // tab_Papres
            // 
            this.tab_Papres.Location = new System.Drawing.Point(4, 39);
            this.tab_Papres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Papres.Name = "tab_Papres";
            this.tab_Papres.Size = new System.Drawing.Size(1377, 851);
            this.tab_Papres.TabIndex = 10;
            this.tab_Papres.Tag = "PAP";
            this.tab_Papres.Text = "Results";
            // 
            // tab_recom
            // 
            this.tab_recom.Location = new System.Drawing.Point(4, 39);
            this.tab_recom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_recom.Name = "tab_recom";
            this.tab_recom.Size = new System.Drawing.Size(1377, 851);
            this.tab_recom.TabIndex = 11;
            this.tab_recom.Tag = "PAP";
            this.tab_recom.Text = "Recommendation";
            // 
            // tabHPV
            // 
            this.tabHPV.Controls.Add(this.hpvManager);
            this.tabHPV.Location = new System.Drawing.Point(4, 39);
            this.tabHPV.Margin = new System.Windows.Forms.Padding(4);
            this.tabHPV.Name = "tabHPV";
            this.tabHPV.Padding = new System.Windows.Forms.Padding(4);
            this.tabHPV.Size = new System.Drawing.Size(1377, 851);
            this.tabHPV.TabIndex = 12;
            this.tabHPV.Text = "HPV";
            this.tabHPV.UseVisualStyleBackColor = true;
            // 
            // hpvManager
            // 
            this.hpvManager.BackColor = System.Drawing.SystemColors.Control;
            this.hpvManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpvManager.GetSdgRes = null;
            this.hpvManager.Is_HPV_request = false;
            this.hpvManager.ListHighRisk = null;
            this.hpvManager.ListLowRisk = null;
            this.hpvManager.Location = new System.Drawing.Point(4, 4);
            this.hpvManager.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.hpvManager.Name = "hpvManager";
            this.hpvManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hpvManager.Size = new System.Drawing.Size(1369, 843);
            this.hpvManager.TabIndex = 0;
            // 
            // tabFreeTxt
            // 
            this.tabFreeTxt.Controls.Add(this.rich_FreeTxt);
            this.tabFreeTxt.Location = new System.Drawing.Point(4, 39);
            this.tabFreeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.tabFreeTxt.Name = "tabFreeTxt";
            this.tabFreeTxt.Padding = new System.Windows.Forms.Padding(4);
            this.tabFreeTxt.Size = new System.Drawing.Size(1377, 851);
            this.tabFreeTxt.TabIndex = 13;
            this.tabFreeTxt.Text = "Free Text";
            this.tabFreeTxt.UseVisualStyleBackColor = true;
            // 
            // rich_FreeTxt
            // 
            this.rich_FreeTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_FreeTxt.DocumentRtl = System.Windows.Forms.RightToLeft.No;
            this.rich_FreeTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.rich_FreeTxt.Location = new System.Drawing.Point(4, 4);
            this.rich_FreeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rich_FreeTxt.Name = "rich_FreeTxt";
            this.rich_FreeTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rich_FreeTxt.Size = new System.Drawing.Size(1369, 843);
            this.rich_FreeTxt.TabIndex = 2;
            // 
            // pnlSdgDetails
            // 
            this.pnlSdgDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSdgDetails.CausesValidation = false;
            this.pnlSdgDetails.Controls.Add(this.button1);
            this.pnlSdgDetails.Controls.Add(this.txtBarcodeName);
            this.pnlSdgDetails.Controls.Add(this.picMalig);
            this.pnlSdgDetails.Controls.Add(this.lblRev);
            this.pnlSdgDetails.Controls.Add(this.label2);
            this.pnlSdgDetails.Controls.Add(this.lblPathoName);
            this.pnlSdgDetails.Controls.Add(this.radLabel3);
            this.pnlSdgDetails.Controls.Add(this.pictureBox1);
            this.pnlSdgDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSdgDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pnlSdgDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlSdgDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSdgDetails.Name = "pnlSdgDetails";
            // 
            // 
            // 
            this.pnlSdgDetails.RootElement.AccessibleDescription = null;
            this.pnlSdgDetails.RootElement.AccessibleName = null;
            this.pnlSdgDetails.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 250, 125);
            this.pnlSdgDetails.Size = new System.Drawing.Size(1959, 89);
            this.pnlSdgDetails.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1453, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 21);
            this.button1.TabIndex = 46;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBarcodeName
            // 
            this.txtBarcodeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcodeName.AutoSize = false;
            this.txtBarcodeName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBarcodeName.CausesValidation = false;
            this.txtBarcodeName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.txtBarcodeName.Location = new System.Drawing.Point(1450, 32);
            this.txtBarcodeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcodeName.Name = "txtBarcodeName";
            // 
            // 
            // 
            this.txtBarcodeName.RootElement.AccessibleDescription = null;
            this.txtBarcodeName.RootElement.AccessibleName = null;
            this.txtBarcodeName.RootElement.ControlBounds = new System.Drawing.Rectangle(1450, 32, 125, 25);
            this.txtBarcodeName.Size = new System.Drawing.Size(247, 34);
            this.txtBarcodeName.TabIndex = 20;
            this.txtBarcodeName.TextChanged += new System.EventHandler(this.txtBarcodeName_TextChanged);
            this.txtBarcodeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // picMalig
            // 
            this.picMalig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMalig.Location = new System.Drawing.Point(139, 21);
            this.picMalig.Margin = new System.Windows.Forms.Padding(4);
            this.picMalig.Name = "picMalig";
            this.picMalig.Size = new System.Drawing.Size(61, 52);
            this.picMalig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMalig.TabIndex = 44;
            this.picMalig.TabStop = false;
            this.picMalig.Visible = false;
            // 
            // lblRev
            // 
            this.lblRev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRev.Location = new System.Drawing.Point(300, 27);
            this.lblRev.Margin = new System.Windows.Forms.Padding(4);
            this.lblRev.Name = "lblRev";
            // 
            // 
            // 
            this.lblRev.RootElement.AccessibleDescription = null;
            this.lblRev.RootElement.AccessibleName = null;
            this.lblRev.RootElement.ControlBounds = new System.Drawing.Rectangle(300, 27, 125, 22);
            this.lblRev.Size = new System.Drawing.Size(300, 37);
            this.lblRev.TabIndex = 43;
            this.lblRev.Text = "תשובה מעודכנת";
            this.lblRev.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "V12.23";
            // 
            // lblPathoName
            // 
            this.lblPathoName.AutoSize = false;
            this.lblPathoName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblPathoName.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathoName.Location = new System.Drawing.Point(650, 4);
            this.lblPathoName.Margin = new System.Windows.Forms.Padding(1);
            this.lblPathoName.Name = "lblPathoName";
            this.lblPathoName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.lblPathoName.RootElement.AccessibleDescription = null;
            this.lblPathoName.RootElement.AccessibleName = null;
            this.lblPathoName.RootElement.ControlBounds = new System.Drawing.Rectangle(650, 4, 125, 22);
            this.lblPathoName.Size = new System.Drawing.Size(787, 80);
            this.lblPathoName.TabIndex = 40;
            this.lblPathoName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(1700, 32);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel3.Name = "radLabel3";
            // 
            // 
            // 
            this.radLabel3.RootElement.AccessibleDescription = null;
            this.radLabel3.RootElement.AccessibleName = null;
            this.radLabel3.RootElement.ControlBounds = new System.Drawing.Rectangle(1700, 32, 125, 22);
            this.radLabel3.Size = new System.Drawing.Size(400, 34);
            this.radLabel3.TabIndex = 33;
            this.radLabel3.Text = "מספר דרישה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // picQC
            // 
            this.picQC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picQC.Location = new System.Drawing.Point(211, 23);
            this.picQC.Margin = new System.Windows.Forms.Padding(4);
            this.picQC.Name = "picQC";
            this.picQC.Size = new System.Drawing.Size(68, 50);
            this.picQC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQC.TabIndex = 45;
            this.picQC.TabStop = false;
            this.picQC.Visible = false;
            // 
            // gbConsulation
            // 
            this.gbConsulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbConsulation.Controls.Add(this.label1);
            this.gbConsulation.Controls.Add(this.btnConsultSave);
            this.gbConsulation.Controls.Add(this.txt_consult_desc);
            this.gbConsulation.Controls.Add(this.chk_isConsult);
            this.gbConsulation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulation.Location = new System.Drawing.Point(19, 645);
            this.gbConsulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsulation.Name = "gbConsulation";
            this.gbConsulation.Padding = new System.Windows.Forms.Padding(0);
            this.gbConsulation.Size = new System.Drawing.Size(367, 186);
            this.gbConsulation.TabIndex = 40;
            this.gbConsulation.TabStop = false;
            this.gbConsulation.Text = "תקשורת עם רופא";
            this.gbConsulation.Enter += new System.EventHandler(this.gbConsulation_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(257, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "הערות";
            // 
            // btnConsultSave
            // 
            this.btnConsultSave.Location = new System.Drawing.Point(8, 144);
            this.btnConsultSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultSave.Name = "btnConsultSave";
            this.btnConsultSave.Size = new System.Drawing.Size(72, 30);
            this.btnConsultSave.TabIndex = 13;
            this.btnConsultSave.Text = "שמור";
            this.btnConsultSave.UseVisualStyleBackColor = true;
            this.btnConsultSave.Click += new System.EventHandler(this.btnConsultSave_Click_1);
            // 
            // txt_consult_desc
            // 
            this.txt_consult_desc.Location = new System.Drawing.Point(27, 62);
            this.txt_consult_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_consult_desc.Multiline = true;
            this.txt_consult_desc.Name = "txt_consult_desc";
            this.txt_consult_desc.Size = new System.Drawing.Size(222, 76);
            this.txt_consult_desc.TabIndex = 1;
            this.txt_consult_desc.TextChanged += new System.EventHandler(this.txt_consult_desc_TextChanged);
            // 
            // chk_isConsult
            // 
            this.chk_isConsult.AutoSize = true;
            this.chk_isConsult.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.chk_isConsult.Location = new System.Drawing.Point(66, 31);
            this.chk_isConsult.Margin = new System.Windows.Forms.Padding(4);
            this.chk_isConsult.Name = "chk_isConsult";
            this.chk_isConsult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_isConsult.Size = new System.Drawing.Size(183, 23);
            this.chk_isConsult.TabIndex = 1;
            this.chk_isConsult.Text = " בוצעה שיחה עם הרופא\r\n";
            this.chk_isConsult.UseVisualStyleBackColor = true;
            this.chk_isConsult.CheckedChanged += new System.EventHandler(this.chk_isConsult_CheckedChanged_2);
            // 
            // gbDates
            // 
            this.gbDates.Controls.Add(this.txtKaldanit);
            this.gbDates.Controls.Add(this.dtCompl);
            this.gbDates.Controls.Add(this.label12);
            this.gbDates.Controls.Add(this.label11);
            this.gbDates.Controls.Add(this.label10);
            this.gbDates.Controls.Add(this.label9);
            this.gbDates.Controls.Add(this.label4);
            this.gbDates.Controls.Add(this.label3);
            this.gbDates.Controls.Add(this.dtHafnaya);
            this.gbDates.Controls.Add(this.dtAuthOn);
            this.gbDates.Controls.Add(this.dtAgaa);
            this.gbDates.Controls.Add(this.dtKabala);
            this.gbDates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDates.Location = new System.Drawing.Point(19, 191);
            this.gbDates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDates.Name = "gbDates";
            this.gbDates.Padding = new System.Windows.Forms.Padding(0);
            this.gbDates.Size = new System.Drawing.Size(367, 229);
            this.gbDates.TabIndex = 45;
            this.gbDates.TabStop = false;
            this.gbDates.Enter += new System.EventHandler(this.gbDates_Enter);
            // 
            // txtKaldanit
            // 
            this.txtKaldanit.AutoSize = false;
            this.txtKaldanit.BackColor = System.Drawing.SystemColors.Control;
            this.txtKaldanit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtKaldanit.Location = new System.Drawing.Point(0, 193);
            this.txtKaldanit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKaldanit.Name = "txtKaldanit";
            this.txtKaldanit.ReadOnly = true;
            // 
            // 
            // 
            this.txtKaldanit.RootElement.AccessibleDescription = null;
            this.txtKaldanit.RootElement.AccessibleName = null;
            this.txtKaldanit.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 193, 125, 25);
            this.txtKaldanit.RootElement.Enabled = true;
            this.txtKaldanit.Size = new System.Drawing.Size(205, 27);
            this.txtKaldanit.TabIndex = 70;
            // 
            // dtCompl
            // 
            this.dtCompl.AutoSize = false;
            this.dtCompl.BackColor = System.Drawing.SystemColors.Control;
            this.dtCompl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtCompl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCompl.Location = new System.Drawing.Point(0, 126);
            this.dtCompl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtCompl.Name = "dtCompl";
            this.dtCompl.ReadOnly = true;
            this.dtCompl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dtCompl.RootElement.AccessibleDescription = null;
            this.dtCompl.RootElement.AccessibleName = null;
            this.dtCompl.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 126, 205, 25);
            this.dtCompl.RootElement.Enabled = true;
            this.dtCompl.Size = new System.Drawing.Size(205, 27);
            this.dtCompl.TabIndex = 69;
            this.dtCompl.TabStop = false;
            this.dtCompl.Value = new System.DateTime(((long)(0)));
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 23);
            this.label12.TabIndex = 71;
            this.label12.Text = "ת. הפניה:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 23);
            this.label11.TabIndex = 71;
            this.label11.Text = "ת. הגעה:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(240, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 71;
            this.label10.Text = "ת. קבלה:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(227, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 23);
            this.label9.TabIndex = 71;
            this.label9.Text = "ת. הדפסה:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(237, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "ת. אישור:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(229, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "הוקלד ע\"י:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtHafnaya
            // 
            this.dtHafnaya.AutoSize = false;
            this.dtHafnaya.BackColor = System.Drawing.SystemColors.Control;
            this.dtHafnaya.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtHafnaya.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHafnaya.Location = new System.Drawing.Point(0, 27);
            this.dtHafnaya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtHafnaya.Name = "dtHafnaya";
            this.dtHafnaya.ReadOnly = true;
            this.dtHafnaya.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dtHafnaya.RootElement.AccessibleDescription = null;
            this.dtHafnaya.RootElement.AccessibleName = null;
            this.dtHafnaya.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 27, 205, 25);
            this.dtHafnaya.RootElement.Enabled = true;
            this.dtHafnaya.Size = new System.Drawing.Size(205, 27);
            this.dtHafnaya.TabIndex = 68;
            this.dtHafnaya.TabStop = false;
            this.dtHafnaya.Value = new System.DateTime(((long)(0)));
            // 
            // dtAuthOn
            // 
            this.dtAuthOn.AutoSize = false;
            this.dtAuthOn.BackColor = System.Drawing.SystemColors.Control;
            this.dtAuthOn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtAuthOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAuthOn.Location = new System.Drawing.Point(0, 159);
            this.dtAuthOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtAuthOn.Name = "dtAuthOn";
            this.dtAuthOn.ReadOnly = true;
            this.dtAuthOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dtAuthOn.RootElement.AccessibleDescription = null;
            this.dtAuthOn.RootElement.AccessibleName = null;
            this.dtAuthOn.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 159, 205, 25);
            this.dtAuthOn.RootElement.Enabled = true;
            this.dtAuthOn.Size = new System.Drawing.Size(205, 27);
            this.dtAuthOn.TabIndex = 67;
            this.dtAuthOn.TabStop = false;
            this.dtAuthOn.Value = new System.DateTime(((long)(0)));
            // 
            // dtAgaa
            // 
            this.dtAgaa.AutoSize = false;
            this.dtAgaa.BackColor = System.Drawing.SystemColors.Control;
            this.dtAgaa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtAgaa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAgaa.Location = new System.Drawing.Point(0, 62);
            this.dtAgaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtAgaa.Name = "dtAgaa";
            this.dtAgaa.ReadOnly = true;
            this.dtAgaa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dtAgaa.RootElement.AccessibleDescription = null;
            this.dtAgaa.RootElement.AccessibleName = null;
            this.dtAgaa.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 62, 205, 25);
            this.dtAgaa.RootElement.Enabled = true;
            this.dtAgaa.Size = new System.Drawing.Size(205, 27);
            this.dtAgaa.TabIndex = 66;
            this.dtAgaa.TabStop = false;
            this.dtAgaa.Value = new System.DateTime(((long)(0)));
            // 
            // dtKabala
            // 
            this.dtKabala.AutoSize = false;
            this.dtKabala.BackColor = System.Drawing.SystemColors.Control;
            this.dtKabala.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtKabala.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKabala.Location = new System.Drawing.Point(0, 94);
            this.dtKabala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtKabala.Name = "dtKabala";
            this.dtKabala.ReadOnly = true;
            this.dtKabala.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dtKabala.RootElement.AccessibleDescription = null;
            this.dtKabala.RootElement.AccessibleName = null;
            this.dtKabala.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 94, 205, 25);
            this.dtKabala.RootElement.Enabled = true;
            this.dtKabala.Size = new System.Drawing.Size(205, 27);
            this.dtKabala.TabIndex = 65;
            this.dtKabala.TabStop = false;
            this.dtKabala.Value = new System.DateTime(((long)(0)));
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.label7);
            this.gbOrder.Controls.Add(this.label6);
            this.gbOrder.Controls.Add(this.label5);
            this.gbOrder.Controls.Add(this.label8);
            this.gbOrder.Controls.Add(this.txtPriority);
            this.gbOrder.Controls.Add(this.txtClinic);
            this.gbOrder.Controls.Add(this.CmbPatholog);
            this.gbOrder.Controls.Add(this.label13);
            this.gbOrder.Controls.Add(this.txtCust1st);
            this.gbOrder.Controls.Add(this.txtImp);
            this.gbOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.Location = new System.Drawing.Point(19, 439);
            this.gbOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Padding = new System.Windows.Forms.Padding(0);
            this.gbOrder.Size = new System.Drawing.Size(367, 193);
            this.gbOrder.TabIndex = 37;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "פרטי הזמנה";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 71;
            this.label7.Text = "עדיפות";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "פתולוג מיועד";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 71;
            this.label5.Text = "גורם שולח";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 71;
            this.label8.Text = "גורם משלם";
            // 
            // txtPriority
            // 
            this.txtPriority.AutoSize = false;
            this.txtPriority.BackColor = System.Drawing.SystemColors.Control;
            this.txtPriority.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPriority.Location = new System.Drawing.Point(0, 158);
            this.txtPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriority.ReadOnly = true;
            // 
            // 
            // 
            this.txtPriority.RootElement.AccessibleDescription = null;
            this.txtPriority.RootElement.AccessibleName = null;
            this.txtPriority.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 158, 125, 25);
            this.txtPriority.RootElement.Enabled = true;
            this.txtPriority.Size = new System.Drawing.Size(205, 27);
            this.txtPriority.TabIndex = 18;
            // 
            // txtClinic
            // 
            this.txtClinic.AutoSize = false;
            this.txtClinic.BackColor = System.Drawing.SystemColors.Control;
            this.txtClinic.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtClinic.Location = new System.Drawing.Point(0, 94);
            this.txtClinic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClinic.Name = "txtClinic";
            this.txtClinic.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClinic.ReadOnly = true;
            // 
            // 
            // 
            this.txtClinic.RootElement.AccessibleDescription = null;
            this.txtClinic.RootElement.AccessibleName = null;
            this.txtClinic.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 94, 125, 25);
            this.txtClinic.RootElement.Enabled = true;
            this.txtClinic.Size = new System.Drawing.Size(205, 27);
            this.txtClinic.TabIndex = 17;
            // 
            // CmbPatholog
            // 
            this.CmbPatholog.AutoSize = false;
            this.CmbPatholog.BackColor = System.Drawing.SystemColors.Control;
            this.CmbPatholog.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce;
            this.CmbPatholog.DropDownAnimationFrames = 3;
            this.CmbPatholog.DropDownHeight = 250;
            this.CmbPatholog.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CmbPatholog.Location = new System.Drawing.Point(0, 128);
            this.CmbPatholog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbPatholog.Name = "CmbPatholog";
            this.CmbPatholog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            this.CmbPatholog.RootElement.AccessibleDescription = null;
            this.CmbPatholog.RootElement.AccessibleName = null;
            this.CmbPatholog.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 128, 156, 25);
            this.CmbPatholog.RootElement.Enabled = true;
            this.CmbPatholog.Size = new System.Drawing.Size(205, 27);
            this.CmbPatholog.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 23);
            this.label13.TabIndex = 71;
            this.label13.Text = "רופא מבצע";
            // 
            // txtCust1st
            // 
            this.txtCust1st.AutoSize = false;
            this.txtCust1st.BackColor = System.Drawing.SystemColors.Control;
            this.txtCust1st.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCust1st.Location = new System.Drawing.Point(0, 62);
            this.txtCust1st.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCust1st.Name = "txtCust1st";
            this.txtCust1st.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCust1st.ReadOnly = true;
            // 
            // 
            // 
            this.txtCust1st.RootElement.AccessibleDescription = null;
            this.txtCust1st.RootElement.AccessibleName = null;
            this.txtCust1st.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 62, 125, 25);
            this.txtCust1st.RootElement.Enabled = true;
            this.txtCust1st.Size = new System.Drawing.Size(205, 27);
            this.txtCust1st.TabIndex = 14;
            // 
            // txtImp
            // 
            this.txtImp.AutoSize = false;
            this.txtImp.BackColor = System.Drawing.SystemColors.Control;
            this.txtImp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtImp.Location = new System.Drawing.Point(0, 30);
            this.txtImp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImp.Name = "txtImp";
            this.txtImp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImp.ReadOnly = true;
            // 
            // 
            // 
            this.txtImp.RootElement.AccessibleDescription = null;
            this.txtImp.RootElement.AccessibleName = null;
            this.txtImp.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 30, 125, 25);
            this.txtImp.RootElement.Enabled = true;
            this.txtImp.Size = new System.Drawing.Size(205, 27);
            this.txtImp.TabIndex = 15;
            // 
            // gbClient
            // 
            this.gbClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbClient.Controls.Add(this.txtDB);
            this.gbClient.Controls.Add(this.BTNcLIENT);
            this.gbClient.Controls.Add(this.label17);
            this.gbClient.Controls.Add(this.label16);
            this.gbClient.Controls.Add(this.label15);
            this.gbClient.Controls.Add(this.label14);
            this.gbClient.Controls.Add(this.txtGender);
            this.gbClient.Controls.Add(this.txtIdentity);
            this.gbClient.Controls.Add(this.txtFN);
            this.gbClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClient.Location = new System.Drawing.Point(19, 7);
            this.gbClient.Margin = new System.Windows.Forms.Padding(4);
            this.gbClient.Name = "gbClient";
            this.gbClient.Padding = new System.Windows.Forms.Padding(0);
            this.gbClient.Size = new System.Drawing.Size(367, 178);
            this.gbClient.TabIndex = 35;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "פרטי נבדק";
            //this.gbClient.Enter += new System.EventHandler(this.gbClient_Enter);
            // 
            // txtDB
            // 
            this.txtDB.AutoSize = false;
            this.txtDB.BackColor = System.Drawing.SystemColors.Control;
            this.txtDB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDB.Location = new System.Drawing.Point(0, 146);
            this.txtDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDB.Name = "txtDB";
            this.txtDB.ReadOnly = true;
            // 
            // 
            // 
            this.txtDB.RootElement.AccessibleDescription = null;
            this.txtDB.RootElement.AccessibleName = null;
            this.txtDB.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 146, 125, 25);
            this.txtDB.RootElement.Enabled = true;
            this.txtDB.Size = new System.Drawing.Size(205, 25);
            this.txtDB.TabIndex = 7;
            // 
            // BTNcLIENT
            // 
            this.BTNcLIENT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNcLIENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNcLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNcLIENT.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNcLIENT.Location = new System.Drawing.Point(0, 26);
            this.BTNcLIENT.Margin = new System.Windows.Forms.Padding(4);
            this.BTNcLIENT.Name = "BTNcLIENT";
            // 
            // 
            // 
            this.BTNcLIENT.RootElement.AccessibleDescription = null;
            this.BTNcLIENT.RootElement.AccessibleName = null;
            this.BTNcLIENT.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 137, 30);
            this.BTNcLIENT.Size = new System.Drawing.Size(107, 28);
            this.BTNcLIENT.TabIndex = 40;
            this.BTNcLIENT.Text = "עדכון נבדק";
            this.BTNcLIENT.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 63);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 71;
            this.label17.Text = "שם מלא:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(243, 146);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 23);
            this.label16.TabIndex = 71;
            this.label16.Text = "ת. לידה:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 119);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 23);
            this.label15.TabIndex = 71;
            this.label15.Text = "מין:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(226, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 23);
            this.label14.TabIndex = 71;
            this.label14.Text = "ת.ז/ דרכון:";
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = false;
            this.txtGender.BackColor = System.Drawing.SystemColors.Control;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGender.Location = new System.Drawing.Point(0, 119);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            // 
            // 
            // 
            this.txtGender.RootElement.AccessibleDescription = null;
            this.txtGender.RootElement.AccessibleName = null;
            this.txtGender.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 119, 125, 25);
            this.txtGender.RootElement.Enabled = true;
            this.txtGender.Size = new System.Drawing.Size(205, 25);
            this.txtGender.TabIndex = 8;
            // 
            // txtIdentity
            // 
            this.txtIdentity.AutoSize = false;
            this.txtIdentity.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdentity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtIdentity.Location = new System.Drawing.Point(0, 91);
            this.txtIdentity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.ReadOnly = true;
            // 
            // 
            // 
            this.txtIdentity.RootElement.AccessibleDescription = null;
            this.txtIdentity.RootElement.AccessibleName = null;
            this.txtIdentity.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 91, 125, 25);
            this.txtIdentity.Size = new System.Drawing.Size(205, 25);
            this.txtIdentity.TabIndex = 9;
            // 
            // txtFN
            // 
            this.txtFN.AutoSize = false;
            this.txtFN.BackColor = System.Drawing.SystemColors.Control;
            this.txtFN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFN.Location = new System.Drawing.Point(0, 63);
            this.txtFN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
            this.txtFN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.txtFN.RootElement.AccessibleDescription = null;
            this.txtFN.RootElement.AccessibleName = null;
            this.txtFN.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 63, 125, 25);
            this.txtFN.RootElement.Enabled = true;
            this.txtFN.Size = new System.Drawing.Size(205, 25);
            this.txtFN.TabIndex = 6;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.AutoScrollToCurrentControl = false;
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlButtons.Controls.Add(this.extraMaterialCtrl1);
            this.pnlButtons.Controls.Add(this.BtnExtReq);
            this.pnlButtons.Controls.Add(this.BtnSetDef_pap);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.radButton1);
            this.pnlButtons.Controls.Add(this.btnAuth);
            this.pnlButtons.Controls.Add(this.btnLetter);
            this.pnlButtons.Controls.Add(this.BtnExit);
            this.pnlButtons.Controls.Add(this.btnAttach);
            this.pnlButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pnlButtons.Location = new System.Drawing.Point(1799, 118);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            // 
            // 
            // 
            this.pnlButtons.RootElement.AccessibleDescription = null;
            this.pnlButtons.RootElement.AccessibleName = null;
            this.pnlButtons.RootElement.ControlBounds = new System.Drawing.Rectangle(1799, 118, 250, 125);
            this.pnlButtons.Size = new System.Drawing.Size(156, 890);
            this.pnlButtons.TabIndex = 40;
            // 
            // extraMaterialCtrl1
            // 
            this.extraMaterialCtrl1.ExMaterialButton = null;
            this.extraMaterialCtrl1.Location = new System.Drawing.Point(12, 785);
            this.extraMaterialCtrl1.Margin = new System.Windows.Forms.Padding(5);
            this.extraMaterialCtrl1.Name = "extraMaterialCtrl1";
            this.extraMaterialCtrl1.Size = new System.Drawing.Size(136, 41);
            this.extraMaterialCtrl1.TabIndex = 47;
            this.extraMaterialCtrl1.Load += new System.EventHandler(this.extraMaterialCtrl1_Load);
            // 
            // BtnExtReq
            // 
            this.BtnExtReq.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExtReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExtReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnExtReq.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnExtReq.Location = new System.Drawing.Point(12, 495);
            this.BtnExtReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExtReq.Name = "BtnExtReq";
            // 
            // 
            // 
            this.BtnExtReq.RootElement.AccessibleDescription = null;
            this.BtnExtReq.RootElement.AccessibleName = null;
            this.BtnExtReq.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 495, 137, 30);
            this.BtnExtReq.Size = new System.Drawing.Size(133, 46);
            this.BtnExtReq.TabIndex = 41;
            this.BtnExtReq.Text = "בקשות נוספות";
            this.BtnExtReq.Click += new System.EventHandler(this.ExtraReq_Click);
            // 
            // BtnSetDef_pap
            // 
            this.BtnSetDef_pap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSetDef_pap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSetDef_pap.Location = new System.Drawing.Point(12, 20);
            this.BtnSetDef_pap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSetDef_pap.Name = "BtnSetDef_pap";
            // 
            // 
            // 
            this.BtnSetDef_pap.RootElement.AccessibleDescription = null;
            this.BtnSetDef_pap.RootElement.AccessibleName = null;
            this.BtnSetDef_pap.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 20, 137, 30);
            this.BtnSetDef_pap.Size = new System.Drawing.Size(133, 46);
            this.BtnSetDef_pap.TabIndex = 45;
            this.BtnSetDef_pap.Text = "הכל תקין";
            this.BtnSetDef_pap.Visible = false;
            this.BtnSetDef_pap.Click += new System.EventHandler(this.BtnSetDef_pap_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(12, 178);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.AccessibleDescription = null;
            this.btnSave.RootElement.AccessibleName = null;
            this.btnSave.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 178, 137, 30);
            this.btnSave.RootElement.Enabled = true;
            this.btnSave.Size = new System.Drawing.Size(133, 46);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "שמירה";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.radButton1.Image = ((System.Drawing.Image)(resources.GetObject("radButton1.Image")));
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(12, 254);
            this.radButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.AccessibleDescription = null;
            this.radButton1.RootElement.AccessibleName = null;
            this.radButton1.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 254, 137, 30);
            this.radButton1.Size = new System.Drawing.Size(133, 46);
            this.radButton1.TabIndex = 39;
            this.radButton1.Click += new System.EventHandler(this.PrintLetter_Click);
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAuth.Location = new System.Drawing.Point(12, 98);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuth.Name = "btnAuth";
            // 
            // 
            // 
            this.btnAuth.RootElement.AccessibleDescription = null;
            this.btnAuth.RootElement.AccessibleName = null;
            this.btnAuth.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 98, 137, 30);
            this.btnAuth.RootElement.Enabled = true;
            this.btnAuth.Size = new System.Drawing.Size(133, 46);
            this.btnAuth.TabIndex = 31;
            this.btnAuth.Text = "אישור";
            this.btnAuth.Click += new System.EventHandler(this.radButtonAuthorise_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLetter.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLetter.Location = new System.Drawing.Point(12, 720);
            this.btnLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLetter.Name = "btnLetter";
            // 
            // 
            // 
            this.btnLetter.RootElement.AccessibleDescription = null;
            this.btnLetter.RootElement.AccessibleName = null;
            this.btnLetter.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 720, 137, 30);
            this.btnLetter.Size = new System.Drawing.Size(133, 46);
            this.btnLetter.TabIndex = 38;
            this.btnLetter.Text = "מכתב תשובה";
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnExit.Location = new System.Drawing.Point(12, 569);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            // 
            // 
            // 
            this.BtnExit.RootElement.AccessibleDescription = null;
            this.BtnExit.RootElement.AccessibleName = null;
            this.BtnExit.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 569, 137, 30);
            this.BtnExit.Size = new System.Drawing.Size(133, 46);
            this.BtnExit.TabIndex = 32;
            this.BtnExit.Text = "יציאה";
            this.BtnExit.ThemeName = "ControlDefault";
            this.BtnExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAttach.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttach.Location = new System.Drawing.Point(12, 647);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAttach.Name = "btnAttach";
            // 
            // 
            // 
            this.btnAttach.RootElement.AccessibleDescription = null;
            this.btnAttach.RootElement.AccessibleName = null;
            this.btnAttach.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 647, 137, 30);
            this.btnAttach.Size = new System.Drawing.Size(133, 46);
            this.btnAttach.TabIndex = 37;
            this.btnAttach.Text = "מסמכים מצורפים";
            this.btnAttach.TextWrap = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // requestRemarkControl1
            // 
            this.requestRemarkControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.requestRemarkControl1.BackColor = System.Drawing.Color.Transparent;
            this.requestRemarkControl1.ForeColor = System.Drawing.Color.Transparent;
            this.requestRemarkControl1.Location = new System.Drawing.Point(1811, 502);
            this.requestRemarkControl1.Margin = new System.Windows.Forms.Padding(5);
            this.requestRemarkControl1.Name = "requestRemarkControl1";
            this.requestRemarkControl1.Size = new System.Drawing.Size(135, 39);
            this.requestRemarkControl1.TabIndex = 42;
            // 
            // openPacsBrowser1
            // 
            this.openPacsBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openPacsBrowser1.AutoSize = true;
            this.openPacsBrowser1.BackColor = System.Drawing.Color.Transparent;
            this.openPacsBrowser1.closeUrl = null;
            this.openPacsBrowser1.Location = new System.Drawing.Point(1811, 444);
            this.openPacsBrowser1.Margin = new System.Windows.Forms.Padding(5);
            this.openPacsBrowser1.Name = "openPacsBrowser1";
            this.openPacsBrowser1.Size = new System.Drawing.Size(136, 41);
            this.openPacsBrowser1.TabIndex = 46;
            this.openPacsBrowser1.Load += new System.EventHandler(this.openPacsBrowser1_Load);
            // 
            // sdgSttachmentsCtrl1
            // 
            this.sdgSttachmentsCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sdgSttachmentsCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.sdgSttachmentsCtrl1.dal = null;
            this.sdgSttachmentsCtrl1.Location = new System.Drawing.Point(1811, 559);
            this.sdgSttachmentsCtrl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdgSttachmentsCtrl1.Name = "sdgSttachmentsCtrl1";
            this.sdgSttachmentsCtrl1.NautilusServiceProvider = null;
            this.sdgSttachmentsCtrl1.Sdg = null;
            this.sdgSttachmentsCtrl1.Size = new System.Drawing.Size(135, 38);
            this.sdgSttachmentsCtrl1.TabIndex = 0;
            this.sdgSttachmentsCtrl1.Load += new System.EventHandler(this.sdgSttachmentsCtrl1_Load);
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radButton2.Location = new System.Drawing.Point(0, 0);
            this.radButton2.Name = "radButton2";
            // 
            // 
            // 
            this.radButton2.RootElement.AccessibleDescription = null;
            this.radButton2.RootElement.AccessibleName = null;
            this.radButton2.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 137, 30);
            this.radButton2.TabIndex = 0;
            // 
            // radListControl1
            // 
            this.radListControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radListControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radListControl1.Location = new System.Drawing.Point(0, 0);
            this.radListControl1.Name = "radListControl1";
            // 
            // 
            // 
            this.radListControl1.RootElement.AccessibleDescription = null;
            this.radListControl1.RootElement.AccessibleName = null;
            this.radListControl1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 150, 118);
            this.radListControl1.TabIndex = 0;
            // 
            // DetTab
            // 
            this.DetTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DetTab.Controls.Add(this.tabPage1);
            this.DetTab.Controls.Add(this.tabhistor);
            this.DetTab.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.DetTab.Location = new System.Drawing.Point(7, 118);
            this.DetTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetTab.Name = "DetTab";
            this.DetTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DetTab.RightToLeftLayout = true;
            this.DetTab.SelectedIndex = 0;
            this.DetTab.Size = new System.Drawing.Size(409, 894);
            this.DetTab.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.gbOrder);
            this.tabPage1.Controls.Add(this.gbDates);
            this.tabPage1.Controls.Add(this.gbConsulation);
            this.tabPage1.Controls.Add(this.gbClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(401, 851);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "פרטים";
            // 
            // tabhistor
            // 
            this.tabhistor.AutoScroll = true;
            this.tabhistor.Controls.Add(this.historyCtl1);
            this.tabhistor.Location = new System.Drawing.Point(4, 39);
            this.tabhistor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabhistor.Name = "tabhistor";
            this.tabhistor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabhistor.Size = new System.Drawing.Size(401, 851);
            this.tabhistor.TabIndex = 1;
            this.tabhistor.Text = "הסטוריה";
            this.tabhistor.UseVisualStyleBackColor = true;
            // 
            // historyCtl1
            // 
            this.historyCtl1.AutoScroll = true;
            this.historyCtl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyCtl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.historyCtl1.Location = new System.Drawing.Point(3, 2);
            this.historyCtl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.historyCtl1.Name = "historyCtl1";
            this.historyCtl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historyCtl1.Size = new System.Drawing.Size(395, 847);
            this.historyCtl1.TabIndex = 0;
            this.historyCtl1.Load += new System.EventHandler(this.historyCtl1_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NewResultEntryCls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.requestRemarkControl1);
            this.Controls.Add(this.picQC);
            this.Controls.Add(this.openPacsBrowser1);
            this.Controls.Add(this.sdgSttachmentsCtrl1);
            this.Controls.Add(this.pnlSdgDetails);
            this.Controls.Add(this.DetTab);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.Tab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewResultEntryCls";
            this.Size = new System.Drawing.Size(1959, 1015);
            this.Load += new System.EventHandler(this.NewResultEntryCls_Load);
            this.Tab.ResumeLayout(false);
            this.tab_diag.ResumeLayout(false);
            this.tab_Imp_diag.ResumeLayout(false);
            this.tab_macro.ResumeLayout(false);
            this.tab_micro.ResumeLayout(false);
            this.tab_snomed.ResumeLayout(false);
            this.tabHPV.ResumeLayout(false);
            this.tabFreeTxt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSdgDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcodeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMalig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPathoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQC)).EndInit();
            this.gbConsulation.ResumeLayout(false);
            this.gbConsulation.PerformLayout();
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaldanit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHafnaya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAuthOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAgaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKabala)).EndInit();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPatholog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCust1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImp)).EndInit();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNcLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExtReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSetDef_pap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            this.DetTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabhistor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
  //      private Telerik.WinControls.RadThemeManager radThemeManager1;
        
        private TabControl Tab;
        private TabPage tab_diag;
        private TabPage tab_Imp_diag;
        private ONE1_richTextCtrl.RichSpellCtrl rich_impDiag;
        private TabPage tab_macro;
        private ONE1_richTextCtrl.RichSpellCtrl rich_mac;
        private TabPage tab_micro;
        private ONE1_richTextCtrl.RichSpellCtrl rich_mic;
        private TabPage tab_snomed;
        private Telerik.WinControls.UI.RadPanel pnlSdgDetails;
        private Telerik.WinControls.UI.RadLabel lblPathoName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadTextBox txtBarcodeName;
        private Telerik.WinControls.UI.RadPanel pnlButtons;
        //private VB6Bridge.RequestRemarksBridge requestRemarksBridge1;
        private Telerik.WinControls.UI.RadButton btnLetter;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton BtnExit;
        private Telerik.WinControls.UI.RadButton btnAttach;
        private Telerik.WinControls.UI.RadButton radButton1;
        private SdgAttachments.SdgSttachmentsCtrl sdgSttachmentsCtrl1;
        private ONE1_richTextCtrl.RichSpellCtrl rich_diag;
        private Label label2;
        private Telerik.WinControls.UI.RadButton BtnExtReq;
        private TabPage tab_clinic;
        private TabPage tabAdeq;
        private TabPage tab_Papres;
        private TabPage tab_recom;


        private Controls.SnomedCtrl snomedCtrl1;

        private TabPage tabHPV;
        private HPV_RE.HPV_RE_Manager hpvManager;
        private TabPage tabFreeTxt;
        private ONE1_richTextCtrl.RichSpellCtrl rich_FreeTxt;
        private Telerik.WinControls.UI.RadLabel lblRev;
        private PictureBox picMalig;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadButton BtnSetDef_pap;
        private PictureBox picQC;
        private TabControl DetTab;
        private TabPage tabPage1;
        private TabPage tabhistor;
        private Controls.HistoryCtl historyCtl1;
        private Telerik.WinControls.UI.RadButton btnAuth;
        private RequestRemarkNet.RequestRemarkControl requestRemarkControl1;
        private PacsDigital.OpenPacsBrowser openPacsBrowser1;
        private ExtraMaterialControl.ExtraMaterialCtrl extraMaterialCtrl1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox gbClient;
        private Telerik.WinControls.UI.RadTextBox txtDB;
        private Telerik.WinControls.UI.RadButton BTNcLIENT;
        private Telerik.WinControls.UI.RadTextBox txtGender;
        private Telerik.WinControls.UI.RadTextBox txtIdentity;
        private Telerik.WinControls.UI.RadTextBox txtFN;
        private GroupBox gbDates;
        private GroupBox gbConsulation;
        private Button btnConsultSave;
        private TextBox txt_consult_desc;
        private CheckBox chk_isConsult;
        private Telerik.WinControls.UI.RadTextBox txtKaldanit;
        private Telerik.WinControls.UI.RadDateTimePicker dtCompl;
        private Telerik.WinControls.UI.RadDateTimePicker dtHafnaya;
        private Telerik.WinControls.UI.RadDateTimePicker dtAuthOn;
        private Telerik.WinControls.UI.RadDateTimePicker dtAgaa;
        private Telerik.WinControls.UI.RadDateTimePicker dtKabala;
        private GroupBox gbOrder;
        private Telerik.WinControls.UI.RadTextBox txtPriority;
        private Telerik.WinControls.UI.RadTextBox txtClinic;
        private Telerik.WinControls.UI.RadDropDownList CmbPatholog;
        private Telerik.WinControls.UI.RadTextBox txtCust1st;
        private Telerik.WinControls.UI.RadTextBox txtImp;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label13;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
    }
}
