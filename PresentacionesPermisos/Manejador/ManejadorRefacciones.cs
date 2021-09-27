using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejadorRefacciones
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        public string GuardarRefaccion(Refaccion r)
        {
            return b.Comando(string.Format("insert into Refacciones values({0},'{1}','{2}','{3}')",
                r._Codigo_Barras,r._Nombre,r._Descripcion,r._Marca));
        }
        public void MostrarRefaccion(DataGridView dtg, string dato)
        {
            dtg.DataSource = b.Mostrar(string.Format("select * from refacciones where codigo_barras like '%{0}%' or Nombre like '%{0}%' ", dato), "Refacciones").Tables["Refacciones"];
            dtg.AutoResizeColumns();
        }
        public string EliminarRefaccion(Refaccion re)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro que desea eliminar: " + re._Nombre , "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from refacciones where codigo_barras = {0}", re._Codigo_Barras));
            }
            return r;
        }
        public string ActualizarRefaccion(Refaccion re)
        {
            return b.Comando(string.Format("update refacciones set Codigo_barras = {0},Nombre = '{1}', Descripcion= '{2}', Marca = '{3}'"
                , re._Codigo_Barras,re._Nombre,re._Descripcion,re._Marca));
        }
    }
}
