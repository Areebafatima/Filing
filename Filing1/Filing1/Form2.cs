using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Filing1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "File Exist";
            this.label1.Text="F.Address : ";
            this.label2.Text = "F.Name : ";
            this.button1.Text="Exist";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
            this.label5.Text = "Extension : ";
            string[] ext = { ".txt", ".pdf", ".doc" };
            comboBox1.Items.AddRange(ext);
            //this.textBox1.Text = "D:\\Address of File";
            //this.textBox2.Text = "Name of File.txt";
            //this.textBox1.ForeColor= Color.Gray;
            //this.textBox2.ForeColor= Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text + comboBox1.Text;
            if (File.Exists(s))
            {
                MessageBox.Show("File Exist");
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

