using System;
using System.Collections.Generic;

namespace ReverseArrayAfterInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

             
            int[] items = { 1, 2, 3,4 };

            List<int> arr = InsertArray(items);

            //for(int i =0; i< arr.Count;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            Console.WriteLine(string.Join(",", arr));
            Console.ReadLine();
        }
        public static List<int> InsertArray(int[] items)
        {
            List<int> arr1 = new List<int>();
            for(int i=0; i<items.Length;i++)
            {
                arr1.Add(items[i]);
                arr1 = reverse(arr1);
            }
            return arr1;
        }
        public static List<int> reverse(List<int> arr1)
        {
            List<int> arr2 = new List<int>();
            for(int i = arr1.Count-1; i>=0;i--)
            {
                arr2.Add(arr1[i]);
            }
            return arr2;
        }
        
    }
}
