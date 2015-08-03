using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    /// <summary>
    /// This defines the Account
    /// Allows the user to deposit and withdraw funds
    /// </summary>
    /// 
    class Account
    {
        #region Properties

        /// <summary>
        /// account number of the account
        /// </summary>
        public int AccountNumber { get; set; }

        // anyone can read the balance, but balance cannot be changed directly
        public double  Balance { get; private set; }

        //public string NameOfUser { get; set; }

        #endregion


        #region Methods

        public void Deposit(double amount)
        {
           // Balance = Balance + amount;
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return false;
            }

            Balance -= amount;
            return true;
        }

        #endregion




    }
}
