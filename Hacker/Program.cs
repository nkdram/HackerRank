using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker
{


    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //namespace HackerRank
    //{

    //    class Alarm
    //    {
    //        static void Main(String[] args)
    //        {
    //            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    //            try
    //            {
    //                int T = Convert.ToInt32(Console.ReadLine());
    //                minimumFuelCells(T);

    //            }
    //            catch (Exception ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //            //Console.ReadLine();
    //        }


    //        static void minimumFuelCells(int testCases)
    //        {
    //            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //            List<testCase> testCasesList = new List<testCase>();
    //            for (int cases = 0; cases < testCases; cases++)
    //            {
    //                List<string> strWords = new List<string>();
    //                for (int i = 0; i < 3; i++)
    //                {
    //                    strWords.Add(Console.ReadLine());
    //                }
    //                testCasesList.Add(new testCase() { words = strWords });
    //            }

    //            foreach (var testCase in testCasesList)
    //            {
    //                var index = 0;
    //                foreach (var word in testCase.words)
    //                {
    //                    var missingIndices = getIndices(word);
    //                    long noOfWays = 0;
    //                    foreach (var missingIndex in missingIndices)
    //                    {
    //                        char characterBefore = 'z';
    //                        if (index == 0)
    //                        {
    //                            if (testCase.words[1].Length >= word.Length ? testCase.words[1][missingIndex].ToString() != "?" : false)
    //                                characterBefore = testCase.words[1][missingIndex];
    //                            else if(testCase.words[2].Length >= word.Length ? testCase.words[2][missingIndex].ToString() != "?" : false)
    //                                characterBefore = testCase.words[1][missingIndex];
    //                            noOfWays = alphabets.ToLower().IndexOf(characterBefore) + 1;
    //                        }

    //                        noOfWays += noOfWays;

    //                    }
    //                }
    //            }
    //        }

    //        static List<int> getIndices(string word)
    //        {
    //            var foundIndexes = new List<int>();
    //            for (int i = word.IndexOf('?'); i > -1; i = word.IndexOf('?', i + 1))
    //            {
    //                foundIndexes.Add(i);
    //            }
    //            return foundIndexes;
    //        }

    //        class testCase
    //        {
    //            public List<string> words { get; set; }
    //        }


    //    }


    //}




}
