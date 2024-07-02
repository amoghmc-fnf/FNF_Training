using System;
using System.Threading;

namespace FrameworkExamples {
    class AlarmClock {
        public event Action OnAlarmTime;
        private readonly DateTime alarmTime;
        public AlarmClock(DateTime alarmTime) {
            this.alarmTime = alarmTime;
        }

        public void DisplayClock() {
            if (DateTime.Now.Minute == alarmTime.Minute) {
                //Raise the event...
                if(OnAlarmTime != null)
                    OnAlarmTime();
                else
                    Console.WriteLine("Event handler is not set");
            }
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
    class EventsExample {
        static void testFunc() {
            Console.WriteLine("Test Func");
        }
        static void Main(string[] args) {
            // ActionExample();
            ClockExample();
        }

        private static void ClockExample() {
            AlarmClock clock = new AlarmClock(DateTime.Now.AddMinutes(1));
            clock.OnAlarmTime += onAlarmRaised;
            clock.OnAlarmTime += () => Console.WriteLine("Using Anonymous methods");
            do {
                clock.DisplayClock();
                Thread.Sleep(1000);//1 sec stopage....
                Console.Clear();
            } while (true);
        }

        private static void onAlarmRaised() {
            Console.WriteLine("Time for break!!!");
        }

        static double addFunc(double x, double y) {
            return x + y;
        }

        private static void ActionExample() {
            Action example = () => Console.WriteLine("Using Anonymous methods");
            example += () => Console.WriteLine("Using Anonymous methods 2");
            example();
        }
    }
}