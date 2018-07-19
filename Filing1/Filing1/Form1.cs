using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Filing1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Filing";
            this.radioButton1.Text = "Exist";
            this.radioButton2.Text = "Delete";
            this.radioButton3.Text = "Copy";
            this.button1.Text = "OK";
            this.button2.Text = "Cancel";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if (radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
