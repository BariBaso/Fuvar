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




        }
    }
}
