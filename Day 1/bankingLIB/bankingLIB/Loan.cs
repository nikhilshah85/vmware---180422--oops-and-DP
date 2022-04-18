using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    public class Loan : Accounts
    {
        public override double Widraw(int w_balance)
        {
            this.accBalance = this.accBalance - w_balance;
            return this.accBalance;
            //here user can pass a negative value, which is not good
        }
    }
}
