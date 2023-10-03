using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eşitlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            if (sayi1 > sayi2)
            {
                MessageBox.Show("1. Sayı büyüktür 2. Sayıdan");
            }
            if (sayi2 > sayi1)
            {
                MessageBox.Show("2. Sayı büyüktür 1. Sayıdan");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayılar birbirine eşittir");
            }
        }
    }
}
