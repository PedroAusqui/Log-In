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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            conexion.ConnectionString = "data source=DESKTOP-LMT17IE; initial catalog=CUENTA_DB; integrated security=sspi";
            SqlCommand comando1 = new SqlCommand(string.Format("SELECT Nombre, Contraseña FROM cuentas WHERE Nombre='" + txtNombre.Text + "' AND Contraseña='" + txtContraseña.Text + "'"),conexion);
            conexion.Open();
            lector = comando1.ExecuteReader();
            if (lector.Read())
            {

                MessageBox.Show("ese nombre o contraseña ya esta en uso");
                conexion.Close();
            }
            else
            {
                conexion.Close();
                SqlCommand comando = new SqlCommand(string.Format(@"INSERT INTO cuentas( Nombre, Contraseña, Datos) VALUES 
                                                             ( @Nombre, @Contraseña, @Datos)"), conexion);

                conexion.Open();
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                comando.Parameters.AddWithValue("@Datos", txtDatos.Text);


                comando.ExecuteNonQuery();    

                Close();
                conexion.Close();
            }
            

        }
    }
}
