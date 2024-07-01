using System;

namespace SampleConApp {
    public class Ex12Delegates {

        delegate double Operation(double x, double y);
        delegate void LogMessageDelegate(string message);

        static void PerformOperation(double x, double y, Operation method) {
            Console.WriteLine(method(x, y));
        }

        static void LogInfo(LogMessageDelegate method, string msg) {
            method(msg);
        }

        static double addFunc(double x, double y) {
            return x + y;
        }

        static void Hello(string message) {
            Console.WriteLine("Hello " + message);
        }

        static void Bye(string message) {
            Console.WriteLine("Bye " + message);
        }

        static void Main() {
            BasicFunctionalities();
            MultiCastDelegates();
        }

        static void MultiCastDelegates() {
            LogMessageDelegate logger = new LogMessageDelegate(Hello);
            logger += Bye;
            LogInfo(logger, "World!");
        }

        static void BasicFunctionalities() {
            // add func
            PerformOperation(13, 12, addFunc);
            
            // multiply func using anonymous method
            PerformOperation(13, 12, delegate (double v1, double v2) {
                return v1 * v2;
            });

            // subtract func using lambda expression
            PerformOperation(13, 12, (v1, v2) => v1 - v2);

            // func using lambda expression with multiple lines
            PerformOperation(5000, 6.5, (p, r) => {
                var interest = p * (r / 100) * 0.25;
                return interest;
            });
        }
    }
}