using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormMain mainmenu = new FormMain();
            // mainmenu.ShowDialog();
            // this.Close();

            Test2 sample = new Test2();
             sample.ShowDialog();
           // OpenForm(new Test());


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
