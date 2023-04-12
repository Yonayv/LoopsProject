using System;

namespace LoopsProjectYF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user why they want to play games.
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();

            // Prints the interpolation of response and returns CountNumberOfSpaces response.
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            // Asks user to enter a whole number.
            Console.WriteLine("Please enter a whole number!");

            // prints out the second reponse from user by interpolating the SumOfDigits and the response. 
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");

        }

        /// <summary>
        /// Starts variable int at 0
        /// Loops through each char in sentence
        /// If char is a ' ' then numberOfSpaces increase by 1
        /// When it gets to end of the loop its going to return to numberOfSpaces
        /// </summary>
        /// <param name="sentence"> The sentence to count number of spaces </param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        /// <summary>
        /// Loops through each sumOfDigits
        /// Adds sumOfDigits to the sum
        /// Converts the sum added to the sumOfDigits to int to look like string value
        /// </summary>
        /// <param name="number">Passes through string to loop through each char</param>
        /// <returns>Returns int sum/sumofDigits</returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;

        }
    }

}
