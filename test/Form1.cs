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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f = new Form2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        Form2 f;
        string login = "admin";
        string pswrd = "qwerty";
        
        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = textBox2.Text;
            if(log == login && pas == pswrd )
            {
                f.Show();
            }
            else
            {
                MessageBox.Show("Не верно введены данные!", "Ошибка авторизации");
            }
        }
    }
}
