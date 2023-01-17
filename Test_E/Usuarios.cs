using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_E
{
    public class Usuarios
    {
        // Variables para el registro de usuarios
        int id, id_tipo;
        String _usuario, _password, _conPassword, _nombre;

        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Password { get => _password; set => _password = value; }
        public string ConPassword { get => _conPassword; set => _conPassword = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }

        // Variables para el registro de Alumnos
        static string nombreA, carrera, semestre, tipoExamen, idA;

        public static string IdA { get => idA; set => idA = value; }
        public static string NombreA { get => nombreA; set => nombreA = value; }
        public static string Carrera { get => carrera; set => carrera = value; }
        public static string Semestre { get => semestre; set => semestre = value; }
        public static string TipoExamen { get => tipoExamen; set => tipoExamen = value; }
    }
}
