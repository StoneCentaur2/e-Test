using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace Test_E
{
    public partial class FormListen : Form
    {
        public FormListen()
        {
            InitializeComponent();
            if (Sesion.typeTest == 1)
            {
                cantaudios = 10;
            }
            else
            {
                cantaudios = 20;

            }
            LoadAudios();
            showQuestionAudio();
        }
        Modelo modelo = new Modelo();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<ModelQuestionAudio> list = new List<ModelQuestionAudio>();
        int numQuestionAudio = 0;
        string[] URLAudios;
        int rep = 0;
        int points = 0;
        int cantaudios = 0;
        string answerSelect = "";
        private void LoadAudios()
        {
            list = modelo.ConsultQuestionsAudio(cantaudios);
            URLAudios = createFileAudio(list);
        }
        private String[] createFileAudio(List<ModelQuestionAudio> list)
        {
            string directorio = AppDomain.CurrentDomain.BaseDirectory;
            string carpeta = directorio + "/temp/";
            string[] URLS = new string[cantaudios];
            int numAudio = 0;
            foreach (var audio in list)
            {
                Stream stream = audio.audio;
                MemoryStream memoryStream = new MemoryStream();
                stream.CopyTo(memoryStream);
                byte[] fileAudio = memoryStream.ToArray();
                string directorioCompleto = carpeta + audio.name;
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);
                if (File.Exists(directorioCompleto))
                    File.Delete(directorioCompleto);
                Directory.CreateDirectory(carpeta);
                File.WriteAllBytes(directorioCompleto, fileAudio);
                URLS[numAudio] = directorioCompleto;
                numAudio++;
            }
            return URLS;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (rep < 3)
            {
                player.URL = URLAudios[numQuestionAudio];
                player.controls.play();
                rep++;
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void resetRbtn(RadioButton rb) { rb.Checked = false; }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (RBtn_1.Checked == true || RBtn_2.Checked == true || RBtn_3.Checked == true || RBtn_4.Checked == true)
            {
                string tipoExamen = "asignacion";
                if (Sesion.typeTest == 2)
                {
                    tipoExamen = "liberacion";
                }
                player.controls.stop();
                checkAnswer();
                Sesion.ExamStudent.Add(new ModelQuestionGrammar { Question = list[numQuestionAudio].name, optionA = answerSelect, optionCorrect = list[numQuestionAudio].optionCorrect, section = "Listen" , tipoTest = tipoExamen, difficulty = 1, dateTime = DateTime.Now });
                resetRbtn(RBtn_1);
                resetRbtn(RBtn_2);
                resetRbtn(RBtn_3);
                resetRbtn(RBtn_4);
                numQuestionAudio++;
                rep = 0;
                if (numQuestionAudio < cantaudios-1)
                {
                    showQuestionAudio();                }
                else
                {
                    showQuestionAudio();
                    Btn_Next.Visible = false;
                    Btn_Finish.Visible = true;
                }
                    
                
            }
        }
        private void showQuestionAudio()
        {
            Lbl_NumQuestion.Text = "Question " + (numQuestionAudio + 1) + " - " + cantaudios;
            List<string> listaDes = new List<string>();
            List<string> listOrd = new List<string>();
            GBx_Question.Text = "Select your answer";
            listaDes.Add(list[numQuestionAudio].optionA);
            listaDes.Add(list[numQuestionAudio].optionB);
            listaDes.Add(list[numQuestionAudio].optionC);
            listaDes.Add(list[numQuestionAudio].optionD);
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
                if (RBtn_1.Text == list[numQuestionAudio].optionCorrect) { }
                answerSelect = RBtn_1.Text;
            }
            else if (RBtn_2.Checked == true)
            {
                if (RBtn_2.Text == list[numQuestionAudio].optionCorrect) { }
                answerSelect = RBtn_2.Text;
            }
            else if (RBtn_3.Checked == true)
            {
                if (RBtn_3.Text == list[numQuestionAudio].optionCorrect) { }
                answerSelect = RBtn_3.Text;
            }
            else
            {
                if (RBtn_4.Text == list[numQuestionAudio].optionCorrect) { }
                answerSelect = RBtn_4.Text;
            }
        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            if (RBtn_1.Checked == true || RBtn_2.Checked == true || RBtn_3.Checked == true || RBtn_4.Checked == true)
            {
                player.controls.stop();
                checkAnswer();
                string tipoExamen = "asignacion";
                if (Sesion.typeTest == 2)
                {
                    tipoExamen = "liberacion";
                }
                Sesion.ExamStudent.Add(new ModelQuestionGrammar { Question = list[numQuestionAudio].name, optionA = answerSelect, optionCorrect = list[numQuestionAudio].optionCorrect, section = "Listen",tipoTest = tipoExamen, difficulty = 1, dateTime = DateTime.Now });
                resetRbtn(RBtn_1);
                resetRbtn(RBtn_2);
                resetRbtn(RBtn_3);
                resetRbtn(RBtn_4);
                rep = 0;
                if (Sesion.typeTest == 1)
                {
                    MessageBox.Show("Has terminado el examen de asinacion de ingles", "Examen finalizado", MessageBoxButtons.OK);
                    modelo.SaveExam();
                    Form form = new FormLogin();
                    form.Show();
                    var form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    Form1 padre = form1 ?? new Form1();
                    Sesion.ExamStudent = null;
                    padre.Close();
                }
                else
                {
                    var form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    Form1 padre = form ?? new Form1();
                    padre.OpenWindow(new FormReading());
                    padre.lbl_Section.Text = "Reading";
                }
            }
        }
    }
}
