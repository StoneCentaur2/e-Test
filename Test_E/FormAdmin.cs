using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
using Microsoft.VisualBasic.Devices;
using System.IO;
using SpreadsheetLight;
using SpreadsheetLight.Charts;

namespace Test_E
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            rbTipoS.Checked = true;
            txtTexto.Text = "";
            txtTexto.Enabled = false;
            txtTexto.BackColor = SystemColors.Control;
            btnAudio.Enabled = false;
            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            lblAudio.Visible = false;
            lblAudio.Text = "";
            picPass1.Visible = true;
            picPass2.Visible = false;
            picPass2.Location = new Point(569, 306);
            txtC1.PasswordChar = '*';
            txtC2.PasswordChar = '*';
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Modelo objinsertar = new Modelo();
            objinsertar.DatosExamen(dgvRegistros, "SELECT * FROM examenes_realizados");
            dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dgvRegistros.EnableHeadersVisualStyles = false;
        }

        int preSPA = 0;   // tipo de pregunta (Sensilla, Parrafo, Audio)
        int nvlPre = 0;   // nivel de la pregunta (A1, A2, B1, B2)
        int tipoEx = 1;   // (1.Asignacion, 2.Liberacion)  // SE CAMBIO YA QUE USAN LAS MISMAS PREGUNTAS 
        string pre = "", r1 = "", r2 = "", r3 = "", r4 = "", rC = "";
        string texto = "", rutaAudio = "";
        string name = "";
        Stream audio;

        //
        // ----- SECCION DE PREGUNTAS -----
        //

        // BOTON PARA AGREGAR LAS PREGUNTAS
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Preguntas pregunta = new Preguntas();
            Control control = new Control();
            // Se revisa que el formulario se llene correctamente (preguntas, respuestas, etc).
            Asignaciones();
            MemoryStream memory = new MemoryStream();
            // Si se selecciona la pregunta de tipo Audio.
            if (rbTipoA.Checked)
            {
                // Cargar valores de audio
                audio.CopyTo(memory);
                pregunta.Audios = memory;
            }
            // se guardan Los valores de la pregunta en la clase "Preguntas".
            pregunta.name = name;
            pregunta.Textos = texto;
            pregunta.TipoSPA = preSPA;
            pregunta.Nivel = nvlPre;
            pregunta.Id_tipo_s = tipoEx;
            pregunta.Pregutas = pre;
            pregunta.Res1 = r1;
            pregunta.Res2 = r2;
            pregunta.Res3 = r3;
            pregunta.Res4 = r4;
            pregunta.ResC = rC;
            // Se intenta guardar la pregunta:
            try
            {
                string respuesta = control.ctrlPreguntaS(pregunta);
                if (respuesta.Length > 0)
                {
                    // Si se detecta un error al agregar.
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si la pregunta guardada.
                    MessageBox.Show(" Pregunta agregada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se limpian los campos de la pregunta.
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // BOTON PARA lIMPIAR LOS CAMPOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        // BOTON PARA AGREGAR AUDIOS
        private void btnAudio_Click(object sender, EventArgs e)
        {
            Computer mycomputer = new Computer(); // Acceder a "FileSystem".
            // Buscar Archivo
            var resultado = ofd1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                lblAudio.Text = ofd1.FileName;
                audio = ofd1.OpenFile();
                name = ofd1.SafeFileName;
            }
        }
       
        // Revisar el tipo de pregunta que se selecciono (Sencilla, Parrafo, Audio).
        private void rbTipoS_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            txtTexto.Enabled = false;
            txtTexto.BackColor = SystemColors.Control;
            btnAudio.Enabled = false;
            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            lblAudio.Visible = false;
            lblAudio.Text = "";

            rbNvlA1.Enabled = true;
            rbNvlA2.Enabled = true;
            rbNvlB1.Enabled = true;
            rbNvlB2.Enabled = true;
        }
        private void rbTipoP_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.Enabled = true;
            txtTexto.BackColor = SystemColors.Window;

            btnAudio.Enabled = false;
            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            lblAudio.Visible = false;
            lblAudio.Text = "";

            rbNvlA1.Enabled = false;
            rbNvlA2.Enabled = false;
            rbNvlB1.Enabled = false;
            rbNvlB2.Enabled = false;

            nvlPre = 1;
        }
        private void rbTipoA_CheckedChanged(object sender, EventArgs e)
        {
            btnAudio.Enabled = true;
            btnPlay.Enabled = true;
            btnStop.Enabled = true;
            lblAudio.Visible = true;

            txtTexto.Text = "";
            txtTexto.Enabled = false;
            txtTexto.BackColor = SystemColors.Control;

            rbNvlA1.Enabled = false;
            rbNvlA2.Enabled = false;
            rbNvlB1.Enabled = false;
            rbNvlB2.Enabled = false;

            nvlPre = 1;
        }
        
        // Cambiar casillas de Respuestas
        private void txtOpc1_TextChanged(object sender, EventArgs e)
        {
            check(txtOpc1, cBxOpc1);
            txtOpc1.ForeColor = Color.Black;
        }
        private void txtOpc2_TextChanged(object sender, EventArgs e)
        {
            check(txtOpc2, cBxOpc2);
            txtOpc2.ForeColor = Color.Black;
        }
        private void txtOpc3_TextChanged(object sender, EventArgs e)
        {
            check(txtOpc3, cBxOpc3);
            txtOpc3.ForeColor = Color.Black;
        }
        private void txtOpc4_TextChanged(object sender, EventArgs e)
        {
            check(txtOpc4, cBxOpc4);
            txtOpc4.ForeColor = Color.Black;
        }
        // Automatizar el Check de las respuestas
        public void check(TextBox txt, CheckBox cBx)
        {
            if (txt.Text != "")
            {
                cBx.Checked = true;
                txt.BackColor = Color.White;
            }
            else
            {
                cBx.Checked = false;
                txt.BackColor = SystemColors.Control;
            }
        }


        // Cambiar casillas de Texto y Pregunta
        private void txtTexto_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtTexto.Text == "Agregar Texto...")
            {
                txtTexto.Text = "";
                txtTexto.ForeColor = Color.Black;
            }
        }
        private void txtPre_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPre.Text == "Inserte Pregunta")
            {
                txtPre.Text = "";
                txtPre.ForeColor = Color.Black;
                txtPre.BackColor = Color.White;
            }
        }
        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            txtTexto.ForeColor = Color.Black;
        }
       
        // BOTON PARA Reproducir AUDIOS
        WindowsMediaPlayer sonido;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            sonido = null;
            try
            {
                if (sonido == null)
                {
                    sonido = new WindowsMediaPlayer();
                    string rutaAudio = "";
                    rutaAudio = lblAudio.Text;
                    sonido.URL = rutaAudio;
                    sonido.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // BOTON PARA PARAR AUDIOS
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonido != null)
                {
                    sonido.controls.stop();
                    sonido = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Limpiar los campos
        public void LimpiarCampos()
        {
            txtPre.Text = "Inserte Pregunta";
            txtPre.ForeColor = Color.Gray;
            txtPre.BackColor = SystemColors.Control;
            txtOpc1.Text = "";
            txtOpc1.BackColor = SystemColors.Control;
            txtOpc2.Text = "";
            txtOpc2.BackColor = SystemColors.Control;
            txtOpc3.Text = "";
            txtOpc3.BackColor = SystemColors.Control;
            txtOpc4.Text = "";
            txtOpc4.BackColor = SystemColors.Control;
            txtTexto.Text = "Agregar Texto...";
            txtTexto.ForeColor = Color.Gray;
            lblAudio.Text = "-";
            rbNvlA1.Checked = false;
            rbNvlA2.Checked = false;
            rbNvlB1.Checked = false;
            rbNvlB2.Checked = false;
            rbTipoS.Checked = false;
            rbTipoP.Checked = false;
            rbTipoA.Checked = false;
            rbRC1.Checked = false;
            rbRC2.Checked = false;
            rbRC3.Checked = false;
            rbRC4.Checked = false;
        }
        // Agregar los valores a las preguntas
        public void Asignaciones()
        {
            // Tipo de pregunta 
            if (rbTipoS.Checked == true) { preSPA = 1; }
            if (rbTipoP.Checked == true) { preSPA = 2; texto = txtTexto.Text; }
            if (rbTipoA.Checked == true) { preSPA = 3; }
            // Nivel a la pregunta
            if (rbNvlA1.Checked == true) { nvlPre = 1; }
            if (rbNvlA2.Checked == true) { nvlPre = 2; }
            if (rbNvlB1.Checked == true) { nvlPre = 3; }
            if (rbNvlB2.Checked == true) { nvlPre = 4; }
            // Pregunta y respuestas
            pre = txtPre.Text;
            r1 = txtOpc1.Text;
            r2 = txtOpc2.Text;
            if (txtOpc3.Text == "") { r3 = "null"; }
            else { r3 = txtOpc3.Text; }
            if (txtOpc4.Text == "") { r4 = "null"; }
            else { r4 = txtOpc4.Text; }
            //Asignar la respuesta correcta
            if (rbRC1.Checked == true) { rC = txtOpc1.Text; }
            if (rbRC2.Checked == true) { rC = txtOpc2.Text; }
            if (rbRC3.Checked == true) { rC = txtOpc3.Text; }
            if (rbRC4.Checked == true) { rC = txtOpc4.Text; }
            if (rbRC1.Checked == false && rbRC2.Checked == true && rbRC3.Checked == true && rbRC4.Checked == true)
            {
                rC = "";
            }
        }

        //
        // ----- Seccion Calificaciones -----
        //

        private void FormAdmin_Load_1(object sender, EventArgs e)
        {
            Modelo objinsertar = new Modelo();
            objinsertar.DatosExamen(dgvRegistros, "SELECT * FROM examenes_realizados");
        }
        //BOTON para filtrar datos,
        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            //Contadores para respuestas correctas
            int contCA1 = 0, contCA2 = 0, contCB1 = 0, contCB2 = 0;
            int contTA1 = 0, contTA2 = 0, contTB1 = 0, contTB2 = 0;
            // Contadores para las preguntas de seccion Totales y Correctas
            int contLC = 0, contLT = 0;
            int contGC = 0, contGT = 0;
            int contRC = 0, contRT = 0;

            //Se asigna el nombre del alumno para ver sus respuestas de examen
            string referencia = txtID.Text;
            // Se llama a la clase que hace la busqueda en las tablas SQL
            Modelo objinsertar = new Modelo();
           
            // Se manda la tabla y la sentencia SQL
            if (cbxFiltros.Text == "ID EXAMEN")
            {
                objinsertar.DatosExamen(dgvRegistros, "SELECT * FROM examenes_realizados Where idExamen like '" + referencia + "'");
            }
            if (cbxFiltros.Text == "NOMBRE")
            {
                objinsertar.DatosExamen(dgvRegistros, "SELECT * FROM examenes_realizados Where nombreAlumno like '" + referencia + "'");
            }
            if (cbxFiltros.Text == "FECHA")
            {
                objinsertar.DatosExamen(dgvRegistros, "SELECT * FROM examenes_realizados Where fecha like '" + referencia + "'");
            }
            try
            {
                int numeracion = -1;
                bool primero = true;
                int salir = 1;
                // Recorremos el DGV para insertar los numeros de registro (que inicien en 0).
                foreach (DataGridViewRow row in dgvRegistros.Rows)
                {
                    if (primero)
                    {
                        numeracion = Convert.ToInt32(row.Cells["numRegistro"].Value) - 1;
                        primero = false;
                    }
                    row.Cells["numRegistro"].Value = Convert.ToInt32(row.Cells["numRegistro"].Value) - numeracion;

                    if (salir == numeracion + 1)
                    {
                        break;
                    }
                    salir++;
                }
                //Recorremos los puntos de la grafica para limpiarlos
                foreach (var series in graficaAlumno.Series)
                {
                    series.Points.Clear(); // Se borran los puntos
                }

                string valor = "";
                string resA = "", resC = "";
                string seccion = "";

                graficaAlumno.Series["nivel"].Color = Color.Black;
                // Recorrer las columnas del DGV
                for (int i = 0; i < dgvRegistros.Rows.Count - 1; i++)
                {
                    //Obtenemos las respuestas del alumno y examen.
                    resA = dgvRegistros.Rows[i].Cells["res"].Value.ToString();
                    resC = dgvRegistros.Rows[i].Cells["resC"].Value.ToString();
                    //Se asigna el nivel a la variable valor.
                    valor = dgvRegistros.Rows[i].Cells["nivel"].Value.ToString();
                    //Se asigna la seccion a la que pertenece la pregunta.
                    seccion = dgvRegistros.Rows[i].Cells["seccion"].Value.ToString();

                    if (seccion == "Grammar")
                    {
                        // Se inserta el valor en el punto y de la grafica.
                        graficaAlumno.Series["nivel"].Points.AddY(valor);

                        // Si la respuesta es correcta
                        if (resA == resC)
                        {
                            graficaAlumno.Series["nivel"].Points[i].MarkerColor = Color.Green;
                            graficaAlumno.Series["nivel"].Points[i].MarkerBorderColor = Color.Green;
                            // Contar la cantidad de preguntas por seccion.
                            if (valor == "1") { contCA1++; }
                            if (valor == "2") { contCA2++; }
                            if (valor == "3") { contCB1++; }
                            if (valor == "4") { contCB2++; }

                        }
                        // Si es incorrecta
                        else
                        {
                            graficaAlumno.Series["nivel"].Points[i].MarkerColor = Color.Red;
                            graficaAlumno.Series["nivel"].Points[i].MarkerBorderColor = Color.Red;
                        }
                        // Contar la cantidad de preguntas por seccion.
                        if (valor == "1") { contTA1++; }
                        if (valor == "2") { contTA2++; }
                        if (valor == "3") { contTB1++; }
                        if (valor == "4") { contTB2++; }
                    }
                    // Contar preguntas de seccion Listen 
                    if (seccion == "Listen")
                    {
                        // Correctas
                        if (resA == resC)
                        {
                            contLC++;
                        }
                        // Preguntas totales
                        contLT++;
                    }
                    // Contar preguntas de seccion Reading
                    if (seccion == "Reading")
                    {
                        // Correctas
                        if (resA == resC)
                        {
                            contRC++;
                        }
                        // Preguntas totales
                        contRT++;
                    }

                }
                // Mostrar las etiquetas de las preguntas (respuestas correctas / total de preguntas).
                lblRespA1.Text = "A1 = " + contCA1.ToString() + " / " + contTA1.ToString();
                lblRespA2.Text = "A2 = " + contCA2.ToString() + " / " + contTA2.ToString();
                lblRespB1.Text = "B1 = " + contCB1.ToString() + " / " + contTB1.ToString();
                lblRespB2.Text = "B2 = " + contCB2.ToString() + " / " + contTB2.ToString();
                // Contador de preguntas de Grammar (son las de nivel A1, A2, B1 y B2).
                contGT = contTA1 + contTA2 + contTB1 + contTB2;
                // Contador de respuestas correctas de seccion Grammar.
                contGC = contCA1 + contCA2 + contCB1 + contCB2;
                // Mostrar contadores de las 3 secciones
                lblG.Text = "Grammar = " + contGC.ToString() + " / " + contGT.ToString();
                lblL.Text = "Listen  = " + contLC.ToString() + " / " + contLT.ToString();
                lblR.Text = "Reading = " + contRC.ToString() + " / " + contRT.ToString();
            }
            catch
            {
            }
        }
        // BOTON para exportar datos (guardar el excel),
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count != 0)
            {
                ExportData();
            }
            else
            {
                MessageBox.Show("No se encontraron referencias");
            }
        }
       
        // Evento para seleccionar el texto con un clic en el DGV
        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvRegistros.CurrentCell.Value.ToString();
        }
        // Metodo para exportar los datos a un archivo de excel 
        public void ExportData()
        {
            // Se asiggna un nombre al archivo (Con el nombre del estudiante.xlsx).
            string namefile = dgvRegistros.Rows[1].Cells[2].Value.ToString() + ".xlsx";
            // La ruta para almacenarlo sera en Documentos.
            string basepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Nombre de la carpeta.
            string path = basepath + "/" + dgvRegistros.Rows[1].Cells[2].Value.ToString();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = Path.Combine(path, namefile);
            int grammar = 0;
            int listen = 0;
            int reading = 0;
            string typeExam = "asignacion";

            DataTable dtGraphic = new DataTable();

            dtGraphic.Columns.Add("Question", typeof(int));
            dtGraphic.Columns.Add("Nivel", typeof(int));
            // Creacion de la tabla.
            DataTable dt = new DataTable();
            dt.Columns.Add(dgvRegistros.Columns[1].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[2].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[3].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[4].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[5].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[6].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[7].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[8].Name, typeof(string));
            dt.Columns.Add(dgvRegistros.Columns[9].Name, typeof(string));
            dt.Columns.Add("Resultado", typeof(string));
            int numQuestion = 1;
            // Se rellena la tabla
            foreach (DataGridViewRow rowGrid in dgvRegistros.Rows)
            {
                DataRow row = dt.NewRow();
                row[dgvRegistros.Columns[1].Name] = rowGrid.Cells[1].Value;
                row[dgvRegistros.Columns[2].Name] = rowGrid.Cells[2].Value;
                row[dgvRegistros.Columns[3].Name] = rowGrid.Cells[3].Value;
                row[dgvRegistros.Columns[4].Name] = rowGrid.Cells[4].Value;
                row[dgvRegistros.Columns[5].Name] = rowGrid.Cells[5].Value;
                row[dgvRegistros.Columns[6].Name] = rowGrid.Cells[6].Value;
                row[dgvRegistros.Columns[7].Name] = rowGrid.Cells[7].Value;
                row[dgvRegistros.Columns[8].Name] = rowGrid.Cells[8].Value;
                row[dgvRegistros.Columns[9].Name] = rowGrid.Cells[9].Value;
                string resultado = "Incorrecto";

                if (rowGrid.Cells[1].Value != null)
                {
                    if (rowGrid.Cells[4].Value.ToString() == rowGrid.Cells[5].Value.ToString())
                    {
                        typeExam = rowGrid.Cells[9].Value.ToString();
                        resultado = "Correcto";
                        switch (rowGrid.Cells[7].Value)
                        {
                            case "Listen":
                                listen++;
                                break;
                            case "Grammar":
                                grammar++;
                                break;
                            case "Reading":
                                reading++;
                                break;
                        }
                    }
                    // imprimir la seccion de grammar
                    switch (rowGrid.Cells[7].Value)
                    {
                        case "Grammar":
                            dtGraphic.Rows.Add(numQuestion, Convert.ToInt32(rowGrid.Cells[6].Value));
                            numQuestion++;
                            break;
                    }
                    row["resultado"] = resultado;
                    dt.Rows.Add(row);
                }
            }
            DataTable dtResult = new DataTable();

            dtResult.Columns.Add("seccion", typeof(string));
            dtResult.Columns.Add("respuestas correctas", typeof(string));

            int cantQuestionsGrammar = 80;
            int cantQuestionsListen = 10;
            int cantQuestionsReading = 10;

            if (typeExam != "asignacion")
            {
                cantQuestionsListen = 20;
                cantQuestionsGrammar = 120;
                DataRow rowGrid1 = dtResult.NewRow();
                rowGrid1["seccion"] = "Grammar";
                rowGrid1["respuestas correctas"] = grammar + " / " + cantQuestionsGrammar;
                dtResult.Rows.Add(rowGrid1);
                DataRow rowGrid2 = dtResult.NewRow();
                rowGrid2["seccion"] = "Listen";
                rowGrid2["respuestas correctas"] = listen + " / " + cantQuestionsListen;
                dtResult.Rows.Add(rowGrid2);
                DataRow rowGrid3 = dtResult.NewRow();
                rowGrid3["seccion"] = "Reading";
                rowGrid3["respuestas correctas"] = reading + " / " + cantQuestionsReading;
                dtResult.Rows.Add(rowGrid3);
            }
            else
            {
                DataRow rowGrid1 = dtResult.NewRow();
                rowGrid1["seccion"] = "Grammar";
                rowGrid1["respuestas correctas"] = grammar + " / " + cantQuestionsGrammar;
                DataRow rowGrid2 = dtResult.NewRow();
                rowGrid2["seccion"] = "Listen";
                rowGrid2["respuestas correctas"] = listen + " / " + cantQuestionsListen;
                dtResult.Rows.Add(rowGrid1);
            }
            // Se marca al final una tabla de las preguntas y el nivel correspondido
            // NOTA : Los numero que se ven son las posiciones de las casillas en Excel
            SLDocument sLDocument = new SLDocument();
            sLDocument.ImportDataTable(2, 2, dtResult, true);
            sLDocument.ImportDataTable(1000, 2, dtGraphic, true);
            SLChart chart = sLDocument.CreateChart("B1000", "C1080");
            chart.SetChartType(SLLineChartType.Line);
            chart.SetChartPosition(8, 4, 20, 1);
            sLDocument.InsertChart(chart);
            sLDocument.ImportDataTable(23, 2, dt, true);
            sLDocument.AutoFitColumn(1, 15);
            sLDocument.AutoFitRow(1, 600);

            try
            { 
                sLDocument.SaveAs(filepath);
                MessageBox.Show("Archivo guardado!");
            }
            catch
            {
                MessageBox.Show("Archivo en uso");
            }
        }

        //
        // Seccion Usuarios
        //

        // BOTON PARA REGISTRAR USUARIOS
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios(); // Se instancia clase de los datos
            // Se asignan los valores de los Texbox a las variables

            usuario.Nombre = txtN.Text;
            usuario.Usuario = txtU.Text;
            usuario.Password = txtC1.Text;
            usuario.ConPassword = txtC2.Text;
            try
            {
                Control control = new Control();

                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Mostrar contraseña.
        private void picPass1_Click(object sender, EventArgs e)
        {
            picPass1.Visible = false;
            picPass2.Visible = true;
            txtC1.PasswordChar = '\0';
            txtC2.PasswordChar = '\0';
        }
        // Ocultar contraseña.
        private void picPass2_Click(object sender, EventArgs e)
        {
            picPass2.Visible = false;
            picPass1.Visible = true;
            //picPass1.Location = new Point(569, 306);
            //picPass2.Location = new Point(599, 306);
            txtC1.PasswordChar = '*';
            txtC2.PasswordChar = '*';
        }
    }
}
