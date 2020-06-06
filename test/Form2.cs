using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (checkBox1.Checked == true && checkBox2.Checked ==true)
            {
                points = points + 1;
            }
            if (radioButton3.Checked == true )
            {
                points = points + 1;
            }
            if (radioButton6.Checked == true )
            {
                points = points + 1;
            }
            label4.Text = "Количество набранных баллов : " + Convert.ToString(points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
