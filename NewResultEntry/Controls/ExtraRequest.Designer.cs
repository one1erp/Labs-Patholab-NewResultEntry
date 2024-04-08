using NewResultEntry.Controls.Extra_req_Entities;
using Telerik.WinControls.UI;

namespace NewResultEntry.Controls
{
    partial class ExtraRequest
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
        /// <summary> 
        /// Required designer variable.
        /// </summary>


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.sdgTree = new Telerik.WinControls.UI.RadTreeView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabExtraRequest = new System.Windows.Forms.TabControl();
            this.tabPage_color = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.lblMessage = new Telerik.WinControls.UI.RadLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addColors = new System.Windows.Forms.Button();
            this.cmbDoct = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.gridBlocks = new Telerik.WinControls.UI.RadGridView();
            this.tabPage_advisor = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtConsultRemark = new Telerik.WinControls.UI.RadTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbox_entities = new System.Windows.Forms.ListBox();
            this.btn_adviseRequest = new System.Windows.Forms.Button();
            this.btnAddSynamic = new System.Windows.Forms.Button();
            this.btnRemoveDynamic = new System.Windows.Forms.Button();
            this.lbox_advisers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCont4adv = new System.Windows.Forms.Label();
            this.lblMsgAdv = new Telerik.WinControls.UI.RadLabel();
            this.tabPage_history = new System.Windows.Forms.TabPage();
            this.gridExtraReq = new Telerik.WinControls.UI.RadGridView();
            this.tab_moreActions = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sdgTree)).BeginInit();
            this.TabExtraRequest.SuspendLayout();
            this.tabPage_color.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlocks.MasterTemplate)).BeginInit();
            this.tabPage_advisor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsultRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMsgAdv)).BeginInit();
            this.tabPage_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExtraReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExtraReq.MasterTemplate)).BeginInit();
            this.tab_moreActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // sdgTree
            // 
            this.sdgTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.sdgTree.Location = new System.Drawing.Point(0, 0);
            this.sdgTree.Name = "sdgTree";
            this.sdgTree.Size = new System.Drawing.Size(438, 979);
            this.sdgTree.SpacingBetweenNodes = -1;
            this.sdgTree.TabIndex = 2;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Name = "ColumnHeader";
            // 
            // TabExtraRequest
            // 
            this.TabExtraRequest.Controls.Add(this.tabPage_color);
            this.TabExtraRequest.Controls.Add(this.tabPage_advisor);
            this.TabExtraRequest.Controls.Add(this.tabPage_history);
            this.TabExtraRequest.Controls.Add(this.tab_moreActions);
            this.TabExtraRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabExtraRequest.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.TabExtraRequest.ItemSize = new System.Drawing.Size(100, 35);
            this.TabExtraRequest.Location = new System.Drawing.Point(438, 0);
            this.TabExtraRequest.Name = "TabExtraRequest";
            this.TabExtraRequest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabExtraRequest.RightToLeftLayout = true;
            this.TabExtraRequest.SelectedIndex = 0;
            this.TabExtraRequest.Size = new System.Drawing.Size(1278, 979);
            this.TabExtraRequest.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabExtraRequest.TabIndex = 7;
            this.TabExtraRequest.SelectedIndexChanged += new System.EventHandler(this.TabExtraRequest_SelectedIndexChanged);
            // 
            // tabPage_color
            // 
            this.tabPage_color.Controls.Add(this.panel1);
            this.tabPage_color.Controls.Add(this.gridBlocks);
            this.tabPage_color.Location = new System.Drawing.Point(4, 39);
            this.tabPage_color.Name = "tabPage_color";
            this.tabPage_color.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_color.Size = new System.Drawing.Size(1270, 936);
            this.tabPage_color.TabIndex = 0;
            this.tabPage_color.Text = "    צביעות       ";
            this.tabPage_color.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Controls.Add(this.radTextBoxRemarks);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_addColors);
            this.panel1.Controls.Add(this.cmbDoct);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Location = new System.Drawing.Point(988, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 919);
            this.panel1.TabIndex = 9;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(98, 209);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(96, 42);
            this.radLabel2.TabIndex = 31;
            this.radLabel2.Text = "הערות";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radTextBoxRemarks
            // 
            this.radTextBoxRemarks.AutoSize = false;
            this.radTextBoxRemarks.Location = new System.Drawing.Point(21, 263);
            this.radTextBoxRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTextBoxRemarks.Multiline = true;
            this.radTextBoxRemarks.Name = "radTextBoxRemarks";
            this.radTextBoxRemarks.Size = new System.Drawing.Size(236, 177);
            this.radTextBoxRemarks.TabIndex = 30;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = false;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(22, 687);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(249, 71);
            this.lblMessage.TabIndex = 27;
            this.lblMessage.Text = "The request was saved successfully.";
            this.lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::NewResultEntry.Properties.Resources.Capture;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(98, 843);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 96);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addColors
            // 
            this.btn_addColors.BackgroundImage = global::NewResultEntry.Properties.Resources.v1;
            this.btn_addColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addColors.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addColors.Location = new System.Drawing.Point(46, 494);
            this.btn_addColors.Name = "btn_addColors";
            this.btn_addColors.Size = new System.Drawing.Size(192, 156);
            this.btn_addColors.TabIndex = 23;
            this.btn_addColors.UseVisualStyleBackColor = true;
            this.btn_addColors.Click += new System.EventHandler(this.btnAddSlideColor_Click);
            // 
            // cmbDoct
            // 
            this.cmbDoct.AutoSize = false;
            this.cmbDoct.Location = new System.Drawing.Point(21, 103);
            this.cmbDoct.Name = "cmbDoct";
            this.cmbDoct.Size = new System.Drawing.Size(236, 49);
            this.cmbDoct.TabIndex = 12;
            this.cmbDoct.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbDoct_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(58, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(161, 42);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "הזמנה עבור";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // gridBlocks
            // 
            this.gridBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBlocks.AutoScroll = true;
            this.gridBlocks.AutoSizeRows = true;
            this.gridBlocks.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.gridBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBlocks.Location = new System.Drawing.Point(6, 0);
            // 
            // 
            // 
            this.gridBlocks.MasterTemplate.AllowAddNewRow = false;
            this.gridBlocks.MasterTemplate.AllowColumnReorder = false;
            this.gridBlocks.MasterTemplate.AllowColumnResize = false;
            this.gridBlocks.MasterTemplate.AllowDeleteRow = false;
            this.gridBlocks.MasterTemplate.AllowDragToGroup = false;
            this.gridBlocks.MasterTemplate.AllowEditRow = false;
            this.gridBlocks.MasterTemplate.AutoGenerateColumns = false;
            this.gridBlocks.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "צנצנת";
            gridViewTextBoxColumn1.Name = "SampleCol";
            gridViewTextBoxColumn1.Width = 105;
            gridViewTextBoxColumn2.HeaderText = "בלוק";
            gridViewTextBoxColumn2.Name = "BlockCol";
            gridViewTextBoxColumn2.Width = 105;
            gridViewCommandColumn1.DefaultText = "בחר צביעה";
            gridViewCommandColumn1.HeaderText = "בחר צביעה";
            gridViewCommandColumn1.Name = "cmdopen";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 143;
            gridViewTextBoxColumn3.HeaderText = "צביעות שנבחרו";
            gridViewTextBoxColumn3.Name = "SelectedColorCol";
            gridViewTextBoxColumn3.Width = 499;
            gridViewTextBoxColumn3.WrapText = true;
            gridViewCommandColumn2.HeaderText = "איפוס";
            gridViewCommandColumn2.Image = global::NewResultEntry.Properties.Resources.Cancel;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Tile;
            gridViewCommandColumn2.Name = "cmd_zero";
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 110;
            this.gridBlocks.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewTextBoxColumn3,
            gridViewCommandColumn2});
            this.gridBlocks.MasterTemplate.ShowFilteringRow = false;
            this.gridBlocks.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridBlocks.Name = "gridBlocks";
            this.gridBlocks.ReadOnly = true;
            this.gridBlocks.ShowGroupPanel = false;
            this.gridBlocks.Size = new System.Drawing.Size(978, 919);
            this.gridBlocks.TabIndex = 25;
            this.gridBlocks.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gridBlocks_CommandCellClick);
            this.gridBlocks.Click += new System.EventHandler(this.gridBlocks_Click);
            // 
            // tabPage_advisor
            // 
            this.tabPage_advisor.Controls.Add(this.panel2);
            this.tabPage_advisor.Location = new System.Drawing.Point(4, 39);
            this.tabPage_advisor.Name = "tabPage_advisor";
            this.tabPage_advisor.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_advisor.Size = new System.Drawing.Size(1264, 920);
            this.tabPage_advisor.TabIndex = 1;
            this.tabPage_advisor.Text = "שליחה להתייעצות";
            this.tabPage_advisor.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radLabel3);
            this.panel2.Controls.Add(this.txtConsultRemark);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.lbox_entities);
            this.panel2.Controls.Add(this.btn_adviseRequest);
            this.panel2.Controls.Add(this.btnAddSynamic);
            this.panel2.Controls.Add(this.btnRemoveDynamic);
            this.panel2.Controls.Add(this.lbox_advisers);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblCont4adv);
            this.panel2.Controls.Add(this.lblMsgAdv);
            this.panel2.Location = new System.Drawing.Point(150, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 939);
            this.panel2.TabIndex = 29;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(776, 510);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(96, 42);
            this.radLabel3.TabIndex = 35;
            this.radLabel3.Text = "הערות";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtConsultRemark
            // 
            this.txtConsultRemark.AutoSize = false;
            this.txtConsultRemark.Location = new System.Drawing.Point(286, 510);
            this.txtConsultRemark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsultRemark.Multiline = true;
            this.txtConsultRemark.Name = "txtConsultRemark";
            this.txtConsultRemark.Size = new System.Drawing.Size(483, 109);
            this.txtConsultRemark.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::NewResultEntry.Properties.Resources.Capture;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(556, 691);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 114);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbox_entities
            // 
            this.lbox_entities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_entities.FormattingEnabled = true;
            this.lbox_entities.ItemHeight = 25;
            this.lbox_entities.Location = new System.Drawing.Point(111, 123);
            this.lbox_entities.Name = "lbox_entities";
            this.lbox_entities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbox_entities.Size = new System.Drawing.Size(386, 254);
            this.lbox_entities.TabIndex = 8;
            // 
            // btn_adviseRequest
            // 
            this.btn_adviseRequest.BackgroundImage = global::NewResultEntry.Properties.Resources.v1;
            this.btn_adviseRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adviseRequest.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_adviseRequest.Location = new System.Drawing.Point(360, 691);
            this.btn_adviseRequest.Name = "btn_adviseRequest";
            this.btn_adviseRequest.Size = new System.Drawing.Size(123, 114);
            this.btn_adviseRequest.TabIndex = 25;
            this.btn_adviseRequest.UseVisualStyleBackColor = true;
            this.btn_adviseRequest.Click += new System.EventHandler(this.adviseRequest_Click);
            // 
            // btnAddSynamic
            // 
            this.btnAddSynamic.BackgroundImage = global::NewResultEntry.Properties.Resources.AR11;
            this.btnAddSynamic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSynamic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSynamic.Location = new System.Drawing.Point(18, 184);
            this.btnAddSynamic.Name = "btnAddSynamic";
            this.btnAddSynamic.Size = new System.Drawing.Size(84, 83);
            this.btnAddSynamic.TabIndex = 22;
            this.btnAddSynamic.UseVisualStyleBackColor = true;
            this.btnAddSynamic.Click += new System.EventHandler(this.btnAddSynamic_Click);
            // 
            // btnRemoveDynamic
            // 
            this.btnRemoveDynamic.BackgroundImage = global::NewResultEntry.Properties.Resources.Cancel;
            this.btnRemoveDynamic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveDynamic.Image = global::NewResultEntry.Properties.Resources.Cancel;
            this.btnRemoveDynamic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveDynamic.Location = new System.Drawing.Point(21, 343);
            this.btnRemoveDynamic.Name = "btnRemoveDynamic";
            this.btnRemoveDynamic.Size = new System.Drawing.Size(84, 73);
            this.btnRemoveDynamic.TabIndex = 24;
            this.btnRemoveDynamic.UseVisualStyleBackColor = true;
            this.btnRemoveDynamic.Click += new System.EventHandler(this.btnRemoveDynamic_Click);
            // 
            // lbox_advisers
            // 
            this.lbox_advisers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_advisers.FormattingEnabled = true;
            this.lbox_advisers.ItemHeight = 25;
            this.lbox_advisers.Location = new System.Drawing.Point(561, 123);
            this.lbox_advisers.Name = "lbox_advisers";
            this.lbox_advisers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbox_advisers.Size = new System.Drawing.Size(386, 254);
            this.lbox_advisers.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(786, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "בחירת יועץ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(170, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "בחירת ישויות דינאמיות";
            // 
            // lblCont4adv
            // 
            this.lblCont4adv.AutoSize = true;
            this.lblCont4adv.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCont4adv.Location = new System.Drawing.Point(21, 16);
            this.lblCont4adv.Name = "lblCont4adv";
            this.lblCont4adv.Size = new System.Drawing.Size(33, 38);
            this.lblCont4adv.TabIndex = 20;
            this.lblCont4adv.Text = "0";
            // 
            // lblMsgAdv
            // 
            this.lblMsgAdv.AutoSize = false;
            this.lblMsgAdv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMsgAdv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMsgAdv.Location = new System.Drawing.Point(248, 839);
            this.lblMsgAdv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMsgAdv.Name = "lblMsgAdv";
            this.lblMsgAdv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMsgAdv.Size = new System.Drawing.Size(492, 56);
            this.lblMsgAdv.TabIndex = 28;
            this.lblMsgAdv.Text = "The request was saved successfully.";
            this.lblMsgAdv.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsgAdv.Visible = false;
            // 
            // tabPage_history
            // 
            this.tabPage_history.Controls.Add(this.gridExtraReq);
            this.tabPage_history.Location = new System.Drawing.Point(4, 39);
            this.tabPage_history.Name = "tabPage_history";
            this.tabPage_history.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_history.Size = new System.Drawing.Size(1270, 936);
            this.tabPage_history.TabIndex = 2;
            this.tabPage_history.Text = "הסטוריית בקשות חוזרות";
            this.tabPage_history.UseVisualStyleBackColor = true;
            // 
            // gridExtraReq
            // 
            this.gridExtraReq.AutoScroll = true;
            this.gridExtraReq.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.gridExtraReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridExtraReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridExtraReq.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gridExtraReq.MasterTemplate.AllowAddNewRow = false;
            this.gridExtraReq.MasterTemplate.AllowColumnReorder = false;
            this.gridExtraReq.MasterTemplate.AllowEditRow = false;
            this.gridExtraReq.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCommandColumn3.DefaultText = "צביעה מחדש";
            gridViewCommandColumn3.HeaderText = "צביעה מחדש";
            gridViewCommandColumn3.Name = "cmdColor";
            gridViewCommandColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn3.UseDefaultText = true;
            //gridViewCommandColumn3.Width = ;
            //gridViewCommandColumn3.BestFit();
            this.gridExtraReq.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCommandColumn3});
            this.gridExtraReq.MasterTemplate.ShowFilteringRow = false;
            this.gridExtraReq.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridExtraReq.Name = "gridExtraReq";
            this.gridExtraReq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridExtraReq.ShowGroupPanel = false;
            this.gridExtraReq.Size = new System.Drawing.Size(1264, 930);
            this.gridExtraReq.TabIndex = 1;
            this.gridExtraReq.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridExtraReq_UserDeletingRow);
            this.gridExtraReq.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gridExtraReq_CommandCellClick);
            // 
            // tab_moreActions
            // 
            this.tab_moreActions.Controls.Add(this.button3);
            this.tab_moreActions.Location = new System.Drawing.Point(4, 39);
            this.tab_moreActions.Name = "tab_moreActions";
            this.tab_moreActions.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_moreActions.Size = new System.Drawing.Size(1264, 920);
            this.tab_moreActions.TabIndex = 3;
            this.tab_moreActions.Text = "פעולות נוספות";
            this.tab_moreActions.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::NewResultEntry.Properties.Resources.Capture;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(1200, 887);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 96);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExtraRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 979);
            this.Controls.Add(this.TabExtraRequest);
            this.Controls.Add(this.sdgTree);
            this.Name = "ExtraRequest";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.sdgTree)).EndInit();
            this.TabExtraRequest.ResumeLayout(false);
            this.tabPage_color.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlocks.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlocks)).EndInit();
            this.tabPage_advisor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsultRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMsgAdv)).EndInit();
            this.tabPage_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridExtraReq.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExtraReq)).EndInit();
            this.tab_moreActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView sdgTree;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.TabControl TabExtraRequest;
        private System.Windows.Forms.TabPage tabPage_color;
        private System.Windows.Forms.TabPage tabPage_advisor;
        private System.Windows.Forms.TabPage tabPage_history;
        private Telerik.WinControls.UI.RadGridView gridExtraReq;
        private System.Windows.Forms.ListBox lbox_advisers;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadDropDownList cmbDoct;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCont4adv;
        private System.Windows.Forms.Button btnAddSynamic;
        private System.Windows.Forms.Button btnRemoveDynamic;
        private System.Windows.Forms.Button btn_addColors;
        private System.Windows.Forms.Button btn_adviseRequest;
        private Telerik.WinControls.UI.RadGridView gridBlocks;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadLabel lblMessage;
        private Telerik.WinControls.UI.RadLabel lblMsgAdv;
        private System.Windows.Forms.TabPage tab_moreActions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBoxRemarks;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtConsultRemark;
        private System.Windows.Forms.ListBox lbox_entities;
    }
}
