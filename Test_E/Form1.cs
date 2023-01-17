using System;
using System.Linq;
using System.Windows.Forms;

namespace Test_E
{
    public partial class Form1 : Form
    {
        public DateTime horaInicio;
        DateTime horasTranscurridas;

        public Form1()
        {
            InitializeComponent();

            lblNombre.Text = Sesion.nombre;
            int tipoUsuario = Sesion.id_tipo;

            lblTiempo.Text = "";

            if (tipoUsuario == 1) // Si es un Administrador (1)
            {
                btnS.Visible = true; // Boton de configuraciones visible
                lbl_Section.Text = "Teacher";
                OpenWindow(new FormAdmin());
            }
            else // Si es un Estudiante (2)
            {
                btnS.Visible = false;
                lbl_Section.Text = "Tutorial";
                OpenWindow(new FormTutorial());
            }  
            btnR.Visible = false;
            btnG.Visible = false;
            btnL.Visible = false;
        }
        // BOTON para entrar al apartado de READING
        private void btnR_Click(object sender, EventArgs e)
        {
            lbl_Section.Text = "Reading";
            OpenWindow(new FormReading());
        }
        // BOTON para entrar al apartado de GRAMMAR
        private void btnG_Click(object sender, EventArgs e)
        {
            lbl_Section.Text = "Grammar";
            OpenWindow(new FormGrammar());
        }
       // BOTON para entrar al apartado de LISTEN
        private void btnL_Click(object sender, EventArgs e)
        {
            lbl_Section.Text = "Listen";
            OpenWindow(new FormListen());
        }
        // BOTON para CONFIGURACIONES y OPCIONES administrativas
        private void btnS_Click(object sender, EventArgs e)
        {
            lbl_Section.Text = "Teacher";
            OpenWindow(new FormAdmin());
        }
        // BOTON para SALIR del programa.
        private void btnE_Click(object sender, EventArgs e)
        {
            // Se limpian valores de sesion
            Sesion.id = 0;
            Sesion.usuario = "";
            Sesion.nombre = "";
            Sesion.id_tipo = 2;
            
            // Se cierra el formulario
            this.Close();
            FormLogin frm = new FormLogin();
            frm.Visible = true;
            Sesion clr = new Sesion();
        }

        // METODO para abrir pantallas en un solo panel
        public void OpenWindow(object form2)
        {
            // Revisa si el panel contiene controles o esta en blanco
            if (this.windowPanel.Controls.Count > 0)
                this.windowPanel.Controls.RemoveAt(0);
            // Declaramos una variable para guardar los formularios
            Form fh = form2 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            // Se añade el formulario en el panel
            this.windowPanel.Controls.Add(fh);
            this.windowPanel.Tag = fh;
            this.BringToFront();
            fh.Show();
        }
        // EVENTO TICK para tomar el tiempo de examen
        private void timerHora_Tick(object sender, EventArgs e)
        {
            // Variable para el contador de tiempo
            string tiempo = DateTime.Now.ToString("H:mm:ss");
            horasTranscurridas = Convert.ToDateTime(tiempo);
            TimeSpan duracion = horasTranscurridas.Subtract(horaInicio);

            // Evaluamos si ya pasaron 2 horas.
            if(horasTranscurridas.Subtract(horaInicio).TotalHours == 2)
            {
                // Instanciamos el modelo de datos.
                Modelo modelo = new Modelo();
                // Indicamos al alumno sobre la finalizacion del examen.
                MessageBox.Show("Tu tiempo a concluido", "Examen finalizado", MessageBoxButtons.OK);
                // Se guarda el examen.
                modelo.SaveExam();
                // Se abre la ventana de login.
                Form form = new FormLogin();
                form.Show();
                var form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                Form1 padre = form1 ?? new Form1();
                // Limpiamos los datos de la sesion.
                Sesion.ExamStudent = null;
                padre.Close();
                // Detenemos el tiempo de examen.
                timerHora.Stop();
            }
            // Se actualiza el tiempo transcurrido del examen
            lblTiempo.Text = duracion.ToString();
        }
    }
}
