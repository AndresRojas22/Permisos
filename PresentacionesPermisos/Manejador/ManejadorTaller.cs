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
    public class ManejadorTaller
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        public string GuardarTaller(Taller t)
        {
            return b.Comando(string.Format("insert into Refacciones values({0},'{1}','{2}','{3}','{4}')",
                t._Codigo,t._Nombre,t._Medida,t._Marca,t._Descripcion));
        }
        public void MostrarTaller(DataGridView dtg, string dato)
        {
            dtg.DataSource = b.Mostrar(string.Format("select * from taller where codigo_herramienta like '%{0}%' or Nombre like '%{0}%' ", dato), "Refacciones").Tables["Refacciones"];
            dtg.AutoResizeColumns();
        }
        public string EliminarTaller(Taller t)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro que desea eliminar: " + t._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from refacciones where codigo_barras = {0}", t._Codigo));
            }
            return r;
        }
        public string ActualizarTaller(Taller t)
        {
            return b.Comando(string.Format("update taller set Codigo_herramienta = {0},Nombre = '{1}', Medida= '{2}', Marca = '{3}',Descripcion = '{4}'"
                , t._Codigo,t._Nombre,t._Medida,t._Marca,t._Descripcion));
        }
    }
}
