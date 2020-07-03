using System;
using System.Collections.Generic;
using System.Data;
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
                string sql = "SELECT FROM USUARIO WHERE Nombre = @Nombre AND Contraseña = @Contraseña ";

                DataTable dt = Connection.realizarAccion(sql);
                
                List<userDAO> lista = new List<userDAO>();
                foreach (DataRow fila in dt.Rows)
                {
                    user u = new user();
                    u.username = fila[0].ToString();
                    u.password = fila[1].ToString();
                        lista.Add(u);
                }
                return lista;
            }
            
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}