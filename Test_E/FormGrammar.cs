using SpreadsheetLight;
using SpreadsheetLight.Charts;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Test_E
{
    public partial class FormGrammar : Form
    {
        public FormGrammar()
        {
            InitializeComponent();
            loadQuestions();
            showQuestions();
        }

        int level = 1;
        int hits = 0, questionshits = 0;
        int NumQuestionsLvl1 = 0;
        int NumQuestionsLvl2 = 0;
        int NumQuestionsLvl3 = 0;
        int NumQuestionsLvl4 = 0;
        int numQuestions = 0;
        string answerCorrect = "";

        // Se crean modelos para guardar las preguntas de la base de datos
        List<ModelQuestionGrammar> listQuestionLvl1;
        List<ModelQuestionGrammar> listQuestionLvl2;
        List<ModelQuestionGrammar> listQuestionLvl3;
        List<ModelQuestionGrammar> listQuestionLvl4;
        int numTotalQuestions = 0;
        Modelo model = new Modelo();

        // BOTÓN para pasar a la siguiente respuesta.
        private void btn_Next_Click(object sender, EventArgs e)
        {
            // Evaluamos si esta seleccionada una opcion.
            if (RBtn_1.Checked == true || RBtn_2.Checked == true || RBtn_3.Checked == true || RBtn_4.Checked == true)
            {
                string AnswerSelect = "";
                // Evaluar la respuesta seleccionada.                
                if (RBtn_1.Checked == true)
                {
                    checkAnswer(RBtn_1);
                    AnswerSelect = RBtn_1.Text;
                }
                else if (RBtn_2.Checked == true)
                {
                    checkAnswer(RBtn_2);
                    AnswerSelect = RBtn_2.Text;
                }
                else if (RBtn_3.Checked == true)
                {
                    checkAnswer(RBtn_3);
                    AnswerSelect = RBtn_3.Text;
                }
                else if (RBtn_4.Checked == true)
                {
                    checkAnswer(RBtn_4);
                    AnswerSelect = RBtn_4.Text;
                }
                questionshits++;

                string tipoExamen = "asignacion";

                if (Sesion.typeTest == 2)
                {
                    tipoExamen = "liberacion";
                }

                Sesion.ExamStudent.Add(new ModelQuestionGrammar { Question = GBx_Pre.Text, optionA = AnswerSelect, optionCorrect = answerCorrect, difficulty = level, section = "Grammar", tipoTest = tipoExamen, dateTime = DateTime.Now });
                numQuestions++;
                //Se borra el check en los RB
                RBtn_1.Checked = false;
                RBtn_2.Checked = false;
                RBtn_3.Checked = false;
                RBtn_4.Checked = false;

                if (questionshits >= 2)
                {
                    //Si contesta dos correctas seguidas
                    if (hits >= 2 && level < 4)
                    {
                        level++;
                    }
                    //Si se equivoica dos veces seguidas
                    else if (hits < 1 && level > 1)
                    {
                        level--;
                    }
                    questionshits = 0;
                    hits = 0;
                }

                if (numQuestions < (numTotalQuestions - 1)) { showQuestions(); }
                else { showQuestions(); Btn_Finish.Visible = true; Btn_Next.Visible = false; }

            }
        }
        // BOTÓN para Terminar la sección.
        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (RBtn_1.Checked == true || RBtn_2.Checked == true || RBtn_3.Checked == true || RBtn_4.Checked == true)
            {
                string AnswerSelect = "";
                if (RBtn_1.Checked == true) { checkAnswer(RBtn_1); AnswerSelect = RBtn_1.Text; }
                else if (RBtn_2.Checked == true) { checkAnswer(RBtn_2); AnswerSelect = RBtn_2.Text; }
                else if (RBtn_3.Checked == true) { checkAnswer(RBtn_3); AnswerSelect = RBtn_3.Text; }
                else if (RBtn_4.Checked == true) { checkAnswer(RBtn_4); AnswerSelect = RBtn_4.Text; }

                string tipoExamen = "asignacion";

                if (Sesion.typeTest == 2)
                {
                    tipoExamen = "liberacion";
                    Sesion.ExamStudent.Add(new ModelQuestionGrammar { Question = GBx_Pre.Text, optionA = AnswerSelect, optionCorrect = answerCorrect, difficulty = level, section = "Grammar", tipoTest = tipoExamen, dateTime = DateTime.Now });
                    var form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    Form1 padre = form ?? new Form1();
                    padre.OpenWindow(new FormListen());
                    padre.lbl_Section.Text = "Listen";
                }
                else
                {
                    MessageBox.Show("Has terminado el examen de asinacion de ingles", "Examen finalizado", MessageBoxButtons.OK);
                    Sesion.ExamStudent.Add(new ModelQuestionGrammar { Question = GBx_Pre.Text, optionA = AnswerSelect, optionCorrect = answerCorrect, difficulty = level, section = "Grammar", tipoTest = tipoExamen, dateTime = DateTime.Now });
                    Modelo modelo = new Modelo();
                    modelo.SaveExam();
                    exportData();
                    Form form = new FormLogin();
                    form.Show();
                    var form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    Form1 padre = form1 ?? new Form1();
                    Sesion.ExamStudent = null;
                    padre.Close();
                    Application.Exit();
                }

            }
        }

        // METODO para cargar preguntas.
        private void loadQuestions()
        {
            // El tipo de test 1 es de asignacion.
            if (Sesion.typeTest == 1)
                numTotalQuestions = 80;
            // Si es un examen de librecion seran 120 preguntas
            else
                numTotalQuestions = 120;
            listQuestionLvl1 = model.ConsultQuestions(1, numTotalQuestions);
            listQuestionLvl2 = model.ConsultQuestions(2, numTotalQuestions);
            listQuestionLvl3 = model.ConsultQuestions(3, numTotalQuestions);
            listQuestionLvl4 = model.ConsultQuestions(4, numTotalQuestions);
        }
        // METODO para mostrar preguntas.
        private void showQuestions()
        {
            int x = numTotalQuestions;
            // Mostrar el numero y nivel de la pregunta
            Lbl_Nivel.Text = "Level : " + level; //(opcion oculta para el alumno)
            Lbl_NumQuestion.Text = "Question " + (numQuestions+1) + " - " + numTotalQuestions;
            
            List<string> listaDes = new List<string>();
            List<string> listOrd = new List<string>();

            // Condicion utilizada por falta de preguntas.
               // Cuando el alumno se mantiene en un solo nivel y se terminan las preguntas de la
               // sección disponibles en la base, con estas condiciones se pasa a otro nivel.
               // CON MAS PREGUNTAS EN LA BASE NO SE REQUIERE ESTAS LINEAS.
            if (NumQuestionsLvl1 == listQuestionLvl1.Count)
            {
                if (NumQuestionsLvl2 < listQuestionLvl2.Count) 
                { 
                    level = 2; 
                }
                else 
                {  
                    level = 3; 
                }
            }
            // Dependiendo el nivel en el que se encuentre seleccionara una nueva pregunta.
            switch (level)
            {
                // Cada caso añade la pregunta y sus respuestas dependiendo el nivel (A1, A2, B1, B2).
                case 1:
                    GBx_Pre.Text = listQuestionLvl1[NumQuestionsLvl1].Question;
                    listaDes.Add(listQuestionLvl1[NumQuestionsLvl1].optionA);
                    listaDes.Add(listQuestionLvl1[NumQuestionsLvl1].optionB);
                    listaDes.Add(listQuestionLvl1[NumQuestionsLvl1].optionC);
                    listaDes.Add(listQuestionLvl1[NumQuestionsLvl1].optionD);
                    break;
                case 2:
                    GBx_Pre.Text = listQuestionLvl2[NumQuestionsLvl2].Question;
                    listaDes.Add(listQuestionLvl2[NumQuestionsLvl2].optionA);
                    listaDes.Add(listQuestionLvl2[NumQuestionsLvl2].optionB);
                    listaDes.Add(listQuestionLvl2[NumQuestionsLvl2].optionC);
                    listaDes.Add(listQuestionLvl2[NumQuestionsLvl2].optionD);
                    break;
                case 3:
                    GBx_Pre.Text = listQuestionLvl3[NumQuestionsLvl3].Question;
                    listaDes.Add(listQuestionLvl3[NumQuestionsLvl3].optionA);
                    listaDes.Add(listQuestionLvl3[NumQuestionsLvl3].optionB);
                    listaDes.Add(listQuestionLvl3[NumQuestionsLvl3].optionC);
                    listaDes.Add(listQuestionLvl3[NumQuestionsLvl3].optionD);
                    break;
                case 4:
                    GBx_Pre.Text = listQuestionLvl4[NumQuestionsLvl4].Question;
                    listaDes.Add(listQuestionLvl4[NumQuestionsLvl4].optionA);
                    listaDes.Add(listQuestionLvl4[NumQuestionsLvl4].optionB);
                    listaDes.Add(listQuestionLvl4[NumQuestionsLvl4].optionC);
                    listaDes.Add(listQuestionLvl4[NumQuestionsLvl4].optionD);
                    break;
            }
            // Ordenar la lista de respuestas para la pregunta
            while (listOrd.Count < 4)
            {
                Random random = new Random();
                int rand = random.Next(0, 4);
                if (!listOrd.Contains(listaDes[rand]))
                {
                    listOrd.Add(listaDes[rand]);
                }
            }
            // Asignar textos a los RB segun el random anterior
            RBtn_1.Text = listOrd[0];
            RBtn_2.Text = listOrd[1];
            RBtn_3.Text = listOrd[2];
            RBtn_4.Text = listOrd[3];
        }   
        // EVENTO para usar el teclado para seleccionar las respuestas.
        private void Btn_Next_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1') { RBtn_1.Checked = true; }
            if (e.KeyChar == '2') { RBtn_2.Checked = true; }
            if (e.KeyChar == '3') { RBtn_3.Checked = true; }
            if (e.KeyChar == '4') { RBtn_4.Checked = true; }
        }
        
        // METODO para revisar las respuestas
        private void checkAnswer(RadioButton rb)
        {
            switch (level)
            {
                // Dependiendo el nivel aumentara el contador de respuestas correctas y el total de preguntas por nivel
                case 1:
                    if (rb.Text == listQuestionLvl1[NumQuestionsLvl1].optionCorrect) { hits++; }
                    answerCorrect = listQuestionLvl1[NumQuestionsLvl1].optionCorrect;
                    NumQuestionsLvl1++;
                    break;
                case 2:
                    if (rb.Text == listQuestionLvl2[NumQuestionsLvl2].optionCorrect) { hits++; }
                    answerCorrect = listQuestionLvl2[NumQuestionsLvl2].optionCorrect;
                    NumQuestionsLvl2++;
                    break;
                case 3:
                    if (rb.Text == listQuestionLvl3[NumQuestionsLvl3].optionCorrect) { hits++; }
                    answerCorrect = listQuestionLvl3[NumQuestionsLvl3].optionCorrect;
                    NumQuestionsLvl3++;
                    break;
                case 4:
                    if (rb.Text == listQuestionLvl4[NumQuestionsLvl4].optionCorrect) { hits++; }
                    answerCorrect = listQuestionLvl4[NumQuestionsLvl4].optionCorrect;
                    NumQuestionsLvl4++;
                    break;
            }
        }
        // METODO para exportar tablas
        void exportData()
        {

            string namefile = Usuarios.NombreA + ".xlsx";
            string basepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = basepath + "/" + Usuarios.NombreA;
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

            DataTable dt = new DataTable();
            dt.Columns.Add("IdExamen", typeof(string));
            dt.Columns.Add("NombreAlumno", typeof(string));
            dt.Columns.Add("Pregunta", typeof(string));
            dt.Columns.Add("Respuesta", typeof(string));
            dt.Columns.Add("Respuesta Correcta", typeof(string));
            dt.Columns.Add("Nivel", typeof(string));
            dt.Columns.Add("Seccion", typeof(string));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Tipo Examen", typeof(string));
            dt.Columns.Add("Resultado", typeof(string));
            int numQuestion = 1;
            foreach (var list in Sesion.ExamStudent)
            {
                DataRow row = dt.NewRow();
                row["IdExamen"] = Sesion.idExam;
                row["NombreAlumno"] = Usuarios.NombreA;
                row["Pregunta"] = list.Question;
                row["Respuesta"] = list.optionA;
                row["Respuesta Correcta"] = list.optionCorrect;
                row["Nivel"] = list.difficulty;
                row["Seccion"] = list.section;
                row["Fecha"] = list.dateTime;
                row["Tipo Examen"] = list.tipoTest;
                string resultado = "Incorrecto";
                if (list.Question != null)
                {
                    if (list.optionA == list.optionCorrect)
                    {
                        typeExam = list.tipoTest;
                        resultado = "Correcto";
                        switch (list.section)
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
                    switch (list.section)
                    {
                        case "Grammar":
                            dtGraphic.Rows.Add(numQuestion, Convert.ToInt32(list.difficulty));
                            numQuestion++;
                            break;
                    }
                    row["Resultado"] = resultado;
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
            }
            catch
            {
                MessageBox.Show("Archivo en uso");
            }
        }

    }
}