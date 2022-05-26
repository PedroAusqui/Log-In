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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm1 = Owner as Form1;

            lblNombreCuenta.Text = frm1.txtNombre.Text;

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            conexion.ConnectionString = "data source=DESKTOP-LMT17IE; initial catalog=CUENTA_DB; integrated security=sspi";
            comando.CommandText = ("SELECT * FROM cuentas WHERE Nombre= '" + lblNombreCuenta.Text + "'");
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
            if(lector.Read() == true) 
            {
                lblDatosCuenta.Text = lector["Datos"].ToString();
            }
            else
            {
                MessageBox.Show("error");
            }
            
            conexion.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
