using System;
using System.Windows.Forms;

namespace POOParcialFinal
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("SELECT FROM USUARIO WHERE   ");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}