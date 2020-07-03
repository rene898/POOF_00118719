using System;
using System.Windows.Forms;

namespace POOParcialFinal
{
    public partial class Vigilante : Form
    {
        public Vigilante()
        {
            InitializeComponent();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}