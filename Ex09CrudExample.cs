using System;
using System.Collections.Generic;

namespace SampleConApp {
    class Expense {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public override string ToString() {
            return string.Format("Id: {0}, Description: {1}, Amount: {2}, Date: {3}", Id, Description, Amount, Date);
        }
    }
    class Ex09CrudExample {
        static void Main() {
            List<Expense> expenses = new List<Expense>();
            int size = MyConsole.GetInteger("Enter total no of objects to create");
            for (int i = 0; i < size; i++) {
                string desc = MyConsole.GetString(string.Format("Enter description of object {0}", i));
                double amt = MyConsole.GetDouble(string.Format("Enter amount of object {0}", i));
                Expense exp = new Expense {
                    Id = i + 1,
                    Description = desc,
                    Amount = amt,
                    Date = DateTime.Now
                };
                expenses.Add(exp);
            }
            Expense[] expArray = expenses.ToArray();
            for (int i = 0; i < expArray.Length; i++) {
                Console.WriteLine(expArray[i].ToString());
            }
        }
    }
}