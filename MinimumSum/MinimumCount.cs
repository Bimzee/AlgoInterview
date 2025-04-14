using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSum
{

    class MinSum
    {
        static int FindMinimumUnrepresentableNumber(int[] arr)
        {
            // Sort the array
            Array.Sort(arr);

            // Base case: if the first element is not 1, then 1 cannot be represented
            //if (arr[0] != 1)
            //{
            //    return 1;
            //}

            int currentSum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > currentSum + 1)
                {
                    return currentSum + 1;
                }
                currentSum |= arr[i];
            }

            return currentSum + 1;
        }

        static void Main()
        {
            CoinChangeProblem.CoinChangeMain();
            charCount.Main1();
            //int[] numbers = { 1, 3, 4, 0 };
            //int minimumUnrepresentableNumber = FindMinimumUnrepresentableNumber(numbers);
            //Console.WriteLine("The minimum unrepresentable number is: " + minimumUnrepresentableNumber);
        }
    }
}
