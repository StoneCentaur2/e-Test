using System.Security.Cryptography;

namespace Test_E
{
    class Control
    {
        // - - - - - - FUNCIONES DE CONFIGURACIONES - - - - - -

        // VERIFICAR LOS CAMPOS Y VALORES PARA AGREGAR USUARIOS
        public string ctrlRegistro(Usuarios usuario) // se obtienen las variables de Clase Usuarios
        {
            Modelo modelo = new Modelo();             // Instancia de la clase modelo para las consultas
            string respuesta = "";                    // Variable para el mensaje de registro

            // Comprobar si algun campo del registro esta vacio
            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) ||
                string.IsNullOrEmpty(usuario.ConPassword) || string.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                // Comprobar si las contraseñas coinciden
                if (usuario.Password == usuario.ConPassword)
                {
                    // Comprobar si el nombre de usuario esta disponible
                    if (modelo.existeUsuario(usuario.Usuario)) // Si se retorna un valor verdadero
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        // usuario.Password = generarSHA1(usuario.Password); // Encriptar contraseña
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }

            return respuesta;
        }
        // AGREGAR PREGUNTAS
        public string ctrlPreguntaS(Preguntas preguntas)
        {
            Modelo modelo = new Modelo();             // Instancia de la clase modelo para las consultas
            string respuesta = "";                    // Variable para el mensaje de registro

            if (preguntas.TipoSPA == 0)
            {
                respuesta = "No se selecciono el tipo de pregunta.";
            }
            else
            {
                if (preguntas.Nivel == 0)
                {
                    respuesta = "No se selecciono el nivel de la pregunta.";
                }
                else
                {
                    if (preguntas.Id_tipo_s == 0)
                    {
                        respuesta = "El tipo de examen no fue seleccionado";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(preguntas.Pregutas) || string.IsNullOrEmpty(preguntas.Res1) || string.IsNullOrEmpty(preguntas.Res2))
                        {
                            respuesta = "Revise los campos de la pregunta esten completos";
                        }
                        else
                        {
                            // Comprobar si la respuesta fue seleccionada
                            if (preguntas.ResC == "" || preguntas.ResC == "null")
                            {
                                respuesta = "La respuesta correcta para la pregunta no fue seleccionada";
                            }
                            else
                            {
                                modelo.registroPS(preguntas);
                            }
                        }
                    }
                }
            }
            return respuesta;
        }
        
        // - - - - - - FUNCIONES DE INGRESO - - - - - -

        // ACCEDER A LA CUENTA ADMINISTRADOR
        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;
            // Validar que los campos del login no esten vacios
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar los campos";
            }
            else
            {
                datosUsuario = modelo.Ingresar(usuario);
                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    //if (datosUsuario.Password != generarSHA1(password)) // Con contraseña encriptada
                    //{
                    //    respuesta = "El usuario y/o contraseña no coinciden";
                    //}
                    if (datosUsuario.Password != password)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        Sesion.id = datosUsuario.Id;
                        Sesion.usuario = usuario;
                        Sesion.nombre = datosUsuario.Nombre;
                        Sesion.id_tipo = datosUsuario.Id_tipo;
                    }
                }
            }
            return respuesta;
        }

        // CIFRAR CONTRASEÑAS (SI FUNCIONA PERO NO ESTA IMPLEMENTADO).
        //private string generarSHA1(string cadena)
        //{
        //    //UTF8Encoding enc = new UTF8Encoding();
        //    //byte[] data = enc.GetBytes(cadena);
        //    //byte[] result;

        //    //SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

        //    //result = sha.ComputeHash(data);
        //    //StringBuilder sb = new StringBuilder();

        //    //for (int i = 0; i < result.Length; i++)
        //    //{
        //    //    if (result[i] < 16)
        //    //    {
        //    //        sb.Append("0");
        //    //    }
        //    //    sb.Append(result[i].ToString("x"));
        //    //}
        //    //return sb.ToString();
        //}

    }
}
