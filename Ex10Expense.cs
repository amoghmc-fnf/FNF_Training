using System;
using System.IO;
using System.Collections.Generic;

namespace SampleConApp {
    class Ex10Expense {
        static ExpenseCollection expCollection = new ExpenseCollection();

        static void Main() {
            string text = File.ReadAllText(@"C:\Users\6147952\Documents\FNF_Training\expense_menu.txt");
            bool processing = false;
            do {
                try {
                    Console.WriteLine(text);
                    string choice = Console.ReadLine();  
                    processing = ProcessMenu(choice);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            while (processing);
        }

        static bool ProcessMenu(string choice) {
            switch (choice) {
                case "1":
                    addExpenseFeature();
                    return true;
                case "2":
                    findExpenseFeature();
                    return true;
                case "3":
                    updateExpenseFeature();
                    return true;
                case "4":
                    deleteExpenseFeature();
                    return true;
                case "5":
                    displayExpenseFeature();
                    return true;
                default:
                    return false;
            }
        }

        static void addExpenseFeature() {
            int id = MyConsole.GetInteger("Enter ID");
            string desc = MyConsole.GetString("Enter description");
            double amt = MyConsole.GetDouble("Enter amount");
            Expense exp = new Expense {
                Id = id,
                Description = desc,
                Amount = amt,
                Date = DateTime.Now
            };
            
            expCollection.AddExpense(exp);
        }

        static void updateExpenseFeature() {
            int id = MyConsole.GetInteger("Enter ID of expense to update");
            Expense found = null;
            // throws exception if not found
            found = expCollection.FindExpense(id);
            string desc = MyConsole.GetString("Enter description");
            double amt = MyConsole.GetDouble("Enter amount");
            Expense exp = new Expense {
                Description = desc,
                Amount = amt
            };
            expCollection.UpdateExpense(id, exp);
        }

        static void findExpenseFeature() {
            int id = MyConsole.GetInteger("Enter ID of expense to find");
            Console.WriteLine(expCollection.FindExpense(id).ToString());
        }

        static void deleteExpenseFeature() {
            int id = MyConsole.GetInteger("Enter ID of expense to delete");
            expCollection.RemoveExpense(id);
        }

        static void displayExpenseFeature() {
            Expense[] expArray = expCollection.GetAllExpenses();
            foreach (var item in expArray) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}