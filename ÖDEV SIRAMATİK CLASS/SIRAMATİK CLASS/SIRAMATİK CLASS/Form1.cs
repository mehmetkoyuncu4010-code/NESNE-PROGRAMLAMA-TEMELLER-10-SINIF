using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIRAMATİK_CLASS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SiraYonetici yonetici = new SiraYonetici();
        public TextBox txtCagrilan;
        int m1Sayac = 0;
        int m2Sayac = 0;
        int m3Sayac = 0;
        int m4Sayac = 0;
        int m5Sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Musteri m = yonetici.SiraAl();
            listBox1.Items.Add(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri cagrilan = yonetici.Cagir();

            if (cagrilan != null)
            {
                listBox1.Items.RemoveAt(0);

                m1Sayac++;
                listBox2.Items.Add("M1 → " + m1Sayac);
                textBox1.Text = m1Sayac.ToString();
            }
            else
            {
                MessageBox.Show("Kuyrukta müşteri yok!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri cagrilan = yonetici.Cagir();

            if (cagrilan != null)
            {
                listBox1.Items.RemoveAt(0);

                m2Sayac++;
                listBox2.Items.Add("M2 → " + m2Sayac);
                textBox2.Text = m2Sayac.ToString();
            }
            else
            {
                MessageBox.Show("Kuyrukta müşteri yok!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteri cagrilan = yonetici.Cagir();

            if (cagrilan != null)
            {
                listBox1.Items.RemoveAt(0);

                m3Sayac++;
                listBox2.Items.Add("M3 → " + m3Sayac);
                textBox3.Text = m3Sayac.ToString();
            }
            else
            {
                MessageBox.Show("Kuyrukta müşteri yok!");
            }
        }  
        

        private void button5_Click(object sender, EventArgs e)
        {
            Musteri cagrilan = yonetici.Cagir();

            if (cagrilan != null)
            {
                listBox1.Items.RemoveAt(0);

                m4Sayac++;
                listBox2.Items.Add("M4 → " + m4Sayac);
                textBox4.Text = m4Sayac.ToString();
            }
            else
            {
                MessageBox.Show("Kuyrukta müşteri yok!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Musteri cagrilan = yonetici.Cagir();

            if (cagrilan != null)
            {
                listBox1.Items.RemoveAt(0);

                m5Sayac++;
                listBox2.Items.Add("M5 → " + m5Sayac);
                textBox5.Text = m5Sayac.ToString();
            }
            else
            {
                MessageBox.Show("Kuyrukta müşteri yok!");
            }
        }
    }
        
    }
    


