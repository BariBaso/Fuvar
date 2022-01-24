using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Fuvar
{
    class fuvar
    {
        static void Main(string[] args)
        {
            List<Class1> fuvarok = new List<Class1>();
            foreach (var x in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Class1(x));
            }

            //3.
            Console.WriteLine($"3. feladat: {fuvarok.Count} fuvar");
            //4.
            Console.WriteLine($"4. feladat: {fuvarok.Where(x => x.azonosito == 6185).Count()} fuvar alatt: {fuvarok.Where(x => x.azonosito == 6185).Sum(x => x.viteldij)}Ft");
            //5.
            Console.WriteLine("5. feladat:");
            Dictionary<string, int> fizetési_mod = new Dictionary<string, int>();
            foreach (var f in fuvarok)
            {
                if (fizetési_mod.ContainsKey(f.fizetésimoed))
                {
                    fizetési_mod[f.fizetésimoed]++;
                }
                else
                {
                    fizetési_mod.Add(f.fizetésimoed, 1);
                }
            }
            foreach (var x in fizetési_mod)
            {
                Console.WriteLine($"\t{x.Key}: {x.Value} fuvar");
            }
            //6.
            Console.WriteLine($"6. feladat: {fuvarok.Sum(x => x.megtett_táv)*1.6:0.00}km");
            //7.
            Class1 max = fuvarok.OrderBy(x => x.ut_ideje).Last();
            Console.WriteLine("7. feladat: Leghosszabb fuvar:");
            Console.WriteLine($"\tFuvar hossza {max.ut_ideje} másodperc");
            Console.WriteLine($"\tTaxi azonosító {max.azonosito}");
            Console.WriteLine($"\tMegtett táv {max.megtett_táv} km");
            Console.WriteLine($"\tViteldij {max.viteldij}$");

            //8.
            StreamWriter fs = new StreamWriter("hibák.txt");

            fuvarok.Where(x => x.ut_ideje > 0 && x.viteldij > 0 && x.megtett_táv == 0).OrderBy(x => x.indulás).ForEach(x => x.);

            foreach (var x in fuvarok)
            {
                if (x.ut_ideje>0 && x.viteldij>0 && x.megtett_táv == 0)
                {
                    fs.WriteLine($"{x.azonosito};{x.indulás};{x.ut_ideje};{x.megtett_táv};{x.viteldij};{x.borravalo};{x.fizetésimoed}");
                }
            }
            
            
        }
    }
}
