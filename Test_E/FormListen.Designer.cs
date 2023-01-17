
namespace Test_E
{
    partial class FormListen
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
            this.Lbl_Instruction = new System.Windows.Forms.Label();
            this.Lbl_NumQuestion = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.GBx_Question = new System.Windows.Forms.GroupBox();
            this.RBtn_4 = new System.Windows.Forms.RadioButton();
            this.RBtn_3 = new System.Windows.Forms.RadioButton();
            this.RBtn_2 = new System.Windows.Forms.RadioButton();
            this.RBtn_1 = new System.Windows.Forms.RadioButton();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Finish = new System.Windows.Forms.Button();
            this.GBx_Question.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Instruction
            // 
            this.Lbl_Instruction.AutoSize = true;
            this.Lbl_Instruction.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Instruction.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instruction.ForeColor = System.Drawing.Color.Teal;
            this.Lbl_Instruction.Location = new System.Drawing.Point(24, 27);
            this.Lbl_Instruction.Name = "Lbl_Instruction";
            this.Lbl_Instruction.Size = new System.Drawing.Size(312, 21);
            this.Lbl_Instruction.TabIndex = 0;
            this.Lbl_Instruction.Text = "Listen audio and answer the questions";
            // 
            // Lbl_NumQuestion
            // 
            this.Lbl_NumQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_NumQuestion.AutoSize = true;
            this.Lbl_NumQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumQuestion.Location = new System.Drawing.Point(344, 70);
            this.Lbl_NumQuestion.Name = "Lbl_NumQuestion";
            this.Lbl_NumQuestion.Size = new System.Drawing.Size(112, 21);
            this.Lbl_NumQuestion.TabIndex = 1;
            this.Lbl_NumQuestion.Text = "Num Question";
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Location = new System.Drawing.Point(300, 132);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(200, 36);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "PLAY";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.Btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Stop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stop.ForeColor = System.Drawing.Color.White;
            this.Btn_Stop.Location = new System.Drawing.Point(300, 188);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(200, 36);
            this.Btn_Stop.TabIndex = 3;
            this.Btn_Stop.Text = "STOP";
            this.Btn_Stop.UseVisualStyleBackColor = false;
            this.Btn_Stop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // GBx_Question
            // 
            this.GBx_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GBx_Question.Controls.Add(this.RBtn_4);
            this.GBx_Question.Controls.Add(this.RBtn_3);
            this.GBx_Question.Controls.Add(this.RBtn_2);
            this.GBx_Question.Controls.Add(this.RBtn_1);
            this.GBx_Question.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx_Question.Location = new System.Drawing.Point(14, 272);
            this.GBx_Question.Name = "GBx_Question";
            this.GBx_Question.Size = new System.Drawing.Size(773, 182);
            this.GBx_Question.TabIndex = 4;
            this.GBx_Question.TabStop = false;
            this.GBx_Question.Text = "Question";
            // 
            // RBtn_4
            // 
            this.RBtn_4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RBtn_4.AutoSize = true;
            this.RBtn_4.Location = new System.Drawing.Point(10, 141);
            this.RBtn_4.Name = "RBtn_4";
            this.RBtn_4.Size = new System.Drawing.Size(105, 29);
            this.RBtn_4.TabIndex = 3;
            this.RBtn_4.TabStop = true;
            this.RBtn_4.Text = "Option C";
            this.RBtn_4.UseVisualStyleBackColor = true;
            // 
            // RBtn_3
            // 
            this.RBtn_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RBtn_3.AutoSize = true;
            this.RBtn_3.Location = new System.Drawing.Point(10, 106);
            this.RBtn_3.Name = "RBtn_3";
            this.RBtn_3.Size = new System.Drawing.Size(105, 29);
            this.RBtn_3.TabIndex = 2;
            this.RBtn_3.TabStop = true;
            this.RBtn_3.Text = "Option C";
            this.RBtn_3.UseVisualStyleBackColor = true;
            // 
            // RBtn_2
            // 
            this.RBtn_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RBtn_2.AutoSize = true;
            this.RBtn_2.Location = new System.Drawing.Point(10, 71);
            this.RBtn_2.Name = "RBtn_2";
            this.RBtn_2.Size = new System.Drawing.Size(104, 29);
            this.RBtn_2.TabIndex = 1;
            this.RBtn_2.TabStop = true;
            this.RBtn_2.Text = "Option B";
            this.RBtn_2.UseVisualStyleBackColor = true;
            // 
            // RBtn_1
            // 
            this.RBtn_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RBtn_1.AutoSize = true;
            this.RBtn_1.Location = new System.Drawing.Point(10, 36);
            this.RBtn_1.Name = "RBtn_1";
            this.RBtn_1.Size = new System.Drawing.Size(105, 29);
            this.RBtn_1.TabIndex = 0;
            this.RBtn_1.TabStop = true;
            this.RBtn_1.Text = "Option A";
            this.RBtn_1.UseVisualStyleBackColor = true;
            // 
            // Btn_Next
            // 
            this.Btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Next.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.ForeColor = System.Drawing.Color.White;
            this.Btn_Next.Location = new System.Drawing.Point(300, 475);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(200, 36);
            this.Btn_Next.TabIndex = 5;
            this.Btn_Next.Text = "NEXT";
            this.Btn_Next.UseVisualStyleBackColor = false;
            this.Btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Btn_Finish
            // 
            this.Btn_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Btn_Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Finish.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finish.ForeColor = System.Drawing.Color.White;
            this.Btn_Finish.Location = new System.Drawing.Point(300, 531);
            this.Btn_Finish.Name = "Btn_Finish";
            this.Btn_Finish.Size = new System.Drawing.Size(200, 36);
            this.Btn_Finish.TabIndex = 6;
            this.Btn_Finish.Text = "FINISH";
            this.Btn_Finish.UseVisualStyleBackColor = false;
            this.Btn_Finish.Visible = false;
            this.Btn_Finish.Click += new System.EventHandler(this.Btn_Finish_Click);
            // 
            // FormListen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Btn_Finish);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.GBx_Question);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.Lbl_NumQuestion);
            this.Controls.Add(this.Lbl_Instruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListen";
            this.Text = "FormListen";
            this.GBx_Question.ResumeLayout(false);
            this.GBx_Question.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Instruction;
        private System.Windows.Forms.Label Lbl_NumQuestion;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.GroupBox GBx_Question;
        private System.Windows.Forms.RadioButton RBtn_4;
        private System.Windows.Forms.RadioButton RBtn_3;
        private System.Windows.Forms.RadioButton RBtn_2;
        private System.Windows.Forms.RadioButton RBtn_1;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Finish;
    }
}