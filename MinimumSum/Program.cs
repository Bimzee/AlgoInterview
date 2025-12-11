using MinimumSum;
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

    public static void Main()
    {
        MaxSubArray maxSubArray = new MaxSubArray();
        var result = maxSubArray.FindMaxSubArray(new int[] { 2,1,5,1,3,2 }, 3);
        Console.WriteLine("Maximum subarray sum: " + result);

        //TwoSums twoSums = new TwoSums();
        ////var result = twoSums.TwoSum(new int[] { 3,2,4 }, 6);
        ////var result = twoSums.TwoSumsWith2Pointer(new int[] { 3,2,4 }, 6);
        //var result = twoSums.TwoSum_HashMap(new int[] { 3,2,4 }, 6);
        //Console.WriteLine("Result of TwoSum: " + string.Join(", ", result));

        //Anagram anagramChecker = new Anagram();
        //var first = anagramChecker.IsAnagram("anagram", "nagaram");
        //var second = anagramChecker.IsAnagram("rat", "car");

        //int[] arr = { 10, 20, 30, 40, 50 };
        //int k = 3;
        //int result = MinimizeArraySum(arr, k);
        //Console.WriteLine("Minimum sum: " + result); // Output: 90
    }
}