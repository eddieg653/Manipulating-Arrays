using System;

namespace SumofArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stuff = { 1, 3, 5, 7, 9, 10, 340, 200, 104, 11 };
            int[] a = { 0, 2, 4, 6, 8, 10 };
            int[] b = { 1, 3, 5, 7, 9 };
            int[] c = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };


            //Sum(stuff);
            //Avg(stuff);
            //Max(stuff);
            //Reverse(stuff);
            //Rotate(stuff, 2);
            Sort(stuff);

        }


        public static int Sum(int[] z)
        {
            int sum = 0;
            for (int i = 0; i < z.Length; i++)
            {
                sum += z[i];
            }
            return sum;
        }

        public static double Avg(int[] nums)
        {
            double avg = 0;
            foreach (double num in nums)
            {
                avg += num;
            }
            return avg / nums.Length;
            // return Sum(nums) / nums.Length;
        }

        public static int Max(int[] nums)
        {
            var maxArray = nums[0];
            foreach (var num in nums)
            {
                if (num > maxArray)
                {
                    maxArray = num;
                }
            }
            return maxArray;
            //int maxArray = nums.Max();
            //return maxArray;
        }

        public static void Reverse(int[] Reverseme)
        {
            Array.Reverse(Reverseme);
            foreach (int l in Reverseme)
            {
                Console.WriteLine(l);
            }




        }

        public static void Rotate(int[] More, int f)
        {
            for (int i = 0; i < More.Length - f; i++)
            {
                int j;
                for (int k = 0; k < More.Length - 1; k++)
                {
                    j = More[k];
                    More[k] = More[More.Length - 1];
                    More[More.Length - 1] = j;
                }
            }
            foreach (int l in More)
            {
                Console.Write($"{l},");
            }
        }

        public static void Sort(int[] mystuff)
        {
            int temp = 0;
            for (int i = 0; i < mystuff.Length - 1; i++)
            {
                for (int j = i + 1; j < mystuff.Length; j++)
                {
                    if (mystuff[i] > mystuff[j])
                    {
                        temp = mystuff[i];
                        mystuff[i] = mystuff[j];
                        mystuff[j] = temp;

                    }
                }
                foreach (var item in mystuff)
                {
                    Console.Write($"{item},");
                }
            }
        }
    }
}
