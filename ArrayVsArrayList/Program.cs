using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            const int miliarda = 10000000;
            int[] miliardaPole = new int[miliarda];
            ArrayList miliardaAlist = new ArrayList();

            Random r = new Random();

            Stopwatch stopky = new Stopwatch();

            stopky.Start();

            for (int i = 0; i < miliardaPole.Length; i++)
            {
                miliardaPole[i] = r.Next();
            }

            stopky.Stop();

            Console.WriteLine("Naplneni pole {0}", stopky.Elapsed);

            stopky.Restart();
            
            for (int i = 0; i <= miliarda; i++)
            {
                miliardaAlist.Add(r.Next());

            }
            stopky.Stop();

            Console.WriteLine("Naplneni arraylist {0}", stopky.Elapsed);

            Console.ReadLine();
        }
    }
}
