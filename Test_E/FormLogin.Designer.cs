
namespace Test_E
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pssO = new System.Windows.Forms.PictureBox();
            this.pssC = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_Liber = new System.Windows.Forms.RadioButton();
            this.Rb_Asig = new System.Windows.Forms.RadioButton();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pssO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pssC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUser.Location = new System.Drawing.Point(479, 196);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(250, 33);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "User";
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUser_MouseDown);
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPass.Location = new System.Drawing.Point(479, 241);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(250, 33);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Password";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPass_MouseDown);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(479, 493);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(284, 38);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(479, 541);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(284, 38);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.BackColor = System.Drawing.Color.Coral;
            this.btnAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumno.FlatAppearance.BorderSize = 0;
            this.btnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumno.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAlumno.Location = new System.Drawing.Point(79, 541);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(284, 38);
            this.btnAlumno.TabIndex = 19;
            this.btnAlumno.Text = "Test";
            this.btnAlumno.UseVisualStyleBackColor = false;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(115, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Si estas por iniciar tu examen\r\nhaz clic en el botón de abajo:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = global::Test_E.Properties.Resources.Encabezado;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test_E.Properties.Resources.Estudiante2;
            this.pictureBox2.Location = new System.Drawing.Point(182, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test_E.Properties.Resources.Usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(556, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 83);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pssO
            // 
            this.pssO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pssO.Image = global::Test_E.Properties.Resources.o_eye32;
            this.pssO.Location = new System.Drawing.Point(762, 244);
            this.pssO.Name = "pssO";
            this.pssO.Size = new System.Drawing.Size(26, 26);
            this.pssO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pssO.TabIndex = 16;
            this.pssO.TabStop = false;
            this.pssO.Visible = false;
            this.pssO.Click += new System.EventHandler(this.pssO_Click);
            // 
            // pssC
            // 
            this.pssC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pssC.Image = global::Test_E.Properties.Resources.c_eye32;
            this.pssC.Location = new System.Drawing.Point(736, 247);
            this.pssC.Name = "pssC";
            this.pssC.Size = new System.Drawing.Size(25, 25);
            this.pssC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pssC.TabIndex = 15;
            this.pssC.TabStop = false;
            this.pssC.Click += new System.EventHandler(this.pssC_Click);
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNom.Location = new System.Drawing.Point(38, 196);
            this.txtNom.Margin = new System.Windows.Forms.Padding(6);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(367, 33);
            this.txtNom.TabIndex = 27;
            this.txtNom.Text = "Nombre(s)";
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            this.txtNom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNom_MouseDown);
            // 
            // txtApe
            // 
            this.txtApe.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApe.Location = new System.Drawing.Point(38, 240);
            this.txtApe.Margin = new System.Windows.Forms.Padding(6);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(367, 33);
            this.txtApe.TabIndex = 28;
            this.txtApe.Text = "Apellidos";
            this.txtApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApe_KeyPress);
            this.txtApe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtApe_MouseDown);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Administración",
            "Civil",
            "Industrial",
            "Sistemas"});
            this.cmbCarrera.Location = new System.Drawing.Point(193, 374);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(213, 34);
            this.cmbCarrera.TabIndex = 30;
            this.cmbCarrera.Click += new System.EventHandler(this.cmbCarrera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Liber);
            this.groupBox1.Controls.Add(this.Rb_Asig);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 68);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Examen";
            // 
            // Rb_Liber
            // 
            this.Rb_Liber.AutoSize = true;
            this.Rb_Liber.Location = new System.Drawing.Point(225, 28);
            this.Rb_Liber.Name = "Rb_Liber";
            this.Rb_Liber.Size = new System.Drawing.Size(100, 25);
            this.Rb_Liber.TabIndex = 1;
            this.Rb_Liber.Text = "Liberación";
            this.Rb_Liber.UseVisualStyleBackColor = true;
            // 
            // Rb_Asig
            // 
            this.Rb_Asig.AutoSize = true;
            this.Rb_Asig.Checked = true;
            this.Rb_Asig.Location = new System.Drawing.Point(41, 28);
            this.Rb_Asig.Name = "Rb_Asig";
            this.Rb_Asig.Size = new System.Drawing.Size(104, 25);
            this.Rb_Asig.TabIndex = 0;
            this.Rb_Asig.TabStop = true;
            this.Rb_Asig.Text = "Asignación";
            this.Rb_Asig.UseVisualStyleBackColor = true;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbSemestre.Location = new System.Drawing.Point(193, 327);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(212, 34);
            this.cmbSemestre.TabIndex = 32;
            this.cmbSemestre.Click += new System.EventHandler(this.cmbSemestre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(187, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(564, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Teacher";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(442, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 501);
            this.panel1.TabIndex = 35;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(192, 283);
            this.txtNum.Mask = "00000000";
            this.txtNum.Name = "txtNum";
            this.txtNum.PromptChar = '-';
            this.txtNum.Size = new System.Drawing.Size(214, 33);
            this.txtNum.TabIndex = 36;
            this.txtNum.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(34, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Numero de control : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(101, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Semestre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(115, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Carrera :";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSemestre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pssO);
            this.Controls.Add(this.pssC);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pssO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pssC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pssO;
        private System.Windows.Forms.PictureBox pssC;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Liber;
        private System.Windows.Forms.RadioButton Rb_Asig;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}