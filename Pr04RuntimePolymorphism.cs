using System;

class Base {
    public virtual void TestFunc() {
        Console.WriteLine("Base Class called!");
    }
    public void NonOverriden() {
        Console.WriteLine("This is from Base");
    }
}

class Derived : Base {
    public override void TestFunc() {
        Console.WriteLine("Derived Class called!");
    }

    public void SecondTestFunc() {
        Console.WriteLine("Second Test Function!");
    }

    public void NonOverriden() {
        Console.WriteLine("This is from Derived");
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
        try {
            checked {
                var temp = (Derived) obj;
                temp.SecondTestFunc();
                temp.NonOverriden();
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        obj.TestFunc();
        obj.NonOverriden();
    }
}