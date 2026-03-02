using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRAMATİK_CLASS
{
    public class SiraYonetici
    {
        private Queue<Musteri> kuyruk = new Queue<Musteri>();
        private int sonNumara = 0;

        public Musteri SiraAl()
        {
            sonNumara++;
            Musteri m = new Musteri(sonNumara);
            kuyruk.Enqueue(m);
            return m;
        }

        public Musteri Cagir()
        {
            if (kuyruk.Count > 0)
                return kuyruk.Dequeue();
            return null;
        }

        public int BekleyenSayisi()
        {
            return kuyruk.Count;
        }
    }
}