using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Min_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "1 3 5 7 9";
            var str2 = "256741038 623958417 467905213 714532089 938071625";

            var str3 = "1 2 3 4 5";


            List<int> arr = str3.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);
        }

        private static void miniMaxSum(List<int> arr)
        {
            if (arr.Count > 0)
            {
                long minRes = 0;
                long maxRes = 0;

                arr.Sort();
                for(int i=0;i<arr.Count;i++)
                {
                    if (i != 0)
                        maxRes += arr[i];
                    if (i != arr.Count)
                        minRes += arr[i];

                }


                Console.WriteLine($"{minRes} {maxRes}");
            }
        }
    }
}
