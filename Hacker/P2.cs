using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{

    class Program
    {
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    try
        //    {
        //        int T = Convert.ToInt32(Console.ReadLine());
        //        minimumFuelCells(T);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    Console.ReadLine();
        //}


        static void minimumFuelCells(int testCases)
        {
            for (int cases = 0; cases < testCases; cases++)
            {
                var alienNo = Convert.ToInt32(Console.ReadLine());
                if (alienNo < 0 && alienNo > 300)
                    throw new Exception("alienNo should be between 1 and 300");
                List<Alien> aliensLst = new List<Alien>();

                for (int i = 0; i < alienNo; i++)
                {
                    var line = Console.ReadLine();
                    aliensLst.Add(new Alien()
                    {
                        ai = Convert.ToInt32(line.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries)[0]),
                        bi = Convert.ToInt32(line.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries)[1]),
                        di = Convert.ToInt32(line.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries)[2]),
                        maxTime =
                        Convert.ToInt32(line.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries)[0])
                        + Convert.ToInt32(line.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries)[1])
                       ,
                        killed = false
                    });

                }

                int fuelCells = 0;
                while (aliensLst.Count > 0)
                {
                    aliensLst = aliensLst.OrderBy(x => x.maxTime).ToList();
                    fuelCells += calculatFuelNeeded(aliensLst, out aliensLst);
                    aliensLst.RemoveAll(x => x.killed);
                }
                Console.WriteLine(fuelCells);
            }
        }

        static int calculatFuelNeeded(List<Alien> aliens, out List<Alien> killedAliens)
        {
            int minTime = aliens[0].maxTime, maxDis = aliens[0].di;

            foreach (var alien in aliens)
            {
                if (alien.ai <= minTime)
                {
                    if (alien.di > maxDis && (alien.maxTime <= minTime || aliens.Count(x => x.maxTime <= alien.maxTime) <= 1
                        || aliens.Count(x => x.ai <= minTime) == aliens.Count))
                        maxDis = alien.di;
                    if (alien.di <= maxDis)
                        alien.killed = true;
                }
                else
                {
                    alien.ai = alien.ai - minTime;
                    alien.maxTime = alien.ai + alien.bi;
                }
            }
            killedAliens = aliens;
            return maxDis;
        }
    }

    class Alien
    {
        public int ai { get; set; }
        public int bi { get; set; }
        public int di { get; set; }
        public int maxTime { get; set; }
        public bool killed { get; set; }
    }
}
