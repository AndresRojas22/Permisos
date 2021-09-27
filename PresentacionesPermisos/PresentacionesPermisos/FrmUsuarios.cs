using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace PresentacionesPermisos
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuario MU;
        ManejadorPermisos MP;
        public static Usuario U;
        public static Permisos P;
        public FrmUsuarios()
        {
            InitializeComponent();
            MU = new ManejadorUsuario();
            MP = new ManejadorPermisos();
            U = new Usuario();
            P = new Permisos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            U._id = 0;
            U._Nombre = "";
            U._Contrasenia = "";
            U._ApellidoP = "";
            U._ApellidoM = "";
            U._F_Nacimiento = "";
            U._RFC = "";

            P._Lectura = 0;
            P._Eliminacion = 0;
            P._Actualizacion = 0;
            FrmAddU AU = new FrmAddU();
            AU.ShowDialog();
            Mostrar();
        }
        void Mostrar()
        {
            MU.MostrarUsuarios(dtgUsuarios, txtNombre.Text);
            MP.MostrarPermiso(dtgPermisos, txtNombre.Text);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgUsuarios.RowCount > 0)
            {
                string r = MP.EliminarPermiso(P);
                r = MU.EliminarUsuarios(U);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show("Se debe de elegir un registro");
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
            FrmAddU AU = new FrmAddU();
            AU.ShowDialog();
            Mostrar();
        }

        private void dtgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            U._id = int.Parse(dtgUsuarios.Rows[i].Cells[0].Value.ToString());
            U._Nombre = dtgUsuarios.Rows[i].Cells[1].Value.ToString();
            U._Contrasenia = dtgUsuarios.Rows[i].Cells[2].Value.ToString();
            U._ApellidoP = dtgUsuarios.Rows[i].Cells[3].Value.ToString();
            U._ApellidoM = dtgUsuarios.Rows[i].Cells[4].Value.ToString();
            U._F_Nacimiento = dtgUsuarios.Rows[i].Cells[5].Value.ToString();
            U._RFC = dtgUsuarios.Rows[i].Cells[0].Value.ToString();
        }

        private void dtgPermisos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            P._Lectura = int.Parse(dtgPermisos.Rows[i].Cells[1].Value.ToString());
            P._Escritura = int.Parse(dtgPermisos.Rows[i].Cells[2].Value.ToString());
            P._Eliminacion = int.Parse(dtgPermisos.Rows[i].Cells[3].Value.ToString());
            P._Actualizacion = int.Parse(dtgPermisos.Rows[i].Cells[4].Value.ToString());
            P._Fk_id_Usuario = int.Parse(dtgPermisos.Rows[i].Cells[5].Value.ToString());
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
