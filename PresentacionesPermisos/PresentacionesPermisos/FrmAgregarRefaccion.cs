using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace PresentacionesPermisos
{
    public partial class FrmAgregarRefaccion : Form
    {
        ManejadorRefacciones MR;        
        public FrmAgregarRefaccion()
        {
            InitializeComponent();
            MR = new ManejadorRefacciones();

            if (FrmRefacciones.R._Codigo_Barras !=0)
            {
                idCodigo.Text = FrmRefacciones.R._Codigo_Barras.ToString();
                txtNombre.Text = FrmRefacciones.R._Nombre;
                txtDescripcion.Text = FrmRefacciones.R._Descripcion;
                txtMarca.Text = FrmRefacciones.R._Marca;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmRefacciones.R._Codigo_Barras == 0)
            {
                MessageBox.Show(MR.GuardarRefaccion(new Refaccion(int.Parse(idCodigo.Text), txtNombre.Text,
                    txtDescripcion.Text, txtMarca.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(MR.ActualizarRefaccion(new Refaccion(int.Parse(idCodigo.Text), txtNombre.Text,
                    txtDescripcion.Text, txtMarca.Text)));
                Close();
            }
        }
    }
}
