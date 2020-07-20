using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Easy
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        //Two Sum - wanted the index of the values not the values themselves
        public static int[] TwoSum(int[] array, int target)
        {
            HashSet<int> nums = new HashSet<int>();

            foreach (int num in array) {
                
                int potentialMatch = num - target;
                if (nums.Contains(potentialMatch))
                {
                    return new int[] {potentialMatch, num };
                }
                else
                {
                    nums.Add(num);
                }

            }
            return new int[0];
        }

        public static bool IsPalindrone(int num1)
        {
            int[] array = num1.To;
            int i = 0;
            int j = num1.Length - 1;


        }
    }
}
