using System;

public class MyConsole {
    public static string GetString(string question) {
        Console.WriteLine(question);
        return Console.ReadLine();
    }
    public static int GetInteger(string question) {
        int result;
        do {
            Console.WriteLine(question);
        } 
        while(!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
    public static double GetDouble(string question) {
        double result;
        do {
            Console.WriteLine(question);
        } 
        while(!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
    public static DateTime GetDateTime(string question) {
        DateTime result;
        do {
            Console.WriteLine(question);
        } 
        while(!DateTime.TryParse(Console.ReadLine(), out result));
        return result;
    }
}