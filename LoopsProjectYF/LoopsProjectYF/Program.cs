using System;

namespace LoopsProjectYF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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
    }
}
