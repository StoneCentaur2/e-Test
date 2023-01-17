
namespace Test_E
{
    partial class FormTutorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.Rb_4 = new System.Windows.Forms.RadioButton();
            this.Rb_2 = new System.Windows.Forms.RadioButton();
            this.Rb_3 = new System.Windows.Forms.RadioButton();
            this.Rb_1 = new System.Windows.Forms.RadioButton();
            this.cbxStep2 = new System.Windows.Forms.CheckBox();
            this.cbxStep1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEmpezar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "                            Bienvenido a tu examen de ingles\r\npor favor lee las i" +
    "nstrucciones que se mostraran a continuación";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::Test_E.Properties.Resources.stop30;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(137, 126);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 10;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Test_E.Properties.Resources.play30;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(81, 126);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.Rb_4);
            this.groupBox1.Controls.Add(this.Rb_2);
            this.groupBox1.Controls.Add(this.Rb_3);
            this.groupBox1.Controls.Add(this.Rb_1);
            this.groupBox1.Location = new System.Drawing.Point(137, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 103);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Cuánto es 1+1?";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(160, 60);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(200, 34);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "Next";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Rb_4
            // 
            this.Rb_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rb_4.AutoSize = true;
            this.Rb_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rb_4.Location = new System.Drawing.Point(419, 28);
            this.Rb_4.Name = "Rb_4";
            this.Rb_4.Size = new System.Drawing.Size(37, 25);
            this.Rb_4.TabIndex = 14;
            this.Rb_4.TabStop = true;
            this.Rb_4.Text = "4";
            this.Rb_4.UseVisualStyleBackColor = true;
            // 
            // Rb_2
            // 
            this.Rb_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rb_2.AutoSize = true;
            this.Rb_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rb_2.Location = new System.Drawing.Point(174, 28);
            this.Rb_2.Name = "Rb_2";
            this.Rb_2.Size = new System.Drawing.Size(37, 25);
            this.Rb_2.TabIndex = 1;
            this.Rb_2.TabStop = true;
            this.Rb_2.Text = "2";
            this.Rb_2.UseVisualStyleBackColor = true;
            // 
            // Rb_3
            // 
            this.Rb_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rb_3.AutoSize = true;
            this.Rb_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rb_3.Location = new System.Drawing.Point(308, 28);
            this.Rb_3.Name = "Rb_3";
            this.Rb_3.Size = new System.Drawing.Size(37, 25);
            this.Rb_3.TabIndex = 13;
            this.Rb_3.TabStop = true;
            this.Rb_3.Text = "3";
            this.Rb_3.UseVisualStyleBackColor = true;
            // 
            // Rb_1
            // 
            this.Rb_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rb_1.AutoSize = true;
            this.Rb_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rb_1.Location = new System.Drawing.Point(56, 28);
            this.Rb_1.Name = "Rb_1";
            this.Rb_1.Size = new System.Drawing.Size(37, 25);
            this.Rb_1.TabIndex = 0;
            this.Rb_1.TabStop = true;
            this.Rb_1.Text = "1";
            this.Rb_1.UseVisualStyleBackColor = true;
            // 
            // cbxStep2
            // 
            this.cbxStep2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxStep2.AutoSize = true;
            this.cbxStep2.Enabled = false;
            this.cbxStep2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStep2.Location = new System.Drawing.Point(58, 168);
            this.cbxStep2.Name = "cbxStep2";
            this.cbxStep2.Size = new System.Drawing.Size(625, 25);
            this.cbxStep2.TabIndex = 13;
            this.cbxStep2.Text = "El examen es de opción múltiple, selecciona la respuesta que creas correcta.";
            this.cbxStep2.UseVisualStyleBackColor = true;
            // 
            // cbxStep1
            // 
            this.cbxStep1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxStep1.AutoSize = true;
            this.cbxStep1.Enabled = false;
            this.cbxStep1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStep1.Location = new System.Drawing.Point(58, 93);
            this.cbxStep1.Name = "cbxStep1";
            this.cbxStep1.Size = new System.Drawing.Size(476, 25);
            this.cbxStep1.TabIndex = 14;
            this.cbxStep1.Text = "Haz clic en el bóton para reproducir la prueba de sonido.";
            this.cbxStep1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Algunas preguntas tienen un texto del cual debes obtener la respuesta.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(696, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "El examen está dividido en 3 partes \"Grammar\", \"Listen\" y \"Reading\". Cuando termi" +
    "nes una sección \r\npasaras automáticamente a la siguiente.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Recuerda que hay un tiempo limite de 2 horas.";
            // 
            // BtnEmpezar
            // 
            this.BtnEmpezar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEmpezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpezar.FlatAppearance.BorderSize = 0;
            this.BtnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpezar.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpezar.ForeColor = System.Drawing.Color.White;
            this.BtnEmpezar.Location = new System.Drawing.Point(297, 511);
            this.BtnEmpezar.Name = "BtnEmpezar";
            this.BtnEmpezar.Size = new System.Drawing.Size(200, 42);
            this.BtnEmpezar.TabIndex = 16;
            this.BtnEmpezar.Text = "Empezar";
            this.BtnEmpezar.UseVisualStyleBackColor = false;
            this.BtnEmpezar.Click += new System.EventHandler(this.BtnEmpezar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(352, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "¡ Exito !";
            // 
            // FormTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEmpezar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxStep1);
            this.Controls.Add(this.cbxStep2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTutorial";
            this.Text = "FormTutorial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_2;
        private System.Windows.Forms.RadioButton Rb_3;
        private System.Windows.Forms.RadioButton Rb_1;
        private System.Windows.Forms.RadioButton Rb_4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.CheckBox cbxStep2;
        private System.Windows.Forms.CheckBox cbxStep1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEmpezar;
        private System.Windows.Forms.Label label5;
    }
}