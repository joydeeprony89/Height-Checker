using System;

namespace Height_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 4, 2, 1, 3 };
            Console.WriteLine(HeightChecker(arr));
            Console.WriteLine("Hello World!");
        }

        public static int HeightChecker(int[] heights)
        {
            int count = 0;
            int size = heights.Length;
            int[] temp = new int[size];

            Array.Copy(heights, temp, size);

            Array.Sort(temp);
            for(int i = 0; i< size;i++)
            {
                if (heights[i] != temp[i]) count++;
            }

            return count; 
        }
    }
}
