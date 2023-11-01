using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Form1 : Form
    {

        bool optState = false;
        double result = 0;
        String opt = ""; 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {  

        }

        private void numbers_issues(object sender, EventArgs e) { 
            if ( outputText.Text == "0"  || optState)
            {
                outputText.Clear();
            }
            optState = false;
            Button btn = (Button) sender;
            outputText.Text += btn.Text;

        

        }

        private void opt_click(object sender, EventArgs e)
        {
            if (outputText.TextLength == 0)
            {
                MessageBox.Show("Lütfen hesaplanacak değerleri giriniz.");
            }
            else
            {
                optState = true;
                Button btn = (Button)sender;
                String newOpt = btn.Text;
                labelResult.Text = labelResult.Text + " " + newOpt + " " + outputText.Text;
                switch (opt)
                {
                    case "+": outputText.Text = (result + Double.Parse(outputText.Text)).ToString(); break;
                    case "-": outputText.Text = (result - Double.Parse(outputText.Text)).ToString(); break;
                    case "*": outputText.Text = (result * Double.Parse(outputText.Text)).ToString(); break;
                    case "%": outputText.Text = (result / Double.Parse(outputText.Text)).ToString(); break;
                }

                result = Double.Parse(outputText.Text);
                outputText.Text = result.ToString();
                opt = newOpt;
            }
        }


        private void delete_clicked(object sender, EventArgs e)
        {

            if (outputText.TextLength == 0) {
                MessageBox.Show("Lütfen hesaplanacak değerleri giriniz.");

            } else {
                Button btn = (Button)sender;
                opt = btn.Text;

                if (opt == "CE")
                {
                    outputText.Text = "0";
                }
                else if (opt == "C")
                {
                    outputText.Text = "0";
                    labelResult.Text = "0";
                    result = 0;
                }
            }



        }

        private void equal_clicked(object sender, EventArgs e)
        {
            if (outputText.TextLength == 0) {
                MessageBox.Show("Lütfen hesaplanacak değerleri giriniz.");
            } 
            
            else {
                labelResult.Text = " ";
                optState = true;
                switch (opt)
                {
                    case "+": outputText.Text = (result + Double.Parse(outputText.Text)).ToString(); break;
                    case "-": outputText.Text = (result - Double.Parse(outputText.Text)).ToString(); break;
                    case "*": outputText.Text = (result * Double.Parse(outputText.Text)).ToString(); break;
                    case "%": outputText.Text = (result / Double.Parse(outputText.Text)).ToString(); break;


                }

                result = Double.Parse(outputText.Text);
                outputText.Text = result.ToString();
                opt = " ";
            }
        }

        private void dot_clicked(object sender, EventArgs e)
        {
            

            if(outputText.Text == "0")
            {
                outputText.Text = outputText.Text;
            }
            else 
            {
                outputText.Text += ",";
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
