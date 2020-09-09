using System;
using System.Collections.Generic;
namespace HelloWorld
{
    public class Arrays
    {
        //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

        public void Exercise1()
        {

            List<string> friends= new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                friends.Add(input);
            }
        }

        //2 - Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.
        public void Exercise2()
        {
            Console.WriteLine("Enter your name");
            string answer = Console.ReadLine();
            char[] nameArray = answer.ToCharArray();
            Array.Reverse(nameArray);
            string reverseName = new string(nameArray);
            Console.WriteLine(reverseName);
        }


        //3 - Write a program and ask the user to enter 5 numbers.
        //If a number has been previously entered, display an error message and ask the user to re-try.
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

        public void Exercise3()
        {
            int[] numbers = new int[5];

            for(int i=0; i<5; i++)
            {
                //Console.Write("Type a number: ");
                //int input = Convert.ToInt32(Console.ReadLine());
                //if (Array.IndexOf(numbers,input))
                //var input = Console.ReadLine();
                //if (String.IsNullOrWhiteSpace(input))
                //    break;
                //friends.Add(input);
            }
        }

        //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates.Display the unique numbers that the user has entered.

        public void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
        }

        //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List"
        //and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

        public void Exercise5()
        {
            Console.WriteLine("Enter your name");
            string answer = Console.ReadLine();
        }

    }
}
