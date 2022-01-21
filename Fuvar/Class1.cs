using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Class1
    {
        public int azonosito { get; set; }
        public DateTime indulás { get; set; }
        public int ut_ideje { get; set; }
        public double megtett_táv { get; set; }
        public double viteldij { get; set; }
        public double borravalo { get; set; }
        public string fizetésimoed { get; set; }

        public Class1(string sor)
        {
            string[] t = sor.Split(';');
            azonosito = int.Parse(t[0]);
            indulás = DateTime.Parse(t[1]);
            ut_ideje = int.Parse(t[2]);
            megtett_táv = double.Parse(t[3]);
            viteldij = double.Parse(t[4]);
            borravalo = double.Parse(t[5]);
            fizetésimoed = t[6];
        }
    }
}
