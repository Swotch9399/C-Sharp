using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sayi_label_Click(object sender, EventArgs e)
        {

        }

        private void yuzde_label_Click(object sender, EventArgs e)
        {

        }

        private void sonuc_label_Click(object sender, EventArgs e)
        {

        }

        private void sayi_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yuzde_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hesapla_button_Click(object sender, EventArgs e)
        {
            int sayi, yuzde, sonuc;

            sayi = Convert.ToInt32(sayi_textBox.Text);

            yuzde = Convert.ToInt32(yuzde_textBox.Text);

            sonuc = (sayi / 100) * yuzde;

            sonuc_label.Text = "Sonuç = " + sonuc.ToString();
        }
    }
}
