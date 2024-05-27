using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLedoTP2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();

            objUsuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (objUsuario.estadoConexion == "Usuario EXISTE")
            {
                frmMenu frmMenu = new frmMenu();    
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario y Contraseñas no coninciden");
                objUsuario.RegistroLogInicioSesion();
            }
        }


    }
}
