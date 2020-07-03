using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace POOParcialFinal
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expr;
            if (expr)
            {
                Form1 admin = new Form1();
                admin.Show();
            }
            else if (expr)
            {
                Vigilante vig = new Vigilante();
                vig.Show();
            }
            else
            {
                Login em = new Login();
                em.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

