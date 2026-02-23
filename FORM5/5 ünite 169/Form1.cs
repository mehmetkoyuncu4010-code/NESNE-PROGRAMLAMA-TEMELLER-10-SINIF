using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_ünite_169
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                textBox4.Clear();

                decimal toplam = 0;

                textBox4.AppendText("===== SİPARİŞ DETAYI =====" + Environment.NewLine);
                textBox4.AppendText(Environment.NewLine);

                
                if (numericUpDown1.Value > 0)
                {
                    decimal tutar = numericUpDown1.Value * 12;
                    toplam += tutar;

                    textBox4.AppendText("Çorba - ");
                    textBox4.AppendText(numericUpDown1.Value + " adet - ");
                    textBox4.AppendText(tutar.ToString("C"));
                    textBox4.AppendText(Environment.NewLine);
                }

                
                if (numericUpDown2.Value > 0)
                {
                    decimal tutar = numericUpDown2.Value * 6;
                    toplam += tutar;

                    textBox4.AppendText("Salata - ");
                    textBox4.AppendText(numericUpDown2.Value + " adet - ");
                    textBox4.AppendText(tutar.ToString("C"));
                    textBox4.AppendText(Environment.NewLine);
                }

                
                if (numericUpDown3.Value > 0)
                {
                    decimal tutar = numericUpDown3.Value * 30;
                    toplam += tutar;

                    textBox4.AppendText("Ana Yemek - ");
                    textBox4.AppendText(numericUpDown3.Value + " adet - ");
                    textBox4.AppendText(tutar.ToString("C"));
                    textBox4.AppendText(Environment.NewLine);
                }

                
                if (numericUpDown4.Value > 0)
                {
                    decimal tutar = numericUpDown4.Value * 7;
                    toplam += tutar;

                    textBox4.AppendText("Tatlı - ");
                    textBox4.AppendText(numericUpDown4.Value + " adet - ");
                    textBox4.AppendText(tutar.ToString("C"));
                    textBox4.AppendText(Environment.NewLine);
                }

                textBox4.AppendText("-------------------------" + Environment.NewLine);
                textBox4.AppendText("TOPLAM: " + toplam.ToString("C"));
            }
        }
    }
}


