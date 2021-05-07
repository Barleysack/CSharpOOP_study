using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day8_EventHandlerCheckApp
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            var result = txtUserID.Text + "\n" + txtPW.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");

        }
    }
}
