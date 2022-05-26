using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogIn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            conexion.ConnectionString = "data source=DESKTOP-LMT17IE; initial catalog=CUENTA_DB; integrated security=sspi";
            SqlCommand comando = new SqlCommand(("SELECT Nombre, Contraseña FROM cuentas WHERE Nombre='" + txtNombre.Text + "' AND Contraseña='" + txtContraseña.Text +"'"), conexion);
            
            conexion.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                Form2 frm2 = new Form2();
                AddOwnedForm(frm2);
                frm2.Show();

            }
            else
            {
                MessageBox.Show("Datos Incorrectos.");
            }
            conexion.Close();
        }

        private void btnRegistrarte_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            AddOwnedForm(frm3);
            frm3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}
