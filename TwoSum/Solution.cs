﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Solution
    {
        /*
         * Given an array of integers nums and an integer target, return indices of the two
         * numbers such that they add up to target.
         * You may assume that each input would have exactly one solution, and you may not use the same element twice.
         * You can return the answer in any order.

            Example 1:

            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            Example 2:

            Input: nums = [3,2,4], target = 6
            Output: [1,2]
            Example 3:

            Input: nums = [3,3], target = 6
            Output: [0,1]
 

            Constraints:

            2 <= nums.length <= 104
            -109 <= nums[i] <= 109
            -109 <= target <= 109
            Only one valid answer exists.
         */
        public static int[] getArrTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> comp = new Dictionary<int, int>();

            for (int i = 0; i<nums.Length; i++)
            {
                if (comp.ContainsValue(nums[i]))
                {
                    result[0] = comp.FirstOrDefault(x => x.Value == nums[i]).Key;
                    result[1] = i;
                    break;
                }
                else
                {
                    comp.Add(i, target - nums[i]);
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            int[] input = { 2, 7, 11, 15};
            int[] input3 = { 7, 3, 5 };

            Array.ForEach(getArrTwoSum(input, 9), Console.WriteLine);
            Array.ForEach(getArrTwoSum(input3, 8), Console.WriteLine);

        }
    }
}
