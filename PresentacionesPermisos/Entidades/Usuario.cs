using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int _id { get; set; }
        public string _Nombre { get; set; }
        public string _Contrasenia { get; set; }
        public string _ApellidoP { get; set; }
        public string _ApellidoM { get; set; }
        public string _F_Nacimiento { get; set; }
        public string _RFC { get; set; }
        public Usuario(int id, string Nombre, string Contrasenia, string ApellidoP,string ApellidoM,
            string F_Nacimiento, string RFC)
        {
            _id = id;
            _Nombre = Nombre;
            _Contrasenia = Contrasenia;
            _ApellidoP = ApellidoP;
            _ApellidoM = ApellidoM;
            _F_Nacimiento = F_Nacimiento;
            _RFC = RFC;
        }
        public Usuario()
        {

        }
    }
}
