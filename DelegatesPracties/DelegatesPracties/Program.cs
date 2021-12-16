using System;
using System.Collections.Generic;

namespace DelegatesPracties
{
   
    class Program
    {
        static void Main(string[] args )
        {
            //Console.WriteLine(SumOdd(4, 1, 9, 12, 32, 98, 14, 65, 17));
            //Console.WriteLine(SumEven(4, 1, 9, 12, 32, 98, 14, 65, 17));
            //Console.WriteLine(Sum(CheckOdd, 2, 5, 3, 7, 12, 34, 52, 75, 13));
            //Console.WriteLine(Sum(CheckEven, 2, 5, 3, 7, 12, 34, 52, 75, 13));
            //Console.WriteLine(Sum(CheckFive, 2, 5, 3, 7, 12, 34, 52, 75, 13));
            //ChangeWords words = new ChangeWords(StringToUpper);
            //words += delegate (string s)
            //{
            //    Console.WriteLine(s.ToLower());
            //};
            //words.Invoke("rovsen");
            List<int> nums = new List<int> { 6, 7, 9, 12, 43, 13 };
            var list = nums.FindAll(m => m > 5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            

        }
        #region Int Delegate
        //public delegate bool Check(int num);


        public static bool CheckOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool CheckEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool CheckFive(int num)
        {
            return num > 5;
        }


        public static int Sum(Predicate<int> func, params int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (func(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
        public static int SumEven(params int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
        public static int SumFive(params int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (item > 5)
                {
                    sum += item;
                }
            }
            return sum;
        }
        #endregion
        #region String Delegate
        public delegate void ChangeWords(string str);
        public static void StringToUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public static void StringToLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
        #endregion
        

    }
}
