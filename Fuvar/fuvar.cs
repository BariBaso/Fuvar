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
        }
    }
}
