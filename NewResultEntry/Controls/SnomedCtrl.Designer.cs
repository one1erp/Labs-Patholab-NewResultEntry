namespace NewResultEntry.Controls
{
    partial class SnomedCtrl
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
            this.txtTumorSize = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.grp_snomedT = new System.Windows.Forms.GroupBox();
            this.cmbST = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbST3 = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbST2 = new Telerik.WinControls.UI.RadDropDownList();
            this.grp_snomedM = new System.Windows.Forms.GroupBox();
            this.cmbSM3 = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbSM2 = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbSM = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbSign2 = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbSign1 = new Telerik.WinControls.UI.RadDropDownList();
            this.cbMalig = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.cbCarcinoma = new Telerik.WinControls.UI.RadLabel();
            this.cbPres = new Telerik.WinControls.UI.RadLabel();
            this.NudCarcinoma = new Telerik.WinControls.UI.RadSpinEditor();
            this.nudPres = new Telerik.WinControls.UI.RadSpinEditor();
            this.lblTb = new Telerik.WinControls.UI.RadLabel();
            this.cmbTubh = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.txtTumorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.grp_snomedT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbST3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbST2)).BeginInit();
            this.grp_snomedM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSign2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSign1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMalig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarcinoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCarcinoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTubh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTumorSize
            // 
            this.txtTumorSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTumorSize.Location = new System.Drawing.Point(230, 12);
            this.txtTumorSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtTumorSize.Name = "txtTumorSize";
            this.txtTumorSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTumorSize.Size = new System.Drawing.Size(126, 37);
            this.txtTumorSize.TabIndex = 23;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.radLabel6.Location = new System.Drawing.Point(15, 12);
            this.radLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radLabel6.Size = new System.Drawing.Size(248, 34);
            this.radLabel6.TabIndex = 22;
            this.radLabel6.Text = "Tumor Dimension mm";
            // 
            // grp_snomedT
            // 
            this.grp_snomedT.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grp_snomedT.Controls.Add(this.cmbST);
            this.grp_snomedT.Controls.Add(this.cmbST3);
            this.grp_snomedT.Controls.Add(this.cmbST2);
            this.grp_snomedT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grp_snomedT.Location = new System.Drawing.Point(15, 140);
            this.grp_snomedT.Margin = new System.Windows.Forms.Padding(4);
            this.grp_snomedT.Name = "grp_snomedT";
            this.grp_snomedT.Padding = new System.Windows.Forms.Padding(4);
            this.grp_snomedT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grp_snomedT.Size = new System.Drawing.Size(809, 153);
            this.grp_snomedT.TabIndex = 17;
            this.grp_snomedT.TabStop = false;
            this.grp_snomedT.Text = "SNOMED T";
            // 
            // cmbST
            // 
            this.cmbST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbST.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbST.Location = new System.Drawing.Point(167, 25);
            this.cmbST.Margin = new System.Windows.Forms.Padding(4);
            this.cmbST.Name = "cmbST";
            this.cmbST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbST.Size = new System.Drawing.Size(615, 37);
            this.cmbST.TabIndex = 0;
            // 
            // cmbST3
            // 
            this.cmbST3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbST3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbST3.Location = new System.Drawing.Point(167, 105);
            this.cmbST3.Margin = new System.Windows.Forms.Padding(4);
            this.cmbST3.Name = "cmbST3";
            this.cmbST3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbST3.Size = new System.Drawing.Size(615, 37);
            this.cmbST3.TabIndex = 2;
            // 
            // cmbST2
            // 
            this.cmbST2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbST2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbST2.Location = new System.Drawing.Point(167, 65);
            this.cmbST2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbST2.Name = "cmbST2";
            this.cmbST2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbST2.Size = new System.Drawing.Size(615, 37);
            this.cmbST2.TabIndex = 1;
            // 
            // grp_snomedM
            // 
            this.grp_snomedM.Controls.Add(this.cmbSM3);
            this.grp_snomedM.Controls.Add(this.cmbSM2);
            this.grp_snomedM.Controls.Add(this.cmbSM);
            this.grp_snomedM.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grp_snomedM.Location = new System.Drawing.Point(15, 301);
            this.grp_snomedM.Margin = new System.Windows.Forms.Padding(4);
            this.grp_snomedM.Name = "grp_snomedM";
            this.grp_snomedM.Padding = new System.Windows.Forms.Padding(4);
            this.grp_snomedM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grp_snomedM.Size = new System.Drawing.Size(809, 152);
            this.grp_snomedM.TabIndex = 18;
            this.grp_snomedM.TabStop = false;
            this.grp_snomedM.Text = "SNOMED M";
            // 
            // cmbSM3
            // 
            this.cmbSM3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSM3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSM3.Location = new System.Drawing.Point(167, 107);
            this.cmbSM3.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSM3.Name = "cmbSM3";
            this.cmbSM3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSM3.Size = new System.Drawing.Size(615, 37);
            this.cmbSM3.TabIndex = 2;
            this.cmbSM3.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbSM_SelectedIndexChanged_1);
            // 
            // cmbSM2
            // 
            this.cmbSM2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSM2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSM2.Location = new System.Drawing.Point(167, 67);
            this.cmbSM2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSM2.Name = "cmbSM2";
            this.cmbSM2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSM2.Size = new System.Drawing.Size(615, 37);
            this.cmbSM2.TabIndex = 1;
            this.cmbSM2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbSM_SelectedIndexChanged_1);
            // 
            // cmbSM
            // 
            this.cmbSM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSM.Location = new System.Drawing.Point(167, 27);
            this.cmbSM.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSM.Name = "cmbSM";
            this.cmbSM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSM.Size = new System.Drawing.Size(615, 37);
            this.cmbSM.TabIndex = 0;
            this.cmbSM.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbSM_SelectedIndexChanged_1);
            // 
            // cmbSign2
            // 
            this.cmbSign2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSign2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSign2.Location = new System.Drawing.Point(182, 514);
            this.cmbSign2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSign2.Name = "cmbSign2";
            this.cmbSign2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSign2.Size = new System.Drawing.Size(615, 37);
            this.cmbSign2.TabIndex = 20;
            // 
            // cmbSign1
            // 
            this.cmbSign1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSign1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSign1.Location = new System.Drawing.Point(182, 474);
            this.cmbSign1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSign1.Name = "cmbSign1";
            this.cmbSign1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSign1.Size = new System.Drawing.Size(615, 37);
            this.cmbSign1.TabIndex = 19;
            // 
            // cbMalig
            // 
            this.cbMalig.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.cbMalig.Location = new System.Drawing.Point(15, 95);
            this.cbMalig.Margin = new System.Windows.Forms.Padding(4);
            this.cbMalig.Name = "cbMalig";
            this.cbMalig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbMalig.Size = new System.Drawing.Size(385, 43);
            this.cbMalig.TabIndex = 16;
            this.cbMalig.Text = "Should report to physician";
            this.cbMalig.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbMalig_MouseUp);
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.radLabel7.Location = new System.Drawing.Point(15, 470);
            this.radLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radLabel7.Size = new System.Drawing.Size(169, 43);
            this.radLabel7.TabIndex = 14;
            this.radLabel7.Text = "Sign by 1st.";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.radLabel8.Location = new System.Drawing.Point(15, 510);
            this.radLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radLabel8.Size = new System.Drawing.Size(181, 43);
            this.radLabel8.TabIndex = 15;
            this.radLabel8.Text = "Sign by 2nd.";
            // 
            // cbCarcinoma
            // 
            this.cbCarcinoma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cbCarcinoma.Location = new System.Drawing.Point(364, 58);
            this.cbCarcinoma.Margin = new System.Windows.Forms.Padding(4);
            this.cbCarcinoma.Name = "cbCarcinoma";
            this.cbCarcinoma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCarcinoma.Size = new System.Drawing.Size(482, 34);
            this.cbCarcinoma.TabIndex = 25;
            this.cbCarcinoma.Text = "No. of lymph nodes infiltrated by carcinoma";
            // 
            // cbPres
            // 
            this.cbPres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cbPres.Location = new System.Drawing.Point(15, 58);
            this.cbPres.Margin = new System.Windows.Forms.Padding(4);
            this.cbPres.Name = "cbPres";
            this.cbPres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbPres.Size = new System.Drawing.Size(306, 34);
            this.cbPres.TabIndex = 17;
            this.cbPres.Text = "No. of lymph nodes present";
            // 
            // NudCarcinoma
            // 
            this.NudCarcinoma.Location = new System.Drawing.Point(764, 63);
            this.NudCarcinoma.Name = "NudCarcinoma";
            this.NudCarcinoma.Size = new System.Drawing.Size(56, 27);
            this.NudCarcinoma.TabIndex = 26;
            this.NudCarcinoma.TabStop = false;
            // 
            // nudPres
            // 
            this.nudPres.Location = new System.Drawing.Point(275, 62);
            this.nudPres.Name = "nudPres";
            this.nudPres.Size = new System.Drawing.Size(56, 27);
            this.nudPres.TabIndex = 27;
            this.nudPres.TabStop = false;
            // 
            // lblTb
            // 
            this.lblTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTb.Location = new System.Drawing.Point(364, 12);
            this.lblTb.Margin = new System.Windows.Forms.Padding(4);
            this.lblTb.Name = "lblTb";
            this.lblTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTb.Size = new System.Drawing.Size(181, 34);
            this.lblTb.TabIndex = 28;
            this.lblTb.Text = "Tumor Behavior";
            // 
            // cmbTubh
            // 
            this.cmbTubh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTubh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTubh.Location = new System.Drawing.Point(523, 12);
            this.cmbTubh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTubh.Name = "cmbTubh";
            this.cmbTubh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTubh.Size = new System.Drawing.Size(301, 37);
            this.cmbTubh.TabIndex = 29;
            // 
            // SnomedCtrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.NudCarcinoma);
            this.Controls.Add(this.cbCarcinoma);
            this.Controls.Add(this.txtTumorSize);
            this.Controls.Add(this.cmbTubh);
            this.Controls.Add(this.lblTb);
            this.Controls.Add(this.nudPres);
            this.Controls.Add(this.cbPres);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.grp_snomedT);
            this.Controls.Add(this.grp_snomedM);
            this.Controls.Add(this.cmbSign2);
            this.Controls.Add(this.cmbSign1);
            this.Controls.Add(this.cbMalig);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel8);
            this.Name = "SnomedCtrl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(849, 594);
            ((System.ComponentModel.ISupportInitialize)(this.txtTumorSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.grp_snomedT.ResumeLayout(false);
            this.grp_snomedT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbST3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbST2)).EndInit();
            this.grp_snomedM.ResumeLayout(false);
            this.grp_snomedM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSign2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSign1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMalig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarcinoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCarcinoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTubh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtTumorSize;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.GroupBox grp_snomedT;
        private Telerik.WinControls.UI.RadDropDownList cmbST;
        private Telerik.WinControls.UI.RadDropDownList cmbST3;
        private Telerik.WinControls.UI.RadDropDownList cmbST2;
        private System.Windows.Forms.GroupBox grp_snomedM;
        private Telerik.WinControls.UI.RadDropDownList cmbSM3;
        private Telerik.WinControls.UI.RadDropDownList cmbSM2;
        private Telerik.WinControls.UI.RadDropDownList cmbSM;
        private Telerik.WinControls.UI.RadDropDownList cmbSign2;
        private Telerik.WinControls.UI.RadDropDownList cmbSign1;
        private Telerik.WinControls.UI.RadCheckBox cbMalig;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel cbCarcinoma;
        private Telerik.WinControls.UI.RadLabel cbPres;
        private Telerik.WinControls.UI.RadSpinEditor NudCarcinoma;
        private Telerik.WinControls.UI.RadSpinEditor nudPres;
        private Telerik.WinControls.UI.RadLabel lblTb;
        private Telerik.WinControls.UI.RadDropDownList cmbTubh;
    }
}
