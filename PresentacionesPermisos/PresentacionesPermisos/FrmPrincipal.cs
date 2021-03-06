using System;
using System.Windows.Forms;

namespace PresentacionesPermisos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRefacciones_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.P._Lectura ==1 || FrmUsuarios.P._Escritura ==1
                || FrmUsuarios.P._Eliminacion == 1 || FrmUsuarios.P._Actualizacion ==1)
            {
                FrmRefacciones FR = new FrmRefacciones();
                FR.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios");
            }

        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.P._Lectura == 1 || FrmUsuarios.P._Escritura == 1 || FrmUsuarios.P._Eliminacion == 1 || FrmUsuarios.P._Actualizacion == 1)
            {
                FrmTaller FT = new FrmTaller();
                FT.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
