using System;
using System.Collections.Generic;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 3;
            nums[1] = 2;
            nums[2] = 4;
            var result = TwoSum(nums, 6);
            foreach (int i in result)
            {
                Console.Write(i + "\t\t");
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                List<int> list = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length -1; j++)
                    {
                        if ((nums[i] + nums[j+1]) == target)
                        {
                            list.Add(i);
                            list.Add(j + 1);
                            return list.ToArray();
                        }
                    }
                }
                return list.ToArray();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}



//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]