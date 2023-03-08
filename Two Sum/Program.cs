using System;
using System.Collections.Generic;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            nums[0] = 2;
            nums[1] = 5;
            nums[2] = 5;
            nums[3] = 11;

            var result = TwoSum(nums, 10);
            foreach (int i in result)
            {
                Console.Write(i + "\t\t");
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                //* My Solution: O(n^2)
                //List<int> list = new List<int>();
                //for (int i = 0; i < nums.Length; i++)
                //{
                //    for (int j = 0; j < nums.Length - 1; j++)
                //    {
                //        if (i == j+1)
                //        {
                //            continue;
                //        }
                //        if ((nums[i] + nums[j+1]) == target)
                //        {
                //            list.Add(i);
                //            list.Add(j + 1);
                //            return list.ToArray();
                //        }
                //    }
                //}
                //return list.ToArray();

                //* Best Performance Solution on Internet: O(n)
                Dictionary<int,int> map = new Dictionary<int,int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i]; // Reverse the equation to be (x = target - y) instead of (target = x + y)
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }
                    map[nums[i]] = i;
                }
                return new int[] { 0, 0 };
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}