using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace PresentacionesPermisos
{
    public partial class FrmRefacciones : Form
    {
        ManejadorRefacciones MR;
        public static Refaccion R;
        public FrmRefacciones()
        {
            InitializeComponent();
            MR = new ManejadorRefacciones();
            R = new Refaccion();
            if (FrmUsuarios.P._Eliminacion == 1)
            {
                btnElimnar.Enabled = true;
            }
            else
            {
                btnElimnar.Enabled = false;
            }

            if (FrmUsuarios.P._Actualizacion == 1)
            {
                btnEditar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
            }
            if (FrmUsuarios.P._Escritura == 1)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            R._Codigo_Barras = 0;
            R._Nombre = "";
            R._Marca = "";
            R._Descripcion = "";

            FrmAgregarRefaccion AR = new FrmAgregarRefaccion();
            AR.ShowDialog();
        }

        private void btnElimnar_Click(object sender, EventArgs e)
        {
            if (dtgRefaccion.RowCount > 0)
            {
                string r = MR.EliminarRefaccion(R);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show("Se debe elegir un registro");
                    Mostrar();
                }
                else
                {
                    MessageBox.Show(r);
                    Mostrar();
                }
            }
        }
        void Mostrar()
        {
            if (FrmUsuarios.P._Lectura==1)
            {
                MR.MostrarRefaccion(dtgRefaccion, txtNombre.Text);
            }
            else
            {
                MessageBox.Show("No cuenta con permisos de lectura");
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAgregarRefaccion FA = new FrmAgregarRefaccion();
            FA.ShowDialog();
        }

        private void dtgRefaccion_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            R._Codigo_Barras = int.Parse(dtgRefaccion.Rows[i].Cells[0].Value.ToString());
            R._Nombre = dtgRefaccion.Rows[i].Cells[1].Value.ToString();
            R._Descripcion = dtgRefaccion.Rows[i].Cells[2].Value.ToString();
            R._Marca = dtgRefaccion.Rows[i].Cells[3].Value.ToString();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void FrmRefacciones_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
