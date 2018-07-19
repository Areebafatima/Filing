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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text + comboBox1.Text;
            string d = textBox3.Text + textBox4.Text + comboBox1.Text;

            if (File.Exists(d))
            {
              DialogResult dr =  MessageBox.Show("File is already exist do you want to replace ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
              if (dr == DialogResult.Yes)
              {
                  File.Delete(d);
                  File.Copy(s, d);
              }
            
               // File.Copy(s, d);
               //MessageBox.Show("File Copied !");
            }
            else
            {
                if (!File.Exists(s))
                {
                    MessageBox.Show("File not found");
                }
                else
                {
                    File.Copy(s, d);
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            this.Text = "File Copy";
            this.label1.Text = "F.Address : ";
            this.label2.Text = "F.Name : ";
            this.label3.Text = "Destination F.Address : ";
            this.label4.Text = "Destination F.Name :";
            this.label5.Text = "Extension : ";
            this.button1.Text = "Copy";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
            string[] ext = {".txt",".pdf",".doc" };
            textBox4.ReadOnly = true;
            comboBox1.Items.AddRange(ext);

           //this.textBox1.Text = "D:\\Address of Source File";
            //this.textBox2.Text = "Name of Source File.txt"; 
            //this.textBox3.Text = "D:\\Address of Destination File";
            //this.textBox4.Text = "Name of Destination File.txt";
            //this.textBox1.ForeColor = Color.Gray;
            //this.textBox2.ForeColor = Color.Gray;
            //this.textBox3.ForeColor = Color.Gray;
            //this.textBox4.ForeColor = Color.Gray;


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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox2.Text;
        }
    }
}
