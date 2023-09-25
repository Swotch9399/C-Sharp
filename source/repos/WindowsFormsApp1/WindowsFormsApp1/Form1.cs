using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Manav1 : Form
    {
        public Manav1()
        {
            InitializeComponent();
        }

        private void Manav1_Load(object sender, EventArgs e)
        {

        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaddbutton_Click(object sender, EventArgs e)
        {
            listbox.Items.Add(textbox.Text);
            MessageBox.Show("Sepete eklendi.", "Manav");
        }

        private void textboxclearbutton_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            MessageBox.Show("Kelimeler temizlendi.", "Manav");
        }

        private void listboxtextremovebutton_Click(object sender, EventArgs e)
        {
            listbox.Items.Remove(textbox.Text);
            MessageBox.Show("Yazılan temizlendi.", "Manav");
        }

        private void listboxselectremovebutton_Click(object sender, EventArgs e)
        {
            listbox.Items.Remove(listbox.SelectedItem);
            MessageBox.Show("Seçilenler temizlendi.", "Manav");
        }

        private void listboxclearbutton_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            MessageBox.Show("Sepet temizlendi.", "Manav");
        }

        private void pictureboxvisiblebutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }

        private void pictureboxnotvisiblebutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void pictureselectbutton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = pictureselectbutton1.Checked;
        }

        private void pictureselectbutton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = pictureselectbutton2.Checked;
        }

        private void pictureselectbutton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = pictureselectbutton3.Checked;
        }

        private void colorbox_Enter(object sender, EventArgs e)
        {

        }

        private void orangebutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;
            MessageBox.Show("Renk turuncu olarak değiştirildi.", "Manav");
        }

        private void redbutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            MessageBox.Show("Renk kırmızı olarak değiştirildi.", "Manav");
        }

        private void yellowbutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            MessageBox.Show("Renk sarı olarak değiştirildi.", "Manav");
        }

        private void greenbutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            MessageBox.Show("Renk yeşil olarak değiştirildi.", "Manav");
        }

        private void bluebutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
            MessageBox.Show("Renk mavi olarak değiştirildi.", "Manav");
        }

        private void blackbutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            MessageBox.Show("Renk siyah olarak değiştirildi.", "Manav");
        }

        private void whitebutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            MessageBox.Show("Renk beyaz olarak değiştirildi.", "Manav");
        }

        private void resetbox_Enter(object sender, EventArgs e)
        {

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            listbox.Items.Clear();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            this.Width = 816;
            this.Height = 489;
            this.BackColor = Color.DarkOrange;
            MessageBox.Show("Program eski haline döndürüldü.", "Manav");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }
    }
}
