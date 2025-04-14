using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int MinimizeArraySum(int[] arr, int k)
    {
        // Create a max heap using a priority queue
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
        foreach (var num in arr)
        {
            maxHeap.Enqueue(num, num);
        }

        // Perform k operations
        for (int i = 0; i < k; i++)
        {
            var largestNum = maxHeap.Dequeue();
            var newNum = (largestNum + 1) / 2;
            maxHeap.Enqueue(newNum, newNum);
        }

        // Calculate the sum of the remaining elements
        int sum = 0;
        while (maxHeap.Count > 0)
        {
            sum += maxHeap.Dequeue();
        }
        return sum;
    }

    public static void Main1()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int k = 3;
        int result = MinimizeArraySum(arr, k);
        Console.WriteLine("Minimum sum: " + result); // Output: 90
    }
}