using System;
using System.Windows.Forms;
using Manejador;
using Entidades;

namespace PresentacionesPermisos
{
    public partial class FrmAddU : Form
    {
        ManejadorUsuario MU;
        public static string Usuario;
        public FrmAddU()
        {
            InitializeComponent();
            MU = new ManejadorUsuario();
            if (FrmUsuarios.U._id!=0)
            {
                txtid.Text = FrmUsuarios.U._id.ToString();
                txtNombre.Text = FrmUsuarios.U._Nombre;
                txtPswd.Text = FrmUsuarios.U._Contrasenia;
                txtApellidoP.Text = FrmUsuarios.U._ApellidoP;
                txtApellidoM.Text = FrmUsuarios.U._ApellidoM;
                txtNacimiento.Text = FrmUsuarios.U._F_Nacimiento;
                txtRFC.Text = FrmUsuarios.U._RFC;

                cmbLectura.Text = FrmUsuarios.P._Lectura.ToString();
                cmbEscritura.Text = FrmUsuarios.P._Escritura.ToString();
                cmbEliminacion.Text = FrmUsuarios.P._Eliminacion.ToString();
                cmbActualizacion.Text = FrmUsuarios.P._Actualizacion.ToString();

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                if (FrmUsuarios.U._id == 0)
                {
                    MessageBox.Show(MU.GuardarUsuario(new Usuario(int.Parse(txtid.Text), txtNombre.Text, txtPswd.Text,
                        txtApellidoP.Text, txtApellidoM.Text, txtNacimiento.Text, txtRFC.Text,cmbPerfil.Text),
                        new Permisos(int.Parse(cmbLectura.Text), int.Parse(cmbEscritura.Text), int.Parse(cmbEliminacion.Text),
                        int.Parse(cmbActualizacion.Text), int.Parse(txtid.Text))));
                    Close();
                }
            
            else
            {
                MessageBox.Show(MU.ActualizarUsuarios(new Usuario(int.Parse(txtid.Text), txtNombre.Text, txtPswd.Text,
                    txtApellidoP.Text, txtApellidoM.Text, txtNacimiento.Text, txtRFC.Text,cmbPerfil.Text),
                    new Permisos(int.Parse(cmbLectura.Text), int.Parse(cmbEscritura.Text), int.Parse(cmbEliminacion.Text),
                    int.Parse(cmbActualizacion.Text), int.Parse(txtid.Text))));
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPerfil_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPerfil.Text == "Vendedor (Refacción)")
            {
                cmbLectura.Text = 1.ToString();
                cmbEscritura.Text = 1.ToString();
                cmbEliminacion.Text = 0.ToString();
                cmbActualizacion.Text = 0.ToString();
            }
            if (cmbPerfil.Text == "Vendedor (Taller)")
            {
                cmbLectura.Text = 1.ToString();
                cmbEscritura.Text = 1.ToString();
                cmbEliminacion.Text = 0.ToString();
                cmbActualizacion.Text = 0.ToString();

            }
            if (cmbPerfil.Text == "Vendedor (Taller)")
            {
                cmbLectura.Text = 1.ToString();
                cmbEscritura.Text = 1.ToString();
                cmbEliminacion.Text = 0.ToString();
                cmbActualizacion.Text = 0.ToString();

            }
        }
    }
}
