using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobüsRezarvasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" İstikamet : " + comboBox1.Text + 
                " - " + comboBox2.Text + " Koltuk No : " + comboBox3.Text +  " Yolcu Sayısı : " +comboBox4.Text +" Tarih: " + dateTimePicker1.Text + " Saat :" + maskedTextBox1.Text + " Yolcu Bilgileri ~ ; Ad :" + textBox1.Text + " Soyad :" + textBox2.Text +  " TC Kimlik : " + maskedTextBox2.Text + " Telefon :" + maskedTextBox3.Text);
            MessageBox.Show("Kaydınız Tamamlanmıştır. İyi Yolculular Dileriz...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label11.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
