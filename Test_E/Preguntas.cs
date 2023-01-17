using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_E
{
    class Preguntas
    {
        int id_s, id_t, id_a, _nivel, id_tipo_s, tipoSPA;
        string _pregutas, _res1, _res2, _res3, _res4, _resC;
        string _textos;
        Stream audios;
        public int Id_s { get => id_s; set => id_s = value; }
        public int Id_t { get => id_t; set => id_t = value; }
        public int Id_a { get => id_a; set => id_a = value; }

        public string Textos { get => _textos; set => _textos = value; }
        public Stream Audios { get => audios; set => audios = value; }
        public string name { get; set; }

        public string Pregutas { get => _pregutas; set => _pregutas = value; }
        public string Res1 { get => _res1; set => _res1 = value; }
        public string Res2 { get => _res2; set => _res2 = value; }
        public string Res3 { get => _res3; set => _res3 = value; }
        public string Res4 { get => _res4; set => _res4 = value; }
        public string ResC { get => _resC; set => _resC = value; }
        public int Nivel { get => _nivel; set => _nivel = value; }
        public int Id_tipo_s { get => id_tipo_s; set => id_tipo_s = value; }
        public int TipoSPA { get => tipoSPA; set => tipoSPA = value; }


    }
}
