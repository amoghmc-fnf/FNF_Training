using System;
using System.Collections.Generic;

class Ex14ListsAndDelegates {
    static void Basics() {
        List<string> items = new List<string> {
            "Apples", "Oranges", "Mangoes", "Rin", "Tomatoes", "grapes", "brushes", "soaps"
        };
        string selected = MyConsole.GetString("Enter name of item to find:");
        // var found = items.Find(e => e.StartsWith(selected));
        // Console.WriteLine("The found element is " + found);

        var found = items.Find(delegate (string arg) {
            return arg.StartsWith(selected);
        });
        Console.WriteLine("The found element is " + found);

        var selectedItems = items.FindAll(item => item.Contains(selected));
        Console.WriteLine("The other elements with matching letters are:");
        foreach (var item in selectedItems)
            Console.WriteLine(item);
    }

    static void EmployeeFind() {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee { EmpName = "Raj", EmpId = 111, EmployeeAddress = "BLR", EmployeeSalary = 5000 });
        empList.Add(new Employee { EmpName = "Ram", EmpId = 112, EmployeeAddress = "HSN", EmployeeSalary = 5000 });
        empList.Add(new Employee { EmpName = "Khan", EmpId = 115, EmployeeAddress = "MYS", EmployeeSalary = 3000 });
        empList.Add(new Employee { EmpName = "Rohit", EmpId = 116, EmployeeAddress = "HPT", EmployeeSalary = 5000 });

        string selected = MyConsole.GetString("Enter name of item to find:");
        var found = empList.Find(delegate (Employee arg) {
            return arg.EmpName.StartsWith(selected);
        });
        Console.WriteLine("The found element is " + found);

        var selectedItems = empList.FindAll(item => item.EmpName.Contains(selected));
        Console.WriteLine("The other elements with matching letters are:");
        foreach (var item in selectedItems)
            Console.WriteLine(item.ToString());
    }
    static void Main() {
        // Basics();
        EmployeeFind();

    }
}

class Employee {
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int EmployeeSalary { get; set; }
    public string EmployeeAddress { get; set; }

    public override string ToString() {
        return string.Format("{0} {1} {2}", EmpId, EmpName, EmployeeSalary);
    }

    public override bool Equals(object obj)
    {
        if (obj is Employee)
        {
            Employee temp = obj as Employee;
            return ((temp.EmpId == this.EmpId) && (temp.EmpName == this.EmpName));
        }
        else
        {
            //They are not equal
            return false;
        }
    }
    public override int GetHashCode()
    {
        return this.EmpId;
    }
}