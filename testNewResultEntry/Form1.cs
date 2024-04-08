using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patholab_DAL_V1;
using NewResultEntry;
//using DAL;
//using Common;
//using CreateWorkf;


namespace testPathologResultEntry
{
    public partial class Form1 : Form
    {
        private DataLayer dal = null;

        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            activateWorkListWindow();
        }
        private void activateWorkListWindow()
        {
            try
            {
                //cw
                //var cw = new CreateWorkf.Form1();
                //this.Controls.Add(cw);
                //cw.RightToLeft = RightToLeft.Yes;
                //cw.DEBUG = true;
                //cw.PreDisplay(); 

                //erl
                //var rc = new Ex_Req_Worklist.ex_req_worklist_host();
                ////this.elementHost1.Child = rc;
                //this.Controls.Add(rc);
                //rc.RightToLeft = RightToLeft.Yes;
                //rc.debug = true;
                //rc.activateWorkListWindow(); 


                //pwl
                //PatholabWorkList.WpfPatholabWorkList pl = new PatholabWorkList.WpfPatholabWorkList();
                //pl.initDebug();
                //elementHost1.Child = pl;

                //dal = new DataLayer();
                //dal.MockConnect();
                //PathologResultEntryCls patholog = new PathologResultEntryCls();
                //patholog.Dock = DockStyle.Fill;
                //this.Controls.Add(patholog);

                //nre
                //NewResultEntry.NewResultEntryCls re = new NewResultEntry.NewResultEntryCls();
                //re.initDebug();
                //elementHost1.Child = re;

                //dal = new DataLayer();
                //dal.MockConnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
