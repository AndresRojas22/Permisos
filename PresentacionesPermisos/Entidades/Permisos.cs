namespace Entidades
{
    public class Permisos
    {
        public int _Lectura { get; set; }
        public int _Escritura { get; set; }
        public int _Eliminacion { get; set; }
        public int _Actualizacion { get; set; }
        public int _Fk_id_Usuario { get; set; }
        public Permisos(int Lectura, int Escritura, int Eliminacion, int Actualizacion,
            int FK_Id_Usuario)
        {
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
