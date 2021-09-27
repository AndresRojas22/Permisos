using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taller
    {
        public int _Codigo { get; set; }
        public string _Nombre { get; set; }
        public string _Medida { get; set; }
        public string _Marca { get; set; }
        public string _Descripcion { get; set; }
        public Taller(int Codigo, string Nombre, string Medida, string Marca, string Descripcion)
        {
            _Codigo = Codigo;
            _Nombre = Nombre;
            _Medida = Medida;
            _Marca = Marca;
            _Descripcion = Descripcion;
        }
        public Taller()
        {

        }
    }
}
