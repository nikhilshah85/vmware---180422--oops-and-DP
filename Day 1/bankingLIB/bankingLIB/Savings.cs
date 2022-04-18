using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    public class Savings : Accounts
    {
        public override double Widraw(int w_balance)
        {
            if (w_balance > 20000)
            {
                throw new Exception("Savings account can widraw max 20K");
            }
            return base.Widraw(w_balance); //rest of the rules are set in the base class, we abstracted the common validations in the accounts class
        }
    }
}
