using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSum
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                int current = nums[j];
                for (int i = 1; i < nums.Length; i++)
                {
                    if ((current + nums[i]) == target)
                        return new int[] { j, i};
                }
            }
            return new int[] { };
        }

        public int[] TwoSumsWith2Pointer(int[] nums, int target)
        {
            nums = nums.OrderBy(x => x).ToArray();
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    return new int[] { left, right };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return new int[] { };
        }

        public int[] TwoSum_HashMap(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };

                if (!map.ContainsKey(nums[i])) // avoid duplicates
                    map.Add(nums[i], i);
            }

            return Array.Empty<int>();
        }

    }
}
