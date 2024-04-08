using Patholab_DAL_V1;

namespace NewResultEntry.Controls.Extra_req_Entities
{
    public class Advisor
    {
        public OPERATOR opAdv { get; set; }
        public override string ToString ( )
        {
            return opAdv.OPERATOR_USER.U_DEGREE + " " + opAdv.NAME;
        }
    }
}