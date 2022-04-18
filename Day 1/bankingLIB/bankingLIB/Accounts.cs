using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    public abstract class Accounts
    {
        #region Variables :
        //this is the final place which will store the data
        //this place should never be known to anyone
        int v_accNo;
        string v_accName;
        string v_accType;
        double v_accBalance;
        bool v_accIsActive;
        #endregion

        #region Properties / Attributes
        public int accNo
        {
            get { return v_accNo; }
            set { v_accNo = value; }
        }

        public string accName
        {
            get { return v_accName; }
            set { v_accName = value; }
        }

        public double accBalance
        {
            get { return v_accBalance; }
            set { v_accBalance = value; }
        }

        public bool accIsActive
        {
            get { return v_accIsActive; }
            set { v_accIsActive = value; }
        }

        public string accType
        {
            get { return v_accType; }
            set { v_accType = value; }
        }
        #endregion

        #region Methods  / transactions / function :
        public virtual double Widraw(int w_balance)
        {
            if (w_balance > accBalance)
            {
                throw new Exception("Sorry You cannot widraw more than " + accBalance);
            }
            if (w_balance == 0 || w_balance < 0)
            {
                throw new Exception("Please enter a positive value greater than 100");
            }
            accBalance = accBalance - w_balance;
            return accBalance;
        }

        public double Deposit(int d_amount)
        {
            accBalance = accBalance + d_amount;
            return accBalance;

            #endregion

        }
    }
}
