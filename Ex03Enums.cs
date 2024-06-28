using System;

namespace SampleConApp {
    enum AccountType {
        SBAccount, RDAccount, FDAccount
    }



    class Ex03Enums {
		static void enumInputExample() {
			foreach (AccountType item in Enum.GetValues(typeof(AccountType))) {
				Console.WriteLine("{0}", item);
			}
			Console.Write("Enter your choice: ");
			string selected = Console.ReadLine();
			object SBAccount = AccountType.SBAccount;

			// get type at runtime
			object boxedAccountType = Enum.Parse(SBAccount.GetType(), selected, true);

			// get type at compiletime
			// object boxedAccountType = Enum.Parse(typeof(AccountType), selected, true);
			AccountType acc = (AccountType) boxedAccountType;

			Console.WriteLine("You have chosen {0}", acc);

		}


        static void Main() {
            // AccountType acc = AccountType.SBAccount;
            // Console.WriteLine("The Account selected is " + acc);
            // Console.WriteLine("Internal value is " + (int) acc);
			enumInputExample();
        }	
    }
}