using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ToyProb2
{


    public class ToyProb2
    {

        static void Main(string[] args)
        {
        }

        //Reverse Words in a String III - Leet 557
        public string ReverseWords(string str1)
        {
            StringBuilder stringBuild = new StringBuilder();
            string[] strArray = str1.Split(' ');

            foreach (string word in strArray)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    stringBuild.Append(word[i]);
                }
                stringBuild.Append(" ");
            }
            stringBuild.Length--;

            return stringBuild.ToString();
        }

        //Maximum Subarray - Leet 53
        public static int MaxSub(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i - 1] + nums[i] > nums[i])
                {
                    nums[i] += nums[i - 1];
                }
            }
            return nums.Max();
        }

        //Remove Vowels - Leet 1119
        public static string RemoveVowels(string str1)
        {
            HashSet<char> hash = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            StringBuilder stringBuild = new StringBuilder();
            foreach (char c in str1)
            {
                if (!hash.Contains(c))
                {
                    stringBuild.Append(c);
                }
            }
            return stringBuild.ToString();
        }

        //Apple Stock - Interview Cake
        public static int AppleStock(int[] prices)
        {
            int minPrice = prices[0];
            int maxProfit = prices[1] - prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                int currentPrice = prices[i];
                
                int potentialProfit = currentPrice - minPrice;
                
                maxProfit = Math.Max(potentialProfit, maxProfit);

                minPrice = Math.Min(minPrice, currentPrice);
            }
            return maxProfit;
        }

        //Valid Palindrome II - Leet 680
        public static bool ValidPalindrome(string str1)
        {
            int count = 0;
            int i = 0;
            int j = str1.Length - 1;
            while (i < j)
            {
                if (!char.IsLetterOrDigit(str1[i]))
                {
                    i++;
                    count++;
                }
                else if (!char.IsLetterOrDigit(str1[j]))
                {
                    j--;
                    count++;
                }

            }

            if (count >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Valid Parenthesis
        public static bool IsValid(string str1)
        {
            char[] arr1 = str1.ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (char c in arr1)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                } else if (c == ')' && stack != null && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack != null && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack != null && stack.Peek() == '[')
                {
                    stack.Pop();
                } else
                {
                    return false;
                }
            }
            return stack != null;
        }

        //Reverse Place of Words - Interview Cake
        public static void ReverseWords(char[] message)
        {
            ReverseAll(message, 0, message.Length - 1);

            int startOfCurrentWord = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (i == message.Length || message[i] == ' ')
                {
                    ReverseAll(message, startOfCurrentWord, i - 1);
                    startOfCurrentWord = i + 1;
                }
                
            }
        }
        public static void ReverseAll(char[] message, int left, int right)
        {
            while (left < right)
            {
                char temp = message[left];
                message[left++] = message[right];
                message[right--] = temp;
            }
        }

        //Remove Duplicates from Sorted Array - Leet 26
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length < 1)
                return 0;

            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                }

                nums[i] = nums[j];
            }

            return i + 1;
        }

        //Count Primes - Leet 204
        public static int CountPrime(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            return count;
        }
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Square Sorted Array - Leet 977
        public static int[] SquareSortedArray(int[] nums)
        {
            int[] result = new int[nums.Length];
            int start = 0;
            int end = nums.Length - 1;
            for (int index = nums.Length - 1; index >= 0; index--)
            {
                int s = Math.Abs(nums[start]);
                int e = Math.Abs(nums[end]);
                if (s > e)
                {
                    result[index] = s * s;
                } else
                {
                    result[index] = e * e;
                }
            }
            return result;
        }


    }
}