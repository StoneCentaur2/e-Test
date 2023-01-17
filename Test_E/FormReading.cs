using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Test_E
{
    public partial class FormReading : Form
    {
        public FormReading()
        {
            InitializeComponent();
            loadQuestions();
            showQustions();
        }
        Modelo modelo = new Modelo();
        List<ModelQuestionText> listQuestionLvl1 = new List<ModelQuestionText>();
        int numQuestions = 0;
        int hits = 0;
        int canQuestions = 10;
        private void loadQuestions()
        {
            listQuestionLvl1 = modelo.ConsultQuestionsText(canQuestions);
        }
        private void showQustions()
        {
            List<string> listaDes = new List<string>();
            List<string> listOrd = new List<string>();
            txt_.Text = listQuestionLvl1[numQuestions].Text;
            GBx_Question.Text = listQuestionLvl1[numQuestions].Question;
            listaDes.Add(listQuestionLvl1[numQuestions].optionA);
            listaDes.Add(listQuestionLvl1[numQuestions].optionB);
            listaDes.Add(listQuestionLvl1[numQuestions].optionC);
            listaDes.Add(listQuestionLvl1[numQuestions].optionD);
            while (listOrd.Count < 4)
            {
                Random random = new Random();
                int rand = random.Next(0, 4);
                if (!listOrd.Contains(listaDes[rand]))
                {
                    listOrd.Add(listaDes[rand]);
                }
            }
            RBtn_1.Text = listOrd[0];
            RBtn_2.Text = listOrd[1];
            RBtn_3.Text = listOrd[2];
            RBtn_4.Text = listOrd[3];
        }
        private void checkAnswer()
        {
            if (RBtn_1.Checked == true)
            {
                if (RBtn_1.Text == listQuestionLvl1[numQuestions].optionCorrect) { hits++; }
                answerSelect = RBtn_1.Text;
            }
            else if (RBtn_2.Checked == true)
            {
                if (RBtn_2.Text == listQuestionLvl1[numQuestions].optionCorrect) { hits++; }
                answerSelect = RBtn_2.Text;
            }
            else if (RBtn_3.Checked == true)
            {
                if (RBtn_3.Text == listQuestionLvl1[numQuestions].optionCorrect) { hits++; }
                answerSelect = RBtn_3.Text;
            }
            else
            {
                if (RBtn_4.Text == listQuestionLvl1[numQuestions].optionCorrect) { hits++; }
                answerSelect = RBtn_4.Text;
            }
        }
        private void ResetRb(RadioButton rb) { rb.Checked = false; }
        string answerSelect = "";

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (RBtn_1.Checked == true || RBtn_2.Checked == true || RBtn_3.Checked == true || RBtn_4.Checked == true)
            {
                string tipoExamen = "asignacion";
                if (Sesion.typeTest == 2)
                {
                    tipoExamen = "liberacion";
                }
                checkAnswer();
                Sesion.ExamStudent.Add(new ModelQuestionGrammar { Question = listQuestionLvl1[numQuestions].Question, optionA = answerSelect, optionCorrect = listQuestionLvl1[numQuestions].optionCorrect, section = "Reading", tipoTest = tipoExamen, difficulty = 1, dateTime = DateTime.Now });
                ResetRb(RBtn_1);
                ResetRb(RBtn_2);
                ResetRb(RBtn_3);
                ResetRb(RBtn_4);
                numQuestions++;
                if (numQuestions < (canQuestions - 1))
                {
                    showQustions();
                }
                else
                {
                    Btn_Next.Visible = false;
                    Btn_Finish.Visible = true;
                    showQustions();
                }
            }
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (RBtn_1.Checked == true || RBtn_2.Checked == true || RBtn_3.Checked == true || RBtn_4.Checked == true)
            {
                checkAnswer();
                string tipoExamen = "asignacion";
                if (Sesion.typeTest == 2)
                {
                    tipoExamen = "liberacion";
                }
                Sesion.ExamStudent.Add(new ModelQuestionGrammar { Question = listQuestionLvl1[numQuestions].Question, optionA = answerSelect, optionCorrect = listQuestionLvl1[numQuestions].optionCorrect, section = "Reading" , tipoTest = tipoExamen, difficulty = 1, dateTime = DateTime.Now });
                ResetRb(RBtn_1);
                ResetRb(RBtn_2);
                ResetRb(RBtn_3);
                ResetRb(RBtn_4);
                MessageBox.Show("Has terminado el examen de Liberacion de ingles", "Examen finalizado", MessageBoxButtons.OK);
                modelo.SaveExam();
                Form form = new FormLogin();
                form.Show();
                var form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                Form1 padre = form1 ?? new Form1();
                Sesion.ExamStudent = null;
                padre.Close();
            }
        }
    }
}
