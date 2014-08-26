using System;

namespace HRSystem
{
    public class Program
    {
        //Requirements
        /**
         * Preconditions: All employees have first and last name
         * Features:
         * Add: Capture the following details about a new employee
         * ** ID - Automatically assigned and unique
         * ** Name
         * ** Birthdate (mmy/dd/yyyy)
         * ** Hiredate (mmy/dd/yyyy hh:mm:ss) - Automatically assigned
         * Validation:
         * ** Birthdate in the past and employee is at least 21
         * ** First and Last Name
         * ** Redisplay bad data with error message
         * List:  List all employees by id and name ordered by last name asc
         * Detail: List all information for existing employee
         * Delete: Remove employee by id
         *
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Asynchrony HR System.");
            PrintOptions();
            AcceptInput();
        }

        private static void AcceptInput()
        {
            while (true)
            {
                Console.Write("What would you like to do: ");
                var opt = (Opt) Enum.Parse(typeof (Opt), Console.ReadLine());

                switch (opt)
                {
                    case Opt.Add:
                    case Opt.Delete:
                    case Opt.List:
                    case Opt.Detail:
                    case Opt.Help:
                        PrintOptions();
                        continue;
                }
                break;
            }
        }

        private static void PrintOptions()
        {
            Console.WriteLine("Options:");
            Console.WriteLine((int)Opt.Add+ ": " + Opt.Add);
            Console.WriteLine((int)Opt.List+ ": "+ Opt.List);
            Console.WriteLine((int)Opt.Detail + ": " +Opt.Detail);
            Console.WriteLine((int)Opt.Delete + ": " + Opt.Delete);
            Console.WriteLine((int)Opt.Help + ": " + Opt.Help);
        }
    }

    public enum Opt
    {
        Add = 1, List = 2, Detail = 3, Delete = 4, Help = 5
    }
}
