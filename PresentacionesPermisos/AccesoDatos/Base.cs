using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class Base
    {
        MySqlConnection _conn;
        public Base(string Servidor, string Usuario, string Clave, string BD)
        {
            _conn = new MySqlConnection(string.Format("server={0}; user={1}; password={2}; database={3};", Servidor, Usuario, Clave, BD));
        }
        public string Comando(string q)
        {
            try
            {
                MySqlCommand c = new MySqlCommand(q, _conn);
                _conn.Open();
                c.ExecuteNonQuery();
                _conn.Close();
                return ("Operacion completa");
            }
            catch (Exception Ex)
            {
                _conn.Close();
                return Ex.Message;
            }
        }
        public DataSet Mostrar(string q, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                _conn.Open();
                da.Fill(ds, tabla);
                _conn.Close();
                return ds;
            }
            catch (Exception)
            {
                _conn.Close();
                return ds;
            }
            
        }

    }
}
