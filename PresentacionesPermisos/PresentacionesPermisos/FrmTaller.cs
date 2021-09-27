using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace PresentacionesPermisos
{
    public partial class FrmTaller : Form
    {
        
        ManejadorTaller MT;
        public static Taller T;
        public FrmTaller()
        {
            InitializeComponent();
            MT = new ManejadorTaller();
            T = new Taller();
            if (FrmUsuarios.P._Eliminacion == 1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
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
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void FrmTaller_Load(object sender, EventArgs e)
        {
            Mostrar();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            T._Codigo = 0;
            T._Nombre = "";
            T._Medida = "";
            T._Marca = "";
            T._Descripcion = "";
            FrmAgregarTaller AT = new FrmAgregarTaller();
            AT.ShowDialog();
            Mostrar();
        }
        void Mostrar()
        {
            if (FrmUsuarios.P._Lectura == 1)
            {
                MT.MostrarTaller(dtgTaller, txtNombre.Text);
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   
            if (dtgTaller.RowCount > 0)
            {
                string r = MT.EliminarTaller(T);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.P._Actualizacion == 1)
            {
                btnEditar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
            }
            FrmAgregarTaller AT = new FrmAgregarTaller();
            AT.ShowDialog();
        }

        private void dtgTaller_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            T._Codigo = int.Parse(dtgTaller.Rows[i].Cells[0].Value.ToString());
            T._Nombre = dtgTaller.Rows[i].Cells[1].Value.ToString();
            T._Medida = dtgTaller.Rows[i].Cells[2].Value.ToString();
            T._Marca = dtgTaller.Rows[i].Cells[3].Value.ToString();
            T._Descripcion = dtgTaller.Rows[i].Cells[4].Value.ToString();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
