using System;
using System.Collections.Generic;

class Expense {
    public int Id { get; set; }
    public string Description { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }

    public override string ToString() {
        return string.Format("Id: {0}, Description: {1}, Amount: {2}, Date: {3}", Id, Description, Amount, Date);
    }
}

class ExpenseCollection {
    private List<Expense> expenses = new List<Expense>();

	public void AddExpense(Expense exp) {
		expenses.Add(exp);
		return;
	}
	
	public void UpdateExpense(int id, Expense exp) {
		for (int i = 0; i < expenses.Count; i++) {
			if (expenses[i].Id.Equals(id)) {
				expenses[i].Description = exp.Description;
				expenses[i].Amount = exp.Amount;
				return;
			}
		}
		throw new Exception("Expense not found!");
	}

    public void RemoveExpense(int id) {
        for (int i = 0; i < expenses.Count; i++) {
			if (expenses[i].Id.Equals(id)) {
                expenses.Remove(expenses[i]);
                return;
			}
		}
		foreach (var item in expenses) {
			if (item.Id.Equals(id))
				expenses.Remove(item);
				return;
		}
		throw new Exception("Expense not found!");
    }

	public Expense FindExpense(int id) {
		for (int i = 0; i < expenses.Count; i++) {
			if (expenses[i].Id.Equals(id)) {
                return expenses[i];
			}
		}
        throw new Exception("Expense not found!");
	}

    public Expense[] GetAllExpenses() {
        return expenses.ToArray();
    }
}