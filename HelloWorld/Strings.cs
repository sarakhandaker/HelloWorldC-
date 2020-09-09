using System;
using System.Collections.Generic;
namespace HelloWorld
{
    public class Strings
    {
        //Ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive.

        public static void Exercise1()
        {
            Console.Write("Enter enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();
            var numbers=input.Split("-");
            var isConsecutive = true;

            for(int i=0; i<numbers.Length-1; i++)
            {
                if (Convert.ToInt32(numbers[i]) != Convert.ToInt32(numbers[i+1])-1)
                {
                    isConsecutive = false;
                }
            }

            if (isConsecutive)
                Console.WriteLine("Consecutive");
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

        //2- Write a program and ask the user to enter a few numbers separated by a hyphen.
        //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
        //If so, display "Duplicate" on the console.

        public static void Exercise2()
        {
            Console.Write("Enter enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
                return;
            var numbers = input.Split("-");
            List<string> newNumbers = new List<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (newNumbers.Contains(numbers[i]))
                {
                    Console.WriteLine("Duplicates");
                    break;
                }
                else
                {
                    newNumbers.Add(numbers[i]);
                }
            }
        }


        //3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00).
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        //If the user doesn't provide any values, consider it as invalid time.

        public static void Exercise3()
        {
            Console.Write("Enter a time value in the 24-hour time format");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }


        //4- Write a program and ask the user to enter a few words separated by a space.
        //Use the words to create a variable name with PascalCase

        public static void Exercise4()
        {
            Console.Write("enter a few words separated by a space");
            var input = Console.ReadLine();
            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                variableName += char.ToUpper(word[0]) + word.ToLower().Substring(1);
            }

            Console.WriteLine(variableName);

        }


        //5- Write a program and ask the user to enter an English word.
        //Count the number of vowels (a, e, o, u, i) in the word.

        public static void Exercise5()
        { 
            Console.Write("enter an English word");
            var input = Console.ReadLine().ToLower();
            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);

        }
    }
}
