using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double withReminderCourses = (double)people / capacity;

            Console.WriteLine(Math.Ceiling(withReminderCourses));
           
        }
    }
}
