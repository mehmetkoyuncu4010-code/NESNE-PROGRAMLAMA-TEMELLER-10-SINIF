using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syf_166_3.uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 600;
            // İşlemci fiyat hesaplaması
            decimal cpuFiyat = 0;
            if (radioButton1.Checked)
                cpuFiyat = 300;
            else if (radioButton2.Checked)
                cpuFiyat = 200;
            else if (radioButton3.Checked)
                cpuFiyat = 100;
            else if (radioButton4.Checked)
                cpuFiyat = 250;
            else if (radioButton5.Checked)
                cpuFiyat = 150;
            tabanFiyat += cpuFiyat;
            // Ram bellek fiyat hesaplaması
            decimal ramFiyat = 0;
            if (radioButton6.Checked)
                ramFiyat = 125;
            else if (radioButton7.Checked)
                ramFiyat = 75;
            else if (radioButton8.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
            decimal HDFiyat = 0;
            if (radioButton9.Checked)
                HDFiyat = 200;
            else if (radioButton10.Checked)
                HDFiyat = 155;
            else if (radioButton11.Checked)
                HDFiyat = 90;
            tabanFiyat += HDFiyat;
            decimal Donanım = 0;
            if (radioButton12.Checked)
                Donanım = 35;
            else if (radioButton13.Checked)
                Donanım = 50;
            else if (radioButton14.Checked)
                Donanım= 70;
            tabanFiyat += Donanım;
            MessageBox.Show($"Toplam Fiyat ={tabanFiyat:C}");
            if (tabanFiyat > 1200)
            {
                MessageBox.Show("Yeterli paranız yok!");
            }
            else
            {
                MessageBox.Show("Yeterli paranız var!");
            }
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
