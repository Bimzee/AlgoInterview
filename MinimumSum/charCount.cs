using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSum
{


    public class charCount
    {
        public static void Main1()
        {
            //Console.Write("Enter a string: ");
            string input = "aabbccccaa";

            string output = "";
            char currentChar = input[0];
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    output += currentChar + count.ToString();
                    currentChar = input[i];
                    count = 1;
                }
            }

            output += currentChar + count.ToString();

            Console.WriteLine("Output: " + output);
        }
    }
}
