using System;

namespace ConsoleApp2
{
    internal class Reverse_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let me tell you something!\nWhatever you write,\nI can write it to you backwards");
            Console.WriteLine("So please, type a Word, Number or both together");
            char[] userStringArray = Console.ReadLine().ToCharArray();              // user input
            char[] reverseStringArray = new char[userStringArray.Length];
            Array.Copy(userStringArray, reverseStringArray, userStringArray.Length);
            int stringLength = reverseStringArray.Length;                           //length of String
            Console.Write($"Your word backwards is: ");
            //for loop to store userString chars in reverse order into reverseString
            for (int i = 0; i < stringLength - 1; i++)
            {
                char temp1 = reverseStringArray[i];
                char temp2 = reverseStringArray[stringLength - 1 - i];
                reverseStringArray[i] = temp2;
                reverseStringArray[stringLength - 1 - i] = temp1;
            }
            //output of reversed string
            Console.WriteLine(reverseStringArray);
            //check for palindroms
            string userString = new string(userStringArray).ToLower();
            string reverseString = new string(reverseStringArray).ToLower();
            if (reverseString == userString)
            {
                Console.WriteLine("You have a Palindrom there pal.");
            }
            else
            {
                Console.WriteLine("No palindrom detected.");
            }
        }
    }
}
