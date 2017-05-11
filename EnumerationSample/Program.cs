using System;
using static System.Console;

namespace EnumerationSample
{
    public enum TimeOfDay
    {
        Morning = 0,
        Afternoon = 1,
        Evening = 2
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteGreeting(TimeOfDay.Morning);
        }

        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    // Get the enum string
                    TimeOfDay time = TimeOfDay.Morning;
                    WriteLine(time.ToString());
                    break;
                case TimeOfDay.Afternoon:
                    WriteLine("Good Afternoon!");
                    break;
                case TimeOfDay.Evening:
                    // Get the enum value from string
                    TimeOfDay time2 = (TimeOfDay)Enum.Parse(typeof(TimeOfDay), "evening", true);
                    WriteLine((int)time2);
                    break;
                default:
                    WriteLine("Hello!");
                    break;
            }
        }
    }
}