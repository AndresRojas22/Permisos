using System;
using System.Windows.Forms;
using Manejador;
using Entidades;

namespace PresentacionesPermisos
{
    public partial class FrmLogin : Form
    {
        ManejadorUsuario MC;
        Usuario U;
        public static string Usu;
        public FrmLogin()
        {
            InitializeComponent();
            MC = new ManejadorUsuario();
            U = new Usuario();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            U._id = int.Parse(txtNombre.Text);
            U._Contrasenia = txtContrasena.Text;
            if (MC.ExisteUsuario(U))
            {

                FrmPrincipal P = new FrmPrincipal();
                P.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUsuarios FU = new FrmUsuarios();
            FU.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
