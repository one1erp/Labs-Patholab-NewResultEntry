using System.Collections.Generic;

namespace NewResultEntry.Controls.Extra_req_Entities
{
    public class BlockWrapper
    {
        public string sample { get; set; }
        public string block { get; set; }
        public string AliquotStatus { get; set; }

        public BlockWrapper ( )
        {
            //  Colors4add = new List<ColNum> ( );
        }

        public string Colostr
        {
            get
            {
                string lcez = "";
                foreach ( var a in Colors4add )
                {
                    lcez += a.Key + "#" + a.Value + "\n";
                }

                return lcez;
            }
            //set;
        }

        public Dictionary<string, int> Colors4add { get; set; }

        internal void AddColors ( List<ColNum> list )
        {
            Colors4add = new Dictionary<string, int> ( );
            foreach ( ColNum colNum in list )
            {
                Colors4add.Add ( colNum.Color, colNum.Quantity );
            }
        }
    }
}
