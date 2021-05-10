using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
namespace Day8_EventHandlerCheckApp
{
    public partial class Mainform : Form
    {

        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logger.Info("Mainform loaded");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            var result = txtUserID.Text + "\n" + txtPW.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");
           
            try
            {
                var val = txtPW.Text.Substring(3, 2);//문자열 자르는 메소드
                MessageBox.Show($"{val}");
            }
            catch (Exception ex)
            {
                logger.Error("예외!");
                logger.Error(ex);
                MessageBox.Show("예외발생, 관리자에게 문의 요망");

            }
        }
    }
}
