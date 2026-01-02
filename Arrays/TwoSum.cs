using System;

namespace Algorithms.Arrays
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Zaman Karmaşıklığı: O(n^2) - Brute Force Yaklaşımı
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }
    }
}