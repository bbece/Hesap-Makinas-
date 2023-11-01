using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string enteredText = nameTextBox.Text;

            // Girilen metni kontrol etmek için bir döngü kullanabilirsiniz
            foreach (char character in enteredText)
            {
                if (!char.IsLetter(character)) // Eğer harf dışında bir karakter bulunursa
                {
                    MessageBox.Show("Lütfen sadece harf içeren bir isim giriniz. Tekrar deneyin.");
                    nameTextBox.Text = ""; // TextBox'u temizle
                    break; // Döngüyü sonlandır
                }
            }

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            string enteredText = surnameTextBox.Text;

            // Girilen metni kontrol etmek için bir döngü kullanabilirsiniz
            foreach (char character in enteredText)
            {
                if (!char.IsLetter(character)) // Eğer harf dışında bir karakter bulunursa
                {
                    MessageBox.Show("Lütfen sadece harf içeren bir isim giriniz. Tekrar deneyin.");
                    surnameTextBox.Text = ""; // TextBox'u temizle
                    break; // Döngüyü sonlandır
                }
            }

        }

        private void agetextBox_TextChanged(object sender, EventArgs e)
        {
            string enteredText = agetextBox.Text;

            foreach (char character in enteredText)
            {
                if (!char.IsDigit(character)) 
                {
                    MessageBox.Show("Lütfen sadece rakam içeren bir isim giriniz. Tekrar deneyin.");
                    agetextBox.Text = "";
                    break; 
                }
            }

        }


        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string enteredEmail = emailTextBox.Text;

            if (!IsEmailValid(enteredEmail))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.");
                emailTextBox.Text = "";
            }
        }


    }
}
