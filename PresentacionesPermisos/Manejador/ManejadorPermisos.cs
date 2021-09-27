using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejadorPermisos
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        public string GuardarPermiso(Permisos p)
        {
            return b.Comando(string.Format("insert into Permisos values(null,{0},{1},{2},{3},{4})",
                p._Lectura,p._Escritura,p._Eliminacion,p._Actualizacion,p._Fk_id_Usuario));
        }
        public void MostrarPermiso(DataGridView dtg, string dato)
        {
            dtg.DataSource = b.Mostrar(string.Format("select * from Permiso where id_permiso like '%{0}%' or fk_id_usuario like '%{0}%' ", dato), "Permisos").Tables["Permisos"];
            dtg.AutoResizeColumns();
        }
        public string EliminarPermiso(Permisos p)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro que desea eliminar: " + p._Fk_id_Usuario, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from Permisos where fk_id_usuario = {0}", p._Fk_id_Usuario));
            }
            return r;
        }
        public string ActualizarPermiso(Permisos p)
        {
            return b.Comando(string.Format("update permisos set Lectura = {0},Escritura = {1}, Eliminacion = {2}, Actualizacion = {3},Fk_id_usuario ={4}"
                ,p._Lectura,p._Escritura,p._Eliminacion,p._Actualizacion,p._Fk_id_Usuario));
        }
    }
}
