using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patholab_Common;
using Patholab_DAL_V1;
using Telerik.WinControls.UI;

namespace NewResultEntry
{
   public class ListData
    {
       private DataLayer _dal;

       public ListData(DataLayer _dal)
       {
           // TODO: Complete member initialization
           this._dal = _dal;
           newReDescList = _dal.GetAll<U_NEW_RE_DESC_USER>().ToList();
            _phrase4Pap = new Dictionary<long, PHRASE_HEADER>();
       }

       public    List<U_NEW_RE_DESC_USER> newReDescList { get; private set; }
   
        private Dictionary<long, PHRASE_HEADER> _phrase4Pap;


        internal PHRASE_HEADER GetPhraseByID(long phraseId)
        {

            if (_phrase4Pap.ContainsKey(phraseId))
            {
                return _phrase4Pap[phraseId];
            }
            else
            {
                var ph=_dal.GetPhraseByID(phraseId);
                _phrase4Pap.Add(phraseId, ph);
                return _phrase4Pap[phraseId];

            }

        }




        public void SetExistsList2Combo(RadDropDownList comboBox, List<PHRASE_ENTRY> list, bool newCtx = true)
        {
            if (list == null)
                return;
            // Running on the worker thread



            if (newCtx)
            {
                comboBox.BindingContext = new BindingContext();
            }
            comboBox.DisplayMember = "PHRASE_DESCRIPTION";
            comboBox.ValueMember = "PHRASE_NAME";
            //comboBox.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;


            comboBox.DataSource = list;



            // Back on the worker thread




        }

        public List<PHRASE_ENTRY> SetPhrase2Combo(RadDropDownList comboBox, string phraseName)
        {
            try
            {
                //todo:change func



                var list = _dal.GetPhraseEntries(phraseName).ToList();

                SetExistsList2Combo(comboBox, list, false);
                return list;



            }
            catch (Exception e)
            {
                Logger.WriteLogFile(e); MessageBox.Show("Error in load " + phraseName + " Phrase " + e.Message, Constants.MboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

      
    }
}
