using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCode.EasyLvl
{
    class ToyProb1
    {
        static void Main(string[] args)
        {
            
        }

        //Leet 1 - Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int potentialMatch = target - nums[i];
                if (dict.ContainsKey(potentialMatch))
                {
                    result[0] = i;
                    result[1] = dict[potentialMatch];
                    return result;
                }
                dict.Add(nums[i], i);
            }
            return result;
        }

        //IsPrime
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

        //Leet 1119 - Remove Vowels from a String
        public string RemoveVowels(string str1)
        {
            HashSet<char> hash1 = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };

            StringBuilder strBuild = new StringBuilder();
            foreach (char c in str1)
            {
                if (!hash1.Contains(c))
                    strBuild.Append(c);
            }

            return strBuild.ToString();
        }

        //Leet 53 - Maximum Subarray
        public static int MaxSubarray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i - 1] + nums[i] > nums[i])
                {
                    nums[i] = nums[i - 1];
                }
            }
            return nums.Max();
        }

        //Leet 21 - Merge Two Sorted Lists
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MergeTwoSortedLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode head = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    dummy.next = l1;
                    l1 = l1.next;
                } else
                {
                    dummy.next = l2;
                    l2 = l2.next;
                }
            }

            if (l1 != null)
            {
                dummy.next = l1;
            }
            else
            {
                dummy.next = l2;
            }

            return head.next;
        }

        //Reverse String
        public static char[] reverseArray(char[] arr1)
        {
            int i = 0;
            int j = arr1.Length - 1;
            while (i < j)
            {
                char temp = arr1[i];
                arr1[i++] = arr1[j];
                arr1[j--] = temp;
            }
            return arr1;
        }

        //Decipher Code - Reverse words
        public static void ReverseWords(char[] message)
        {
            ReverseCharacters(message, 0, message.Length - 1);

            int wordIndex = 0;
            for (int i = 0; i <= message.Length; i++)
            {
                if (i == message.Length || message[i] == ' ')
                {
                    ReverseCharacters(message, wordIndex, i - 1);
                    wordIndex = i + 1;
                }
            }
        }

        public static void ReverseCharacters(char[] message, int i, int j)
        {
            
            while (i < j)
            {
                char temp = message[i];
                message[i++] = message[j];
                message[j--] = temp;
            }
        }

        //Interview Cake - Inflight entertainment system
        public static bool IsThereTime(int flightLength, int[] movieLengths)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < movieLengths.Length; i++)
            {
                int otherMovie = flightLength - movieLengths[i];
                if (hash.Contains(otherMovie))
                {
                    return true;
                }
                hash.Add(movieLengths[i]);
            }
            return false;
        }

        //Interview Cake - Palindrone Permutations
        public static bool IsPalindrone(string str1)
        {
            HashSet<char> hash = new HashSet<char>();
            
            foreach (char c in str1)
            {
                if (hash.Contains(c))
                {
                    hash.Remove(c);
                } else
                {
                    hash.Add(c);
                }
            }

            return hash.Count <= 1;
        }

    }

}
