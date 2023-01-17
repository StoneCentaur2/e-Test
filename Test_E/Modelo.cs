using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;
using System.Data;

namespace Test_E
{
    class Modelo
    {
        // COMPROBAR SI EL USUARIO NO SE REPITE
        public bool existeUsuario(string usuario)  // recibe la variable del usuario
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();                       // Se abre la conexion a la BD

            string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario"; // comando SQL
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);    // Se asigna la variable al comando
            reader = comando.ExecuteReader();                        // Se lee la linea 

            if (reader.HasRows) // Si encuentra una linea con el valor buscado
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // REGISTRAR USUARIOS EN LA BASE DE DATOS
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            // Sintaxis SQL para agregar el usuario
            string sql = "INSERT INTO `usuarios` (`usuario`, `contraseña`, `nombre`, `id_tipo`)" +
                         " VALUES( @usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Se añaden los valores en el comando SQL
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", 1);

            int resultado = comando.ExecuteNonQuery(); // Se realiza el comando y retorna numero de filas

            return resultado;
        }

        // REGISTRAR ALUMNOS EN LA BASE DE DATOS
        public int registroAlumnos()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            // Sintaxis SQL para agregar el usuario
            string sql = "INSERT INTO `alumnos` (`idAlumnos`, `nombre`, `carrera`, `semestre`, `id_tipo`)" +
                         " VALUES( @idAlumno, @nombre, @carrera, @semestre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Se añaden los valores en el comando SQL
            comando.Parameters.AddWithValue("@idAlumno", Usuarios.IdA);
            comando.Parameters.AddWithValue("@nombre", Usuarios.NombreA);
            comando.Parameters.AddWithValue("@carrera", Usuarios.Carrera);
            comando.Parameters.AddWithValue("@semestre", Usuarios.Semestre);
            comando.Parameters.AddWithValue("@id_tipo", 2);

            int resultado = comando.ExecuteNonQuery(); // Se realiza el comando
            return resultado;
        }
        // ACTUALIZAR ALUMNOS EN LA BASE DE DATOS
        public int ActualizarAlumnos()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            // Sintaxis SQL para agregar el usuario
            string sql = "UPDATE alumnos SET nombre = @nombre, carrera = @carrera, semestre = @semestre " +
                         "WHERE idAlumnos = @idAlumno";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Se añaden los valores en el comando SQL
            comando.Parameters.AddWithValue("@idAlumno", Usuarios.IdA);
            comando.Parameters.AddWithValue("@nombre", Usuarios.NombreA);
            comando.Parameters.AddWithValue("@carrera", Usuarios.Carrera);
            comando.Parameters.AddWithValue("@semestre", Usuarios.Semestre);
            comando.Parameters.AddWithValue("@id_tipo", 2);

            int resultado = comando.ExecuteNonQuery(); // Se realiza el comando
            return resultado;
        }
        // COMPROBAR SI EL USUARIO NO SE REPITE
        public bool existeAlumno(string usuario)  // recibe la variable del usuario
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();                       // Se abre la conexion a la BD

            string sql = "SELECT * FROM alumnos WHERE idAlumnos = @usuario"; // comando SQL
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);    // Se asigna la variable al comando
            reader = comando.ExecuteReader();                        // Se lee la linea 

            if (reader.HasRows) // Si encuentra una linea con el valor buscado
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // INICIO DE SESION MAESTROS
        public Usuarios Ingresar(string usuario)  // recibe la variable del usuario
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();                       // Se abre la conexion a la BD

            string sql = "SELECT id, contraseña, nombre, id_tipo FROM usuarios WHERE usuario LIKE @usuario"; // comando SQL
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);    // Se asigna la variable al comando
            reader = comando.ExecuteReader();                        // Se lee la linea 

            Usuarios usr = null;
            while (reader.Read()) // revisar los resultados de la consulta
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["contraseña"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());
            }
            return usr;
        }
        // AGREGAR PREGUNTA SENCILLA A LA BASE DE DATOS
        public int registroPS(Preguntas preguntas)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            // Sintaxis SQL para agregar la pregunta
            string sql = "";

            if (preguntas.TipoSPA == 1)
            {
                sql = "INSERT INTO `pregunta_s` (`preguntas`, `res1`, `res2`, `res3`, `res4`, `resC`, `nivel`)" +
                             " VALUES( @pregunta, @res1, @res2, @res3, @res4, @resC, @nivel)";
            }
            if (preguntas.TipoSPA == 2)
            {
                sql = "INSERT INTO `pregunta_t` (`texto`, `pregunta`, `res1`, `res2`, `res3`, `res4`, `resC`, `nivel`)" +
                              " VALUES( @texto, @pregunta, @res1, @res2, @res3, @res4, @resC, @nivel)";

            }
            if (preguntas.TipoSPA == 3)
            {
                sql = "INSERT INTO `pregunta_a` (`audio`,`audio_name`, `pregunta`, `res1`, `res2`, `res3`, `res4`, `resC`, `nivel`)" +
                             " VALUES( @audio,@audioname, @pregunta, @res1, @res2, @res3, @res4, @resC, @nivel)";

            }
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Se añaden los valores en el comando SQL
            comando.Parameters.AddWithValue("@texto", preguntas.Textos);
            comando.Parameters.AddWithValue("@audio", preguntas.Audios);
            comando.Parameters.AddWithValue("@audioname",preguntas.name);
            comando.Parameters.AddWithValue("@pregunta", preguntas.Pregutas);
            comando.Parameters.AddWithValue("@res1", preguntas.Res1);
            comando.Parameters.AddWithValue("@res2", preguntas.Res2);
            comando.Parameters.AddWithValue("@res3", preguntas.Res3);
            comando.Parameters.AddWithValue("@res4", preguntas.Res4);
            comando.Parameters.AddWithValue("@resC", preguntas.ResC);
            comando.Parameters.AddWithValue("@nivel", preguntas.Nivel);

            int resultado = comando.ExecuteNonQuery(); // Se realiza el comando y retorna numero de filas
            return resultado;
        }
        // MOSTRAR PREGUNTA SENCILLA EN EL EXAMEN
        public List<ModelQuestionGrammar> ConsultQuestions(int difficulty, int cant)
        {
            List<ModelQuestionGrammar> list = new List<ModelQuestionGrammar>();
            MySqlConnection connec = Conexion.getConexion();
            try
            {
                connec.Open();
                string command = "SELECT `preguntas`, `res1`, `res2`, `res3`, `res4`, `resC`, `nivel` FROM pregunta_s WHERE nivel=" + difficulty + " ORDER BY RAND() LIMIT " + (cant+1) ;
                MySqlCommand command1 = new MySqlCommand(command, connec);
                MySqlDataReader reader = command1.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(new ModelQuestionGrammar
                        {
                            Question = reader.GetString(0),
                            optionA = reader.GetString(1),
                            optionB = reader.GetString(2),
                            optionC = reader.GetString(3),
                            optionD = reader.GetString(4),
                            optionCorrect = reader.GetString(5),
                            difficulty = reader.GetInt32(6)
                        });
                    }
                }
                return list;
            }
            finally { connec.Close(); }
        }
        //CARGAR PREGUNTAS CON AUDIOS EN EL EXAMEN
        public List<ModelQuestionAudio> ConsultQuestionsAudio(int cant)
        {
            List<ModelQuestionAudio> list = new List<ModelQuestionAudio>();
            MySqlConnection connec = Conexion.getConexion();
            try
            {
                connec.Open();
                string command = "SELECT `audio`,`audio_name`,`pregunta`, `res1`, `res2`, `res3`, `res4`, `resC` FROM pregunta_a ORDER BY RAND() LIMIT " + (cant) ;
                MySqlCommand command1 = new MySqlCommand(command, connec);
                MySqlDataReader reader = command1.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ModelQuestionAudio
                        {
                            audio = reader.GetStream(0),
                            name = reader.GetString(1),
                            Question = reader.GetString(2),
                            optionA = reader.GetString(3),
                            optionB = reader.GetString(4),
                            optionC = reader.GetString(5),
                            optionD = reader.GetString(6),
                            optionCorrect = reader.GetString(7)
                        });
                    }
                return list;
            }
            finally { connec.Close(); }
        }
        public List<ModelQuestionText> ConsultQuestionsText(int cant)
        {
            List<ModelQuestionText> list = new List<ModelQuestionText>();
            MySqlConnection connec = Conexion.getConexion();
            try
            {
                connec.Open();
                string command = "SELECT `texto`, `pregunta`, `res1`, `res2`, `res3`, `res4`, `resC` FROM pregunta_t ORDER BY RAND() LIMIT "+(cant+1);  
                MySqlCommand command1 = new MySqlCommand(command, connec);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ModelQuestionText
                    {
                        Text = reader.GetString(0),
                        Question = reader.GetString(1),
                        optionA = reader.GetString(2),
                        optionB = reader.GetString(3),
                        optionC = reader.GetString(4),
                        optionD = reader.GetString(5),
                        optionCorrect = reader.GetString(6)
                    });

                }
                return list;
            }
            finally { connec.Close(); }
        }
        public void SaveExam()
        {
            List<ModelQuestionGrammar> lista = Sesion.ExamStudent;
            int i = 0;
            MySqlConnection connec = Conexion.getConexion();
            connec.Open();
            string command = "Select * from examenes_realizados group by idExamen";
            MySqlCommand command1 = new MySqlCommand(command,connec);
            MySqlDataReader reader = command1.ExecuteReader();
            int idExam = 1;
            while (reader.Read())
            {
                idExam++;
            }
            connec.Close();
            
            while (i<lista.Count)
            {
                connec.Open();
                string sql = " INSERT INTO examenes_realizados ( idExamen, nombreAlumno, pregunta, res, resC, nivel, seccion, fecha, tipoExamen) " +
                        " VALUES ( @idExamen, @nombreAlumno, @pregunta, @res, @resC, @nivel, @section, @fecha, @tipoExamen);";
                MySqlCommand comando = new MySqlCommand(sql, connec);
                comando.Parameters.AddWithValue("@idExamen", idExam);
                comando.Parameters.AddWithValue("@nombreAlumno",Usuarios.NombreA);
                comando.Parameters.AddWithValue("@pregunta", lista[i].Question);
                comando.Parameters.AddWithValue("@res", lista[i].optionA);
                comando.Parameters.AddWithValue("@resC", lista[i].optionCorrect);
                comando.Parameters.AddWithValue("@nivel", lista[i].difficulty);
                comando.Parameters.AddWithValue("@section", lista[i].section);
                comando.Parameters.AddWithValue("@fecha", lista[i].dateTime);
                comando.Parameters.AddWithValue("@tipoExamen", lista[i].tipoTest);
                comando.ExecuteNonQuery();
                i++;
                connec.Close();
            }
            
            
        }
        // MOSTRAR EXAMENES EN EL DGV
        public void DatosExamen(DataGridView data, string consulta)
        {
            // Conexion con la BD
            string cadenaConexion = "Database= testdb; Data Source=localhost; User Id=root;  Password=admin";
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectados = new MySqlConnection();
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            try
            {
                //Se abre conexion
                conexionBD.Open();
                codigo.Connection = conexionBD;

                //Se inserta la consulta
                codigo.CommandText = (consulta);
                //codigo.CommandText = ("SELECT * FROM examenes_realizados"); // Comando SQL que utilizamos
                //"SELECT * FROM examenes_realizados Where nombreAlumno like 'joseph'
                MySqlDataAdapter seleccionar = new MySqlDataAdapter();
                seleccionar.SelectCommand = codigo;
                //instancia de la tabla
                DataTable datostabla = new DataTable();
                // Selecciona los datos
                seleccionar.Fill(datostabla);
                //Se mandan los datos
                BindingSource formulario = new BindingSource();
                formulario.DataSource = datostabla;
                data.DataSource = formulario;
                seleccionar.Update(datostabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
