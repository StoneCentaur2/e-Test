using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test_E
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtUser.Text = "User";
            txtPass.Text = "Password";

            txtUser.ForeColor = Color.Gray;
            txtPass.ForeColor = Color.Gray;
        }
        string respuesta = "";

        //BOTON PARA ENTRAR AL PROGRAMA
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPass.Text;
            try
            {
                Control ctr = new Control();
                respuesta = ctr.ctrlLogin(usuario, password);
                if (respuesta.Length > 0) // si hubo mensajes
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    respuesta = "Bienvenido";
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int type = 1;
                    Sesion.typeTest = type;
                    Form form = new Form1();
                    form.Show();
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // BOTON PARA SALIR DE LA APLICACION
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //BOTON PARA ENTRAR COMO ALUMNO
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if ((txtNom.Text != "" && txtNom.Text != "Nombre(s)") && (txtApe.Text != "" && txtApe.Text != "Apellidos") &&
                (txtNum.Text != "" && txtNum.Text != "Numero de control") && (!string.IsNullOrEmpty(cmbCarrera.Text) && cmbCarrera.Text != "Carrera")
                && (!string.IsNullOrEmpty(cmbSemestre.Text) && cmbSemestre.Text != "Semestre"))
            {
                int type = 2;
                if (Rb_Asig.Checked == true)
                {
                    Usuarios.TipoExamen = "asignacion";
                    type = 1;
                }
                else
                {
                    Usuarios.TipoExamen = "liberacion";
                    type = 2;
                }
                Usuarios.NombreA = txtNom.Text + " " + txtApe.Text;
                Usuarios.Carrera = cmbCarrera.SelectedItem.ToString();
                Usuarios.Semestre = cmbSemestre.SelectedItem.ToString();
                Usuarios.IdA = txtNum.Text;
                Modelo modelo = new Modelo();
                if (modelo.existeAlumno(Usuarios.IdA))
                {
                    modelo.ActualizarAlumnos();
                }
                else
                {
                    modelo.registroAlumnos();
                }

                Sesion.typeTest = type;
                respuesta = "Bienvenido";
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else 
            {
                MessageBox.Show("Verifica Tus datos");
            }

        }

        // Activar colores Usuario
        private void txtPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.Black;
                if (txtPass.UseSystemPasswordChar == false)
                {
                    pssC.Visible = true;
                    pssC.Location = new Point(737, 247);
                    pssO.Visible = false;
                    pssO.Location = new Point(737, 201);
                }
                else
                {
                    pssC.Visible = false;
                    pssC.Location = new Point(737, 201);
                    pssO.Visible = true;
                    pssO.Location = new Point(737, 244);
                }
            }
        }
        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {
            txtUser.Text = "";
            txtUser.ForeColor = Color.Black;
        }
        // Mirar contraseña
        private void pssC_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "Password")
            {
                pssC.Visible = false;
                pssO.Visible = true;
                pssC.Location = new Point(737, 201);
                pssO.Location = new Point(737, 244);
                txtPass.PasswordChar = '\0';
            }
        }
        private void pssO_Click(object sender, EventArgs e)
        {
            pssO.Visible = false;
            pssC.Visible = true;
            pssC.Location = new Point(737, 247);
            pssO.Location = new Point(737, 201);
            txtPass.PasswordChar = '*';
        }
        // Activar colores Alumnos
        private void txtNom_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtNom.Text == "Nombre(s)")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }
        private void txtApe_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtApe.Text == "Apellidos")
            {
                txtApe.Text = "";
                txtApe.ForeColor = Color.Black;
            }
        }
        private void txtNum_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtNum.Text == "Numero de control")
            {
                txtNum.Text = "";
                txtNum.ForeColor = Color.Black;
            }
        }
        private void cmbCarrera_Click(object sender, EventArgs e)
        {
                cmbCarrera.ForeColor = Color.Black;
        }
        private void cmbSemestre_Click(object sender, EventArgs e)
        {
            cmbSemestre.ForeColor = Color.Black;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNum.ForeColor = Color.Black;

            if (e.KeyChar > 0 && e.KeyChar < 48 || e.KeyChar > 57)
            {
                txtNum.Clear();
                MessageBox.Show("Solo numeros, recuerda que es tu numero de control");
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNom.ForeColor = Color.Black;
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtApe.ForeColor = Color.Black;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUser.ForeColor = Color.Black;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.ForeColor = Color.Black;
            pssO.Visible = false;
            pssC.Visible = true;
            pssC.Location = new Point(737, 247);
            pssO.Location = new Point(737, 201);
            txtPass.PasswordChar = '*';
        }
    }
}
