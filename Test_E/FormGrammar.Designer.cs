
namespace Test_E
{
    partial class FormGrammar
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
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Lbl_Intruction = new System.Windows.Forms.Label();
            this.Btn_Finish = new System.Windows.Forms.Button();
            this.Lbl_NumQuestion = new System.Windows.Forms.Label();
            this.GBx_Pre = new System.Windows.Forms.GroupBox();
            this.RBtn_4 = new System.Windows.Forms.RadioButton();
            this.RBtn_3 = new System.Windows.Forms.RadioButton();
            this.RBtn_2 = new System.Windows.Forms.RadioButton();
            this.RBtn_1 = new System.Windows.Forms.RadioButton();
            this.Lbl_Nivel = new System.Windows.Forms.Label();
            this.GBx_Pre.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Next
            // 
            this.Btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Next.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.ForeColor = System.Drawing.Color.White;
            this.Btn_Next.Location = new System.Drawing.Point(299, 452);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(200, 50);
            this.Btn_Next.TabIndex = 4;
            this.Btn_Next.Text = "NEXT";
            this.Btn_Next.UseVisualStyleBackColor = false;
            this.Btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            this.Btn_Next.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_Next_KeyPress);
            // 
            // Lbl_Intruction
            // 
            this.Lbl_Intruction.AutoSize = true;
            this.Lbl_Intruction.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Intruction.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Intruction.ForeColor = System.Drawing.Color.Teal;
            this.Lbl_Intruction.Location = new System.Drawing.Point(15, 20);
            this.Lbl_Intruction.Name = "Lbl_Intruction";
            this.Lbl_Intruction.Size = new System.Drawing.Size(258, 21);
            this.Lbl_Intruction.TabIndex = 5;
            this.Lbl_Intruction.Text = "Answer the following questions";
            // 
            // Btn_Finish
            // 
            this.Btn_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Btn_Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Finish.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finish.ForeColor = System.Drawing.Color.White;
            this.Btn_Finish.Location = new System.Drawing.Point(299, 521);
            this.Btn_Finish.Name = "Btn_Finish";
            this.Btn_Finish.Size = new System.Drawing.Size(200, 50);
            this.Btn_Finish.TabIndex = 6;
            this.Btn_Finish.Text = "FINISH";
            this.Btn_Finish.UseVisualStyleBackColor = false;
            this.Btn_Finish.Visible = false;
            this.Btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // Lbl_NumQuestion
            // 
            this.Lbl_NumQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl_NumQuestion.AutoSize = true;
            this.Lbl_NumQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumQuestion.Location = new System.Drawing.Point(14, 73);
            this.Lbl_NumQuestion.Name = "Lbl_NumQuestion";
            this.Lbl_NumQuestion.Size = new System.Drawing.Size(107, 25);
            this.Lbl_NumQuestion.TabIndex = 7;
            this.Lbl_NumQuestion.Text = "Answer 1 - ";
            this.Lbl_NumQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GBx_Pre
            // 
            this.GBx_Pre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GBx_Pre.Controls.Add(this.RBtn_4);
            this.GBx_Pre.Controls.Add(this.RBtn_3);
            this.GBx_Pre.Controls.Add(this.RBtn_2);
            this.GBx_Pre.Controls.Add(this.RBtn_1);
            this.GBx_Pre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx_Pre.Location = new System.Drawing.Point(13, 152);
            this.GBx_Pre.Name = "GBx_Pre";
            this.GBx_Pre.Size = new System.Drawing.Size(773, 215);
            this.GBx_Pre.TabIndex = 8;
            this.GBx_Pre.TabStop = false;
            this.GBx_Pre.Text = "Question";
            // 
            // RBtn_4
            // 
            this.RBtn_4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RBtn_4.AutoSize = true;
            this.RBtn_4.Location = new System.Drawing.Point(10, 166);
            this.RBtn_4.Name = "RBtn_4";
            this.RBtn_4.Size = new System.Drawing.Size(106, 29);
            this.RBtn_4.TabIndex = 3;
            this.RBtn_4.TabStop = true;
            this.RBtn_4.Text = "Option D";
            this.RBtn_4.UseVisualStyleBackColor = true;
            // 
            // RBtn_3
            // 
            this.RBtn_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RBtn_3.AutoSize = true;
            this.RBtn_3.Location = new System.Drawing.Point(10, 131);
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
            this.RBtn_2.Location = new System.Drawing.Point(10, 96);
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
            this.RBtn_1.Location = new System.Drawing.Point(10, 61);
            this.RBtn_1.Name = "RBtn_1";
            this.RBtn_1.Size = new System.Drawing.Size(105, 29);
            this.RBtn_1.TabIndex = 0;
            this.RBtn_1.TabStop = true;
            this.RBtn_1.Text = "Option A";
            this.RBtn_1.UseVisualStyleBackColor = true;
            // 
            // Lbl_Nivel
            // 
            this.Lbl_Nivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Nivel.AutoSize = true;
            this.Lbl_Nivel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nivel.Location = new System.Drawing.Point(681, 20);
            this.Lbl_Nivel.Name = "Lbl_Nivel";
            this.Lbl_Nivel.Size = new System.Drawing.Size(55, 25);
            this.Lbl_Nivel.TabIndex = 9;
            this.Lbl_Nivel.Text = "Level";
            this.Lbl_Nivel.Visible = false;
            // 
            // FormGrammar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Lbl_Nivel);
            this.Controls.Add(this.GBx_Pre);
            this.Controls.Add(this.Lbl_NumQuestion);
            this.Controls.Add(this.Btn_Finish);
            this.Controls.Add(this.Lbl_Intruction);
            this.Controls.Add(this.Btn_Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGrammar";
            this.Text = "FormGrammar";
            this.GBx_Pre.ResumeLayout(false);
            this.GBx_Pre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Label Lbl_Intruction;
        private System.Windows.Forms.Button Btn_Finish;
        private System.Windows.Forms.Label Lbl_NumQuestion;
        private System.Windows.Forms.GroupBox GBx_Pre;
        private System.Windows.Forms.RadioButton RBtn_4;
        private System.Windows.Forms.RadioButton RBtn_3;
        private System.Windows.Forms.RadioButton RBtn_2;
        private System.Windows.Forms.RadioButton RBtn_1;
        private System.Windows.Forms.Label Lbl_Nivel;
    }
}