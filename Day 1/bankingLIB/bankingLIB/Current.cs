using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    public class Current : Accounts
    {
        public override double Widraw(int w_balance)
        {
            if (w_balance > 50000)
            {
                throw new Exception("Current account can widraw max 50K");
            }
            return base.Widraw(w_balance);
        }
    }
}
