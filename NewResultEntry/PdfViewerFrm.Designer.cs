﻿namespace NewResultEntry
{
    partial class PdfViewerFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPdfViewer1 = new Telerik.WinControls.UI.RadPdfViewer();
            this.radPdfViewerNavigator1 = new Telerik.WinControls.UI.RadPdfViewerNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.radPdfViewer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(1411, 781);
            this.radPdfViewer1.TabIndex = 0;
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            // 
            // radPdfViewerNavigator1
            // 
            this.radPdfViewerNavigator1.AssociatedViewer = this.radPdfViewer1;
            this.radPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPdfViewerNavigator1.DragSize = new System.Drawing.Size(16, 16);
            this.radPdfViewerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radPdfViewerNavigator1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1";
            this.radPdfViewerNavigator1.Size = new System.Drawing.Size(1411, 46);
            this.radPdfViewerNavigator1.TabIndex = 0;
            this.radPdfViewerNavigator1.Click += new System.EventHandler(this.radPdfViewerNavigator1_Click);
            // 
            // PdfViewerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 781);
            this.Controls.Add(this.radPdfViewerNavigator1);
            this.Controls.Add(this.radPdfViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PdfViewerFrm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Pdf Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
        private Telerik.WinControls.UI.RadPdfViewerNavigator radPdfViewerNavigator1;
    }
}
