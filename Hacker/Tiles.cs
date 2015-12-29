//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hacker
//{
//    class Solution
//    {
//        static void Main(String[] args)
//        {
//            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

//            try
//            {

//                int T = Convert.ToInt32(Console.ReadLine());
//                calculatePossibilties(T);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            //Console.ReadLine();
//        }

//        static void calculatePossibilties(int testCases)
//        {
//            List<testCase> Lstcases = new List<testCase>();

//            for (int cases = 0; cases < testCases; cases++)
//            {
//                Lstcases.Add(new testCase() { testNo = Convert.ToUInt64(Console.ReadLine()) });
//            }

//            foreach (var cases in Lstcases)
//            {
//                // UInt64 numberOfWays = 1;
//                UInt64 tileLength = cases.testNo;
//                //if (cache == null)
//                //    cache = new UInt64[10000 + 1][];
//                //numberOfWays = returnNumberOfWays(tileLength, 2, 4);
//                //cases.Ways = numberOfWays;
//                if (tileLength < 10000)
//                    Console.WriteLine(numberOfWays(tileLength));
//                else
//                {
//                    var till10000 = Convert.ToUInt64(numberOfWays(10000));
//                    var ways = till10000;

//                    for (UInt64 n = 10001; n <= tileLength; n++)
//                    {
//                        ways = (values[n - 1] * 2) - (values[n - 5]);
//                        values.Remove(n - 5);
//                        values[n] = ways;
//                    }
//                    ways = ways % (1000000007);
//                    Console.WriteLine(ways.ToString());
//                }
//            }
//        }

//        static Dictionary<UInt64, UInt64> values = new Dictionary<ulong, ulong>();
//        public static string numberOfWays(UInt64 length)
//        {

//            //UInt64[] ways = new UInt64[10000000 + 1];
//            values = new Dictionary<ulong, ulong>();
//            values[0] = 1;
//            for (UInt64 n = 1; n <= length; n++)
//            {
//                //if (n >= 10000000)
//                //{
//                //    var temp = ways;
//                //    temp.ToList().RemoveAt(0);
//                //    ways = temp.ToArray();
//                //}

//                if (n <= 9)
//                for (UInt64 k = 1; k <= 4 && k <= n; k++)
//                {
//                    if (!values.Keys.Contains(n))
//                        values[n] = 0;
//                    values[n] += values[n - k];
//                }
//                else
//                    values[n] = (values[n - 1] * 2) - (values[n - 5]);

//            }


//            return (values[length] % (1000000007)).ToString();
//        }


//        //static UInt64[][] cache;
//        //static UInt64 returnNumberOfWays(long tilesLength, int startIndex, int endIndex)
//        //{

//        //    var dictIndex = Convert.ToInt32(Math.Floor(Convert.ToDecimal(tilesLength / 10000)));
//        //    UInt64 numberOfWays = 1;

//        //    if (cache[dictIndex] == null)
//        //        cache[dictIndex] = new UInt64[10000];

//        //    var index = dictIndex > 0 ? tilesLength % (10000 * dictIndex) : tilesLength;

//        //    if (cache[dictIndex][index] != 0) return cache[dictIndex][index];

//        //    if (tilesLength >= startIndex)
//        //        for (int i = startIndex; i <= endIndex; i++)
//        //        {
//        //            for (int startpos = 0; startpos <= tilesLength - i; startpos++)
//        //            {
//        //                numberOfWays += returnNumberOfWays(tilesLength - startpos - i, startIndex, endIndex);
//        //            }
//        //        }
//        //    var caseVal = new testCase()
//        //    {
//        //        Ways = numberOfWays
//        //    };

//        //    cache[dictIndex][index] = caseVal.Ways;

//        //    return caseVal.Ways;
//        //}

//        class testCase
//        {
//            public UInt64 testNo { get; set; }
//            UInt64 numberWays = 0;
//            public UInt64 Ways
//            {
//                get { return Convert.ToUInt64(numberWays % (1000000007)); }
//                set { numberWays = value; }
//            }
//        }

//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNo_C
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int st, en, cnt = 0;
        //    Console.WriteLine("Starting Value:-");
        //    st = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ending Value:-");
        //    en = int.Parse(Console.ReadLine());

        //    for (int i = st; i < en; i++)
        //    {
        //        for (int j = 2; j <= Math.Ceiling(Math.Sqrt(i)); j++)
        //        {
        //            if (i % j == 0 && i != 2)
        //            {
        //                cnt++;
        //                break;
        //            }
        //        }
        //        if (cnt == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //        cnt = 0;
        //    }
        //    Console.ReadKey();
        //}

        private static int[] a = new int[4] { 2, 8, 0, 3 };

        static void Main(string[] args)
        {

            Sort();

            foreach (int temp in a)
            {

                Console.WriteLine(temp);

            }

            Console.ReadLine();

        }

        public static void Sort()
        {

            int i, j;

            int min, temp;

            for (i = 0; i < a.Count() - 1; i++) // Loop through each element
            {

                min = i; // Assume that he is the smallest

                for (j = i + 1; j < a.Count(); j++) // Loop through the remaining element
                {

                    if (a[j] < a[min]) // If the current value smaller than the min
                    {

                        min = j; // Swap the values

                    }

                }

                temp = a[i]; // Store the current value in temp variuable

                a[i] = a[min]; // Swap the minimum  value to the current position

                a[min] = temp; // Swap the current value to the minimum value position

            }

        }
    }
}