using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLvl_Toy
{
    class MediumLvl_Algo
    {
        static void Main(string[] args)
        {
        }

        //Palindrome check
        // O(n^2) time | O(n) space
        public static bool IsPalindrone(string str1)
        {
            string reversedString = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                reversedString += str1[i];
            }
            return str1.Equals(reversedString);
        }

        //Palindrone Check 2
        // O(n) time | O(n) space
        public static bool IsPalindrone2(string str1)
        {
            StringBuilder reversedstring = new StringBuilder();
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str1.Append(str1[i]);
            }
            return str1.Equals(reversedstring.ToString());
        }

        //Palindrone Check3
        // O(n) time | O(1) space
        public static bool IsPalindrone3(string str1)
        {
            int leftIdx = 0;
            int rightIdx = str1.Length - 1;
            while (leftIdx < rightIdx)
            {
                if (str1[leftIdx] != str1[rightIdx])
                {
                    return false;
                }
                leftIdx++;
                rightIdx--;
            }
            return true;
        }

        //Two Number Sum - Brute Force
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstNum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNum = array[j];
                    if (firstNum + secondNum == targetSum)
                    {
                        return new int[] { firstNum, secondNum };
                    }
                }
            }
            return new int[0];
        }

        //Two Number Sum - Hash Table
        public static int[] TwoNumberSum2(int[] array, int targetSum)
        {
            HashSet<int> nums = new HashSet<int>();
            foreach (int num in array)
            {
                int potentialMatch = targetSum - num;
                if (nums.Contains(potentialMatch))
                {
                    return new int[] { potentialMatch, num };

                }
                else
                {
                    nums.Add(num);
                }
            }
            return new int[0];
        }

        //Two Number Sum - Sort() Method
        public static int[] TwoNumberSum3(int[] array, int targetSum)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int currentSum = array[left] + array[right];
                if (currentSum == targetSum)
                {
                    return new int[] { array[left], array[right] };

                }
                else if (currentSum < targetSum)
                {
                    left++;
                }
                else if (currentSum > targetSum)
                {
                    right--;
                }
            }
            return new int[0];
        }

        //Validate Subsequence
        // O(n) time | O(1) space - where n is the length of the array
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int arrIdx = 0;
            int seqIdx = 0;
            while (arrIdx < array.Count && seqIdx < sequence.Count)
            {
                if (array[arrIdx] == sequence[seqIdx])
                {
                    seqIdx++;
                }
                arrIdx++;
            }
            return seqIdx == sequence.Count;
        }

        //Validate Subsequence 2nd solution
        // O(n) time | O(1) space - where n is the length of the array
        public static bool IsValidateSubsequence2(List<int> array, List<int> sequence)
        {
            int seqIdx = 0;
            foreach (var val in array)
            {
                if (seqIdx == sequence.Count)
                {
                    break;
                }
                if (sequence[seqIdx] == val)
                {
                    seqIdx++;
                }
            }
            return seqIdx == sequence.Count();
        }
    }
}
