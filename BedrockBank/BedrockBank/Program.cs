using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{

    class Program
    {
        static void Main(string[] args)
        {
            // left hand sife is definition and right side is instantiation (memory allocated)
            Account myAccount = new Account();
            /// this is not going to work because the Balance property in the Account is private set
            // myAccount.Balance = 100000000;
            // but the get would work because the read is not private
            Console.WriteLine(myAccount.Balance);
            Console.ReadKey();
        }
    }
}
