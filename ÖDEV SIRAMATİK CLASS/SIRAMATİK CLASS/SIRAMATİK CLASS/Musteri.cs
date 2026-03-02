using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRAMATİK_CLASS
{
    public class Musteri
    {
        public int SiraNo { get; set; }

        public Musteri(int no)
        {
            SiraNo = no;
        }

        public override string ToString()
        {
            return "Sıra No: " + SiraNo;
        }
    }
}
