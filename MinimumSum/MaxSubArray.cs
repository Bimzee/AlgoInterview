using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSum
{
    public class MaxSubArray
    {
        public int FindMaxSubArray(int[] nums, int k)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if (i >= k - 1)
                {
                    maxSum = Math.Max(maxSum, currentSum);
                    currentSum -= nums[i - (k - 1)];
                }
            }
            return maxSum;
        }
    }
}
