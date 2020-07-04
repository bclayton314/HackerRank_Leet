using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prep_Work
{
    class Prep_Work
    {
        static void Main(string[] args)
        {
            ArrayList myParty = new ArrayList();
            myParty.Add(22);
            myParty.Add(11);
            myParty.Add(33);
            myParty.Add(44);
            List<int> myParty2 = new List<int>();

        }

        //Palindrone II
        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    //remove right
                    int templeft = left, tempright = right - 1;

                    while (templeft < tempright)
                    {
                        if (s[templeft] != s[tempright])
                            break;
                            templeft++; 
                            tempright--;

                        if (templeft >= tempright)
                            return true;
                    }

                    //remove left
                    left++;

                    while (left < right)
                    {
                        if (s[left] != s[right])
                            return false;
                        left++; right--;
                    }
                }
            }
            return true;
        }


        //Reverse a Linked List - Leet 206
        public static LinkedList ReverseLinkedList(LinkedList head)
        {
            LinkedList p1 = null;
            LinkedList p2 = head;
            while (p2 != null)
            {
                LinkedList p3 = p2.Next;
                p2.Next = p1;
                p1 = p2;
                p2 = p3;
            }
            return p1;
        }

        public class LinkedList
        {
            public int Value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.Value = value;
            }
        }

        public static int BinarySearch(int[] array, int target)
        {
            return BinarySearch(array, target, 0, array.Length - 1);
        }

        public static int BinarySearch(int[] array, int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int potentialMatch = array[middle];
                if (target == potentialMatch)
                {
                    return middle;
                }
                else if (target < potentialMatch)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}
