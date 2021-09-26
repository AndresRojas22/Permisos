using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Refaccion
    {
        public int _Codigo_Barras { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion { get; set; }
        public string _Marca { get; set; }
        public Refaccion(int Codigo_Barras, string Nombre, string Descripcion, string Marca)
        {
            _Codigo_Barras = Codigo_Barras;
            _Nombre = Nombre;
            _Descripcion = Descripcion;
            _Marca = Marca;
        }
        public Refaccion()
        {

        }
    }
}
