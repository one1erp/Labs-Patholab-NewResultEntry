using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NewResultEntry
{
    public partial class PdfViewerFrm : Telerik.WinControls.UI.RadForm
    {
        public PdfViewerFrm(string uAtfilenm)
        {
            InitializeComponent();

            this.radPdfViewer1.LoadDocument(uAtfilenm);
        }

        private void radPdfViewerNavigator1_Click(object sender, EventArgs e)
        {

        }
    }
}
