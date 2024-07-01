using System;

namespace SampleConApp {
    public class Ex12Delegates {

        delegate double Operation(double x, double y);

        static void PerformOperation(double x, double y, Operation method) {
            Console.WriteLine(method(x, y));
        }

        static double addFunc(double x, double y) {
            return x + y;
        }

        static void Main() {
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