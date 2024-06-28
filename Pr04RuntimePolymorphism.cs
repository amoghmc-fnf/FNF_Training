using System;

class Base {
    public virtual void TestFunc() {
        Console.WriteLine("Base Class called!");
    }
}

class Derived : Base {
    public override void TestFunc() {
        Console.WriteLine("Derived Class called!");
    }
}

static class Factory {
    public static Base CreateClass(string choice) {
        if (choice.Equals("B")) {
            return new Base();
        }
        else if (choice.Equals("D")){
            return new Derived();
        }
        else {
            throw new Exception("Invalid Choice!");
        }
    }
}

class Test {
    static void Main() {
        var choice = MyConsole.GetString("Base (B) or Derived? (D)?");
        var obj = Factory.CreateClass(choice.ToUpper());
        obj.TestFunc();
    }
}