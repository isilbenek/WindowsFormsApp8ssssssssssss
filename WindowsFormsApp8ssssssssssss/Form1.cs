using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8ssssssssssss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void eşAnlamClick(object sender, EventArgs e)
        {

        }

        private void eşSesliClick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void ayarlarClick(object sender, EventArgs e)
        {
            Form f3  =new Form3();
            f3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }
    }

   
    }

