using System;

namespace BA_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int myInt = 15;

            double myDouble = 25.66;

            Console.WriteLine($"INTEGER VALUE: {myInt}\nDOUBLE VALUE: {myDouble}");
            Console.WriteLine("INTEGER VALUE: " + myInt + "\n" + "DOUBLE VALUE: " + myDouble);

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Welcome Mr./Mrs. {name} {surname} your age is: {age}");

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            int number1;
            int number2;
            int sum1;

            Console.Write("Please enter the first complete number1: ");
            number1 = int.Parse(Console.ReadLine());


            Console.Write("Please enter the first complete number2: ");
            number2 = int.Parse(Console.ReadLine());

            sum1 = number1 + number2;

            Console.WriteLine($"Sum: {sum1}");

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            while (true)
            {
                Console.WriteLine("Please enter your age: ");

                double number3 = double.Parse(Console.ReadLine());

                if (number3 > 90)
                {
                    Console.WriteLine("good Luck");
                }

                else
                {
                    Console.WriteLine("Your age is: " + number3);
                }
            }

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            int number4 = 7;
            int number5 = 9;
            int sum2 = number4 + number4;

            Console.WriteLine(Math.Sqrt(sum2));

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            string sentence = "Hello, How are you";

            Console.WriteLine("what word are you looking for: ");

            string searched_word = Console.ReadLine().ToLower();


            bool value = sentence.Contains(searched_word);

            if (value)
            {
                Console.WriteLine("Searched value found");
            }

            else
            {
                Console.WriteLine("No required value");
            }




        }

    }
}
