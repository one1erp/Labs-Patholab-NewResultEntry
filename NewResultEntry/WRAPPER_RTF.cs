using Patholab_DAL_V1;
using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NewResultEntry
{
    public class WrapperRtf
    {


        public string TestName
        {
            get { return Result_.TESTNAME; }
        }



        public long ResultId
        {
            get { return Result_.RESULT_ID; }
        }


   
        public int MyProperty { get; set; }

   

        public string RtfText
        {
            get { return Result_.RTF_TEXT; }
            set { Result_.RTF_TEXT = value; }
        }

        public string Name
        {
            get { return Result_.RESULTNAME; }
        }

        //

        public U_NEW_RE_DESC_USER NewDescRow { get; set; }

        //   public string FormattedResult { get; set; }

        public RadControl Ctl { get; set; }

        public Patholab_DAL_V1.SDG_RESULTS Result_ { get; set; }
    }

    public static class PapConstants
    {

        public static string Test_Recommendations = "Recommendations";
        public static string Test_Results = "Results";
        public static string Test_Clinical_info = "Clinical info";
        public static string Test_Adequacy = "Adequacy";
        public static string Test_PapFreeTxt = "Free Text Result";



        //for ui
        public const string HPV_TAG = "HPV_TAG";

        //Result names
        public static string ResultPos4 = "Result Pos 4";
        public static string ResultPos3 = "Result Pos 3";
        public static string ResultPos2 = "Result Pos 2";
        public static string ResultPos1 = "Result Pos 1";

        public static string ResultNeg4 = "Result Neg 4";
        public static string ResultNeg3 = "Result Neg 3";
        public static string ResultNeg2 = "Result Neg 2";
        public static string ResultNeg1 = "Result Neg 1";

        public static string Remarks4 = "Remarks 4";
        public static string Remarks3 = "Remarks 3";
        public static string Remarks2 = "Remarks 2";
        public static string Remarks1 = "Remarks 1";


        //Recomendation

        public static string Malignant = "Malignant";
        public static string Recommendation2 = "Recommendation 2";
        public static string Recommendation1 = "Recommendation 1";
        public static string Sign_by_1_screener = "Sign by Screener";
        public static string Sign_by_2_screener = "Sign by 2 Sc";
        public static string SignbyPatholog = "Sign by 2nd.";
        public static string HpvSignBy = "Authrised HPV By";


        //Adequency
        public static string LessThanOptimal4 = "Less Than Optimal 4";
        public static string LessThanOptimal3 = "Less Than Optimal 3";
        public static string LessThanOptimal2 = "Less Than Optimal 2";
        public static string LessThanOptimal1 = "Less Than Optimal 1";
        public static string Unsatisfactory4 = "Unsatisfactory 4";
        public static string Unsatisfactory3 = "Unsatisfactory 3";
        public static string Unsatisfactory2 = "Unsatisfactory 2";
        public static string Unsatisfactory1 = "Unsatisfactory 1";
        public static string ChooseAdeq = "Adequacy";

        //Clinical test
        public static string ClinicalInformation6 = "Clinical Information 6";
        public static string ClinicalInformation5 = "Clinical Information 5";
        public static string ClinicalInformation4 = "Clinical Information 4";
        public static string ClinicalInformation3 = "Clinical Information 3";
        public static string ClinicalInformation2 = "Clinical Information 2";
        public static string ClinicalInformation1 = "Clinical Information 1";
        public static string Clinical_PapSpecimenType = "Pap specimen type";
    }

    public static class Constants
    {
        public static string MboxCaption = "Nautilus";

        public static string HisMac = "Histology Macro text";
        public static string HisMic = "Histology Micro";
        public static string CytMac = "Cytology Macro Text";
        public static string CytMic = "Citology Micro";
        public static string Diag = "Diagnosis";
        public static string ImpDiagnos = "Imp_Diagnos";


        //SNOMED Results
        public static string SnomedT = "Snomed T";
        public static string SnomedM = "Snomed M";
        // public static string Preliminary = "Preliminary";
        //     public static string Infected_lymph_nodes = "Infected lymph nodes";


        public static string Sign1St = "Sign by 1st.";
        public static string Sign2Nd = "Sign by 2nd.";

        public static string Malignant = "Malignant";
        public static string Lymphnodespresent = "No of lymph nodes present";
        public static string Lymphnodescarcinoma = "No of lymph nodes infiltrated by carcinoma";

        public static string TumorBehavior = "Tumor behavior";

        public static string PapFreeTxt = "Free Text Result";
    }

    #region combo box Helpers

    public class CustomAutoCompleteSuggestHelper : AutoCompleteSuggestHelper
    {
        public CustomAutoCompleteSuggestHelper(RadDropDownListElement owner)
            : base(owner)
        { }

        public override void ApplyFilterToDropDown(string filter)
        {
            base.ApplyFilterToDropDown(filter);
            this.DropDownList.ListElement.DataLayer.DataView.Comparer = new CustomComparer();
        }
    }

    public class CustomComparer : IComparer<RadListDataItem>
    {
        public int Compare(RadListDataItem x, RadListDataItem y)
        {
            return x.Text.Length.CompareTo(y.Text.Length);
        }
    }

    #endregion
}