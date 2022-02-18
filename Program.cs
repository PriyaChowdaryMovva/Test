using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuesdayExam
{
    class Program
    {
        static public void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 11, 15 };
            int target = 9;
            for(int i=0;i<2;i++)
            Console.WriteLine(TwoSum(numbers,target));

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var d = new Dictionary<int, int>();
            int[] res = new int[2];
            for(int i=0;i<nums.Length;i++)
            {
                if (d.ContainsKey(target - nums[i]))
                {
                    res[0] = i;
                    res[1] = d[target - nums[i]];
                    Array.Sort(res);
                }
                else
                    d.Add(nums[i], i);

            }
            return res;
        }
    }
}