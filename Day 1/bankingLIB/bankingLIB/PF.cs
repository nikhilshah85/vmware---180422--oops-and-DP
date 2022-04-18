using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    public class PF :Accounts
    {
        public override double Widraw(int w_balance)
        {
            //base class, astraction  rule is not broken
            if (w_balance > (accBalance * 0.3))
            {
                throw new Exception("You can widraw max " + (accBalance * 0.3));
            }
            return base.Widraw(w_balance);
        }
    }
}
