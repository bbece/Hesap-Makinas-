using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            string enteredText = nameBox.Text;

            foreach (char character in enteredText)
            {
                if (!char.IsLetter(character))
                    MessageBox.Show("Lütfen sadece harf içeren bir isim giriniz. Tekrar deneyin.");
                nameBox.Text = "";
                break;
            }
        } 

        private void surNameBox_TextChanged(object sender, EventArgs e)
        {
            string enteredText = surNameBox.Text;

            
            foreach (char character in enteredText)
            {
                if (!char.IsLetter(character)) 
                {
                    MessageBox.Show("Lütfen sadece harf içeren bir isim giriniz. Tekrar deneyin.");
                    surNameBox.Text = ""; 
                    break; 
                }
            }

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailBox_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (Regex.IsMatch(email, pattern))
            {
                  return true;
            }
            else
            {
                return false;
            }
        }

        private void ageBox_Leave(object sender, EventArgs e)
        {
            string enteredText = ageBox.Text;

            foreach (char character in enteredText)
            {
                if (!char.IsDigit(character))
                {
                    MessageBox.Show("Lütfen sadece rakam içeren bir yaş giriniz. Tekrar deneyin.");
                    ageBox.Text = "";
                    ageBox.Focus(); 
                    break;
                }
            }
        }

        private void mailBox_Leave(object sender, EventArgs e)
        {
            string enteredEmail = mailBox.Text;

            if (!IsEmailValid(enteredEmail))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.");
                mailBox.Text = "";
                mailBox.Focus(); 
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string enteredEmail = mailBox.Text;

            if (IsEmailValid(enteredEmail))
            {
                
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide(); // Şu anki formu gizler
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.");
            }
        }
    }
}

