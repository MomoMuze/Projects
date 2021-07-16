using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infSis.Model
{
    public class Tipe
    {   
        public int Id { get; set; }
        public string tipe { get; set; }
        public double min1 { get; set; }
        public double max1 { get; set; }
        public double min2 { get; set; }
        public double max2 { get; set; }
        public double minOt { get; set; }
        public double maxOt { get; set; }

        public virtual ICollection<Dann> DannTipe { get; set; }
        public Tipe()
        {
            DannTipe = new List<Dann>();
        }

        public override string ToString()
        {
            return tipe;
        }
    }
}
