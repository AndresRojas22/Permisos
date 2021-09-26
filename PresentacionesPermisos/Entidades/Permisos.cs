using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        public int _id_Permiso { get; set; }
        public int _Lectura { get; set; }
        public int _Escritura { get; set; }
        public int _Eliminacion { get; set; }
        public int _Actualizacion { get; set; }
        public int _Fk_id_Usuario { get; set; }
        public Permisos(int Id_permiso, int Lectura, int Escritura, int Eliminacion, int Actualizacion,
            int Kd_Id_Usuario)
        {
            _id_Permiso = Id_permiso;
            _Lectura = Lectura;
            _Escritura = Escritura;
            _Eliminacion = Eliminacion;
            _Actualizacion = Actualizacion;
            _Fk_id_Usuario = _Fk_id_Usuario;
        }
        public Permisos()
        {

        }
    }
}
