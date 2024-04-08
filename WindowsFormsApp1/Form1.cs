using Patholab_DAL_V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Patholab_DAL_V1.DataLayer _dal;
        private void button1_Click(object sender, EventArgs e)
        {


            


             _dal = new Patholab_DAL_V1.DataLayer();
            _dal.MockConnect();


            LearnPhrases();

            //sdg
            var currentSDG = _dal.FindBy<SDG_USER>(x => x.SDG_ID == 15681).FirstOrDefault();

            //container
            var currContainerA = currentSDG.U_CONTAINER;

            var currContainerID = currentSDG.U_CONTAINER_ID;

            var currContainer = _dal.FindBy<U_CONTAINER_USER>(x => x.U_CONTAINER_ID == currContainerID).FirstOrDefault();

            //order
            var currOrderA = currentSDG.U_ORDER;

            var currOrderID = currentSDG.U_ORDER_ID;
            var currOrder = _dal.FindBy<U_ORDER_USER>(x => x.U_ORDER_ID == currOrderID).FirstOrDefault();

            //customer
            //var currCustA = currentSDG

            var currcustID = currOrder.U_CUSTOMER;
            var currCust = _dal.FindBy<U_CUSTOMER_USER>(x => x.U_CUSTOMER_ID == currcustID).FirstOrDefault();

            var orow_c_code = currentSDG.U_ORDER.U_ORDER_USER.U_CUSTOMER1.U_CUSTOMER_USER.U_CUSTOMER_CODE;


            //clinic error!!
            var currClinic = currentSDG.IMPLEMENTING_CLINIC;
            //MessageBox.Show(currClinic.NAME);

            //parts
            var orow = currentSDG.U_ORDER.U_ORDER_USER.U_PARTS.NAME;
            //var currParts = currentSDG

            var currPartsID = currOrder.U_PARTS_ID;
            var currParts = _dal.FindBy<U_PARTS_USER>(X => X.U_PARTS_ID == currPartsID);

            //supplier
            var currSupplierA = currentSDG.IMPLEMENTING_PHYSICIAN;

            var currSupplierID = currentSDG.IMPLEMENTING_PHYSICIAN.SUPPLIER_ID;
           // var currSupplierID_direct = currentSDG.U_IMPLEMENTING_PHYSICIAN;
            var currSupplier = _dal.FindBy<SUPPLIER_USER>(X => X.SUPPLIER_ID == currSupplierID);

            //client  
            var currClient = currentSDG.CLIENT;

            //phrase
            var phrase = _dal.GetPhraseByName("AEphrase");
            

            string end = Convert.ToString(currentSDG.SDG_ID) +" "+ Convert.ToString(currCust.U_CUSTOMER_ID) + " " + Convert.ToString(currOrderA.U_ORDER_ID) + " " + Convert.ToString(currContainerA.U_CONTAINER_ID) + " " + Convert.ToString(currPartsID) + " " + Convert.ToString(currSupplierA.SUPPLIER_ID) + " " + Convert.ToString(currClient.CLIENT_ID);

            MessageBox.Show(Convert.ToString(phrase.NAME));

         
            
       }

        private void LearnPhrases()
        {
            PHRASE_HEADER phrase
                = _dal.GetPhraseByName("AEphrase");

            List<PHRASE_ENTRY> entries = phrase.PHRASE_ENTRY.ToList();
        


        }

        private void trials()
        {
            Patholab_DAL_V1.DataLayer _dal = new Patholab_DAL_V1.DataLayer();
            _dal.MockConnect();

            var currentSDG = _dal.FindBy<SDG>(x => x.SDG_ID == 15681).FirstOrDefault();
            currentSDG.SDG_USER.U_ISCONSULT = "T";
            _dal.SaveChanges();


            //List<SDG> allSdgs = _dal.GetAll<SDG>().ToList();
            //List<SDG> sdgsByCondition = _dal.FindBy<SDG>(x => x.STATUS == "X").ToList();


            var a = currentSDG.SDG_USER.U_ISCONSULT;
            MessageBox.Show(a);


           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patholab_DAL_V1.DataLayer _dal = new Patholab_DAL_V1.DataLayer();
            _dal.MockConnect();

            
            var currentSDG = _dal.FindBy<SDG>(x => x.SDG_ID == 647917).FirstOrDefault();
            var pID = currentSDG.SDG_USER.U_PATHOLOG;
            var currenrtOperator = _dal.FindBy<OPERATOR>(X => X.OPERATOR_ID == pID);
            string currenrtOperatorName = currenrtOperator.FirstOrDefault().NAME;

            var phraseID = _dal.GetPhraseByName("Sign By").PHRASE_ID;

            var phraseList = _dal.FindBy<PHRASE_ENTRY>(x=>x.PHRASE_ID == phraseID);

            bool hasMatchingPhrases = phraseList.Any(X => X.PHRASE_NAME.Contains(currenrtOperatorName));

            if (! hasMatchingPhrases)
                MessageBox.Show("o.k" + currenrtOperatorName);
            else
                MessageBox.Show("something went wrong");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            _dal = new Patholab_DAL_V1.DataLayer();
            _dal.MockConnect();

                        
            var currentSDG = _dal.FindBy<SDG>(x => x.SDG_ID == 647917).FirstOrDefault();
            var exReqID = currentSDG?.U_EXTRA_REQUEST_USER?.FirstOrDefault()?.U_EXTRA_REQUEST_ID;

            bool isValueFound = false;

            if (exReqID != null)
            {
                var count = _dal.FindBy<U_EXTRA_REQUEST_DATA_USER>(x => x.U_EXTRA_REQUEST_ID == exReqID && (x.U_REQ_TYPE.Equals("H")) || x.U_REQ_TYPE.Equals("O") || x.U_REQ_TYPE.Equals("I")).Count();
               
                if (count > 0)
                {
                    isValueFound = true;
                }
            }

            MessageBox.Show(isValueFound.ToString());
        }
    }

    
}

