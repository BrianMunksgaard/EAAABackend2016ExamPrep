using System;

namespace ExamCategoryOne
{
    class Program
    {
        private static int counter; // A private variable called "counter" of the type Integer (int). 

        static void Main(string[] args)
        {

            // variables, data types, assignment, type conversion, DateTime and TimeSpan, namespace, if-statement, for-loops, foreach
            counter = 0; // initializing the variable "counter" to have the value of 0

            // Value types
            char charValue = 'R';
            long longValue = 293874728;
            float floatValue = 10f;
            decimal decimalValue = 42m;
            DateTime datetimeValue = DateTime.Now; // The date today. DateTime is a static class and therefore the property Now can be fetched.
            TimeSpan timespanValue = new TimeSpan(datetimeValue.Ticks);
            bool isTrue = false; // Boolean value. Can also be a Boolean instead of bool

            // Reference types
            string applicationName = string.Empty; // Behaves like a Value Type but is a Reference Type
            object obj = null; // Type checking takes place during compile time
            dynamic dynamicValue = 20; // Type checking takes places during runtime


            // Usage of variables/properties
            Console.WriteLine("");
            Console.WriteLine("IF - isTrue {0}", isTrue);
            if (isTrue)
            {
                Console.WriteLine("All is good :)");
            }
            else
            {
                Console.WriteLine("Hmm, that can't be true!");
            }

            Console.WriteLine("");
            Console.WriteLine("For - Loop of 20 iterations:");
            for (int i = 1; i <= 20; i++) // Or int i = 1; i < 21; i++
            {
                Console.WriteLine("iteration {0}", i); // Could also be written as: "iteration " + i or string.Format("iteration {0}", i);
            }

            string[] cast = new string[] { "Arthur Dent", "Ford Prefect", "Trillian", "Zaphod Beeblebrox" };
            Console.WriteLine("");
            Console.WriteLine("Foreach - Cast of Hitchhikers guide to the Galaxy:");
            foreach (string name in cast)
            {
                Console.WriteLine("\t" + name);
            }

            Console.WriteLine("");
            Console.WriteLine("Press enter to close the console.");
            Console.ReadLine();
        }
    }
}
