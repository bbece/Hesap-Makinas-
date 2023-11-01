namespace Hesap_Makinası
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(43, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(43, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Soyad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(317, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Doğum Tarihi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(344, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Yaş";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(122, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "e-mail";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(100, 34);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 5;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // surNameBox
            // 
            this.surNameBox.Location = new System.Drawing.Point(100, 78);
            this.surNameBox.Name = "surNameBox";
            this.surNameBox.Size = new System.Drawing.Size(100, 22);
            this.surNameBox.TabIndex = 6;
            this.surNameBox.TextChanged += new System.EventHandler(this.surNameBox_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(383, 78);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 22);
            this.ageBox.TabIndex = 8;
            this.ageBox.Leave += new System.EventHandler(this.ageBox_Leave);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(179, 151);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(100, 22);
            this.mailBox.TabIndex = 9;
            this.mailBox.Leave += new System.EventHandler(this.mailBox_Leave);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button.Location = new System.Drawing.Point(204, 228);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(94, 46);
            this.button.TabIndex = 10;
            this.button.Text = "Log In";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(413, 34);
            this.dateTimePicker1.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(664, 394);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.surNameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surNameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}