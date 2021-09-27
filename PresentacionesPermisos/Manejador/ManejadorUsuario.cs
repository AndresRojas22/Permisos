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
    public class ManejadorUsuario
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        int i;
        public string GuardarUsuario(Usuario u, Permisos p)
        {
            return b.Comando(string.Format("insert into usuarios values({0},'{1}','{2}','{3}','{4}','{5}','{6}'); insert into Permisos values(null,{7},{8},{9},{10},{0})",
                u._id, u._Nombre, u._Contrasenia, u._ApellidoP,
                u._ApellidoM, u._F_Nacimiento, u._RFC,
                p._Lectura, p._Escritura, p._Eliminacion, p._Actualizacion, p._Fk_id_Usuario));
        }
        public void MostrarUsuarios(DataGridView dtg, string dato)
        {
            dtg.DataSource = b.Mostrar(string.Format("select * from Usuarios where Nombre like '%{0}%' or id_usuario like '%{0}%' ", dato), "Permisos").Tables["Permisos"];
            dtg.AutoResizeColumns();
        }
        public string EliminarUsuarios(Usuario u)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro que desea eliminar: " + u._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from usuarios where id_usuario = {0}", u._id));
            }
            return r;
        }
        public string ActualizarUsuarios(Usuario u, Permisos p)
        {
            return b.Comando(string.Format("update usuarios set id_Usuario={0}," +
                "Nombre = '{1}',Contraseña = '{2}', ApellidoP = '{3}', ApellidoM = '{4}',F_Nacimiento ='{5}'," +
                "RFC ='{6}';  update permisos set Lectura = {7},Escritura = {8}, Eliminacion = {9}, Actualizacion = {10},Fk_id_usuario ={0}"
                , u._id, u._Nombre, u._Contrasenia, u._ApellidoP, u._ApellidoM, u._F_Nacimiento, u._RFC, p._Lectura, p._Escritura, p._Eliminacion, p._Actualizacion, p._Fk_id_Usuario));
        }

        public bool ExisteUsuario(Usuario U)
        {
            try
            {
                string consulta = string.Format("Select count(*)from usuarios where id_usuario = '{0}' and contraseña = '{1}'", U._id, U._Contrasenia);
                var Existe = b.Existencia(consulta);
                if (Existe == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló la consulta" + ex.Message);
                return false;
            }
        }
    }
}
