using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infSis.Model
{
    public class Dann
    {
      

        public int Id { get; set; }
        public int? TipeId { get; set; }
        public virtual Tipe Tipe { get; set; }
        public string sn { get; set; }
        public double ep1 { get; set; }
        public double ep2 { get; set; }
        public double fp1 { get; set; }
        public double pr1 { get; set; }
        public double pr2 { get; set; }
        public double fp2 { get; set; }
        public DateTime dateProv { get; set; }
        public DateTime datePos { get; set; }
        public double result { get; set; }
        public string resh { get; set; }
    }
}
