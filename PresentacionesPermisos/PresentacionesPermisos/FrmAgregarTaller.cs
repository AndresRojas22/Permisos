using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace PresentacionesPermisos
{
    public partial class FrmAgregarTaller : Form
    {
        ManejadorTaller MT;
        public FrmAgregarTaller()
        {
            InitializeComponent();
            MT = new ManejadorTaller();
            txtCodigo.Text = FrmTaller.T._Codigo.ToString();
            txtNombre.Text = FrmTaller.T._Nombre;
            txtMedida.Text = FrmTaller.T._Medida;
            txtMarca.Text = FrmTaller.T._Marca;
            txtDescripcion.Text = FrmTaller.T._Descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmTaller.T._Codigo == 0)
            {
                MessageBox.Show(MT.GuardarTaller(new Taller(int.Parse(txtCodigo.Text), txtNombre.Text, txtMedida.Text,
                    txtMarca.Text, txtDescripcion.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(MT.ActualizarTaller(new Taller(int.Parse(txtCodigo.Text), txtNombre.Text, txtMedida.Text,
                    txtMarca.Text, txtDescripcion.Text)));
                Close();
            }
        }
    }
}
