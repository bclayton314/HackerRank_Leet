using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_7kyu
{
    class Program
    {
        static void Main(string[] args)
        {

            

        }

        public static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        public bool isValid(string str1)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str1.ToCharArray())
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                } else if (c == ')' && stack.Count != 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                } else if (c == ']' && stack.Count != 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                } else if (c == '}' && stack.Count != 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                } else
                {
                    return false;
                }
            }
            return stack.Count != 0;
        }
        

        public static bool meetingRooms(int[][] intervals)
        {
            var length = intervals.Length;
            if (length == null)
            {
                return false;
            }
            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                startTimes[i] = intervals[i][0];


                endTimes[i] = intervals[i][1];
        
            }
            
            Array.Sort(startTimes);
            Array.Sort(endTimes);

            for (int i = 0; i < startTimes.Length; i++)
            {
                if (endTimes[i] > startTimes[i + 1])
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        //Implementing a LinkedList
        public class LinkedListNode
        {
            public int value;
            public LinkedListNode next = null;
            public LinkedListNode(int value)
            {
                this.value = value;
            }
        }

        class LinkedList
        {
            int count;
            LinkedListNode head;

            public LinkedList()
            { 
                count = 0;
                head = null;
            }

            public void AddNodeToFront(int value)
            {
                LinkedListNode node = new LinkedListNode(value);
                node.next = head;
                head = node;
                count++;
            }

            public void PrintList()
            {
                LinkedListNode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.value);
                }
            }
        }

        
        public static int[] arraySquare(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == null)
                {
                    return null;
                }
                nums[i] = nums[i] * nums[i];
            }


            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j - 1] < nums[j])
                {
                    return nums;
                }

            }

        }

        //Hiding Credit Card Numbers - 7 kyu
        public static string Maskify(string cc)
        {
            char[] arr1 = cc.ToCharArray();
            for (int i = 0; i < cc.Length - 4; i++)
            {
                arr1[i] = '#';
            }
            return new String(arr1);
        }

        //Square Every Digit - 7 kyu
        public static int SquareDigits(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
            }
            return int.Parse(output);
        }
        //Integer to Int Array
        public static int[] digitArr(int n)
        {
            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length > 10 || (walk.Length) % 10 != 2)
            {
                return false;
            }
            int count = 0;
            for (int i = 0; i < walk.Length - 1; i++)
            {
                if (walk[i] == "n" || walk[i] == "w")
                {
                    count++;
                }
                if (walk[i] == "s" || walk[i] == "e")
                {
                    count--;
                }
                
            }

            return count == 0;
        }



    }
}
