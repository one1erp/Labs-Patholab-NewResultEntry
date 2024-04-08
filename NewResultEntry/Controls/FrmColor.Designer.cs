namespace NewResultEntry.Controls
{
    partial class FrmColor
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addColors = new System.Windows.Forms.Button();
            this.lbox_ColorType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridColors2 = new Telerik.WinControls.UI.RadGridView();
            this.gridColors = new Telerik.WinControls.UI.RadGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridColors3 = new Telerik.WinControls.UI.RadGridView();
            this.gridColors4 = new Telerik.WinControls.UI.RadGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors.MasterTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors3.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors4.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Name = "ColumnHeader";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_addColors);
            this.panel1.Controls.Add(this.lbox_ColorType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(843, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 688);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::NewResultEntry.Properties.Resources.Capture;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(104, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 76);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addColors
            // 
            this.btn_addColors.BackgroundImage = global::NewResultEntry.Properties.Resources.v1;
            this.btn_addColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addColors.Image = global::NewResultEntry.Properties.Resources.v1;
            this.btn_addColors.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addColors.Location = new System.Drawing.Point(104, 180);
            this.btn_addColors.Name = "btn_addColors";
            this.btn_addColors.Size = new System.Drawing.Size(75, 83);
            this.btn_addColors.TabIndex = 24;
            this.btn_addColors.UseVisualStyleBackColor = true;
            this.btn_addColors.Click += new System.EventHandler(this.btn_addColors_Click);
            // 
            // lbox_ColorType
            // 
            this.lbox_ColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_ColorType.FormattingEnabled = true;
            this.lbox_ColorType.ItemHeight = 20;
            this.lbox_ColorType.Items.AddRange(new object[] {
            "אימונוהיסטוכימיה",
            "היסטוכימיה ",
            "אחר"});
            this.lbox_ColorType.Location = new System.Drawing.Point(27, 71);
            this.lbox_ColorType.Name = "lbox_ColorType";
            this.lbox_ColorType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbox_ColorType.Size = new System.Drawing.Size(191, 64);
            this.lbox_ColorType.TabIndex = 9;
            this.lbox_ColorType.SelectedIndexChanged += new System.EventHandler(this.lbox_ColorType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "סוג צביעה";
            // 
            // gridColors2
            // 
            this.gridColors2.AutoScroll = true;
            this.gridColors2.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.gridColors2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridColors2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.gridColors2.Location = new System.Drawing.Point(426, 3);
            // 
            // 
            // 
            this.gridColors2.MasterTemplate.AllowAddNewRow = false;
            this.gridColors2.MasterTemplate.AllowColumnReorder = false;
            this.gridColors2.MasterTemplate.AllowColumnResize = false;
            this.gridColors2.MasterTemplate.AllowDeleteRow = false;
            this.gridColors2.MasterTemplate.AllowDragToGroup = false;
            this.gridColors2.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridColors2.MasterTemplate.ShowFilteringRow = false;
            this.gridColors2.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridColors2.Name = "gridColors2";
            this.gridColors2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridColors2.ShowGroupPanel = false;
            this.gridColors2.Size = new System.Drawing.Size(204, 682);
            this.gridColors2.TabIndex = 1;
            // 
            // gridColors
            // 
            this.gridColors.AutoScroll = true;
            this.gridColors.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.gridColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.gridColors.Location = new System.Drawing.Point(636, 3);
            // 
            // 
            // 
            this.gridColors.MasterTemplate.AllowAddNewRow = false;
            this.gridColors.MasterTemplate.AllowColumnReorder = false;
            this.gridColors.MasterTemplate.AllowColumnResize = false;
            this.gridColors.MasterTemplate.AllowDeleteRow = false;
            this.gridColors.MasterTemplate.AllowDragToGroup = false;
            this.gridColors.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridColors.MasterTemplate.ShowFilteringRow = false;
            this.gridColors.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridColors.Name = "gridColors";
            this.gridColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridColors.ShowGroupPanel = false;
            this.gridColors.Size = new System.Drawing.Size(204, 682);
            this.gridColors.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 688);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.gridColors4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridColors3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridColors, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridColors2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 688);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridColors3
            // 
            this.gridColors3.AutoScroll = true;
            this.gridColors3.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.gridColors3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridColors3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.gridColors3.Location = new System.Drawing.Point(216, 3);
            // 
            // 
            // 
            this.gridColors3.MasterTemplate.AllowAddNewRow = false;
            this.gridColors3.MasterTemplate.AllowColumnReorder = false;
            this.gridColors3.MasterTemplate.AllowColumnResize = false;
            this.gridColors3.MasterTemplate.AllowDeleteRow = false;
            this.gridColors3.MasterTemplate.AllowDragToGroup = false;
            this.gridColors3.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridColors3.MasterTemplate.ShowFilteringRow = false;
            this.gridColors3.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.gridColors3.Name = "gridColors3";
            this.gridColors3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridColors3.ShowGroupPanel = false;
            this.gridColors3.Size = new System.Drawing.Size(204, 682);
            this.gridColors3.TabIndex = 2;
            // 
            // gridColors4
            // 
            this.gridColors4.AutoScroll = true;
            this.gridColors4.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.gridColors4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridColors4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.gridColors4.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gridColors4.MasterTemplate.AllowAddNewRow = false;
            this.gridColors4.MasterTemplate.AllowColumnReorder = false;
            this.gridColors4.MasterTemplate.AllowColumnResize = false;
            this.gridColors4.MasterTemplate.AllowDeleteRow = false;
            this.gridColors4.MasterTemplate.AllowDragToGroup = false;
            this.gridColors4.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridColors4.MasterTemplate.ShowFilteringRow = false;
            this.gridColors4.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gridColors4.Name = "gridColors4";
            this.gridColors4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridColors4.ShowGroupPanel = false;
            this.gridColors4.Size = new System.Drawing.Size(207, 682);
            this.gridColors4.TabIndex = 3;
            // 
            // FrmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmColor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridColors3.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors4.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbox_ColorType;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView gridColors2;
        private Telerik.WinControls.UI.RadGridView gridColors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addColors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView gridColors3;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadGridView gridColors4;
    }
}
