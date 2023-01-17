using System;
using System.Linq;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Reflection;

namespace Test_E
{
    public partial class FormTutorial : Form
    {
        // Se extrae la ruta del archivo de audio.
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        static string direccioncarpeta = AppDomain.CurrentDomain.BaseDirectory + "/audio";
        string direccionaudio = direccioncarpeta + "/audio.mp3";

        public FormTutorial()
        {
            InitializeComponent();
            BtnEmpezar.Visible = false;
            Sesion.empezar = false;
            findAudio();
        }

        // BOTON para REPRODUCIR AUDIO de la prueba de sonido
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos la direccion
                player.URL = direccionaudio;
                player.controls.play();
                if (MessageBox.Show("¿Ha podido escuchar el audio de prueba?", "Prueba de sonido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cbxStep1.Checked = true;
                    player.controls.stop();
                }
                else
                    MessageBox.Show("Compruebe que esten conectados correctamente los altavoces o audifonos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // BOTON para PARAR AUDIO de la prueba de sonido
        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
        // BOTON para el CONFIRMAR RESPUESTA de tutorial
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Se comprueba que seleccione alguna respuesta
            if (Rb_1.Checked == true || Rb_2.Checked == true || Rb_3.Checked == true || Rb_4.Checked == true)
            {
                cbxStep2.Checked = true;
                BtnEmpezar.Visible = true;
            }
            else
                MessageBox.Show("Selecciona una respuesta");
        }
        // BOTON para EMPEZAR EXAMEN.
        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
            if (cbxStep2.Checked == true && cbxStep1.Checked == true)
            {
             // Se da por iniciada la sesion.
                Sesion.empezar = true;
                MessageBox.Show("Has terminado con el tutorial, ahora comenzara el examen", "Tutorial terminado");
             // Accedemos a variables de otros formularios.
                var form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                Form1 padre = form ?? new Form1();
             // Asignamos formato de hora para el examen.
                string hora1 = DateTime.Now.ToString("H:mm:ss");
                padre.horaInicio = Convert.ToDateTime(hora1);
             // Se inicia el crónometro para el examen y se marca visible.
                padre.timerHora.Start();
                padre.lblTiempo.Visible = true;
             // Se abre METODO para navegar entre formularios.
                padre.OpenWindow(new FormGrammar());
             // Titulo para la seccion.
                padre.lbl_Section.Text = "Grammar";
            }
        }

        // METODO para encontrar audio.
        public void findAudio() 
        {
            // Comprobamos si existe o no la carpeta contenedora existe.
            if (!Directory.Exists(direccioncarpeta))
            {
             // Se asigna ruta para la carpeta
                Directory.CreateDirectory(direccioncarpeta);
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Test_E.Resources.audioprueba.mp3");
                FileStream fileStream = new FileStream(direccionaudio, FileMode.CreateNew);
             // Se agrega audio
                for (int i = 0; i < stream.Length; i++)
                    fileStream.WriteByte((byte)stream.ReadByte());
                fileStream.Close();
            }
            // Si ya existe.
            else
            {
                if (!File.Exists(direccionaudio))
                {
                 // Se signa ruta para el audio
                    Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Test_E.Resources.audioprueba.mp3");
                    FileStream fileStream = new FileStream(direccionaudio, FileMode.CreateNew);
                 // SE crea direcccion para el audio 
                    for (int i = 0; i < stream.Length; i++)
                        fileStream.WriteByte((byte)stream.ReadByte());
                    fileStream.Close();
                }
            }
        }
    }
}
