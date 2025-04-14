using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSum
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main2(string[] args)
        {
            int[] nums = { 10, 20, 7 };
            int k = 4;

            // Create a max heap to prioritize removing the largest elements
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
            foreach (int num in nums)
            {
                maxHeap.Enqueue(num, num);
            }

            // Perform k operations
            for (int i = 0; i < k; i++)
            {
                int maxNum = maxHeap.Dequeue();
                int newNum = (int)Math.Ceiling((double)maxNum / 2);
                maxHeap.Enqueue(newNum, newNum);
            }

            // Calculate the sum of the remaining elements
            int sum = 0;
            while (maxHeap.Count > 0)
            {
                sum += maxHeap.Dequeue();
            }

            Console.WriteLine("Minimum sum after k operations: " + sum);
        }
    }
}
