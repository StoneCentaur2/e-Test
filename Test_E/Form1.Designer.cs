
namespace Test_E
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnR = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbl_Section = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblTiempo);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.btnE);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnG);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 600);
            this.panel1.TabIndex = 0;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(58, 64);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(84, 28);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "0:00:00";
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnR.FlatAppearance.BorderSize = 0;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.ForeColor = System.Drawing.Color.White;
            this.btnR.Location = new System.Drawing.Point(0, 244);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(200, 50);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Reading";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnE
            // 
            this.btnE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnE.AutoSize = true;
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.Location = new System.Drawing.Point(0, 538);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(200, 50);
            this.btnE.TabIndex = 6;
            this.btnE.Text = "Exit";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnS
            // 
            this.btnS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnS.AutoSize = true;
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Location = new System.Drawing.Point(0, 477);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(200, 50);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "Settings";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL.FlatAppearance.BorderSize = 0;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.ForeColor = System.Drawing.Color.White;
            this.btnL.Location = new System.Drawing.Point(0, 356);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(200, 50);
            this.btnL.TabIndex = 4;
            this.btnL.Text = "Listening";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnG.FlatAppearance.BorderSize = 0;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.ForeColor = System.Drawing.Color.White;
            this.btnG.Location = new System.Drawing.Point(0, 300);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(200, 50);
            this.btnG.TabIndex = 3;
            this.btnG.Text = "Grammar";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lbl_Section);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 50);
            this.panel2.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(576, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 28);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lbl_Section
            // 
            this.lbl_Section.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Section.AutoSize = true;
            this.lbl_Section.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Section.ForeColor = System.Drawing.Color.White;
            this.lbl_Section.Location = new System.Drawing.Point(219, 9);
            this.lbl_Section.Name = "lbl_Section";
            this.lbl_Section.Size = new System.Drawing.Size(70, 28);
            this.lbl_Section.TabIndex = 1;
            this.lbl_Section.Text = "Menu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Test";
            // 
            // windowPanel
            // 
            this.windowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowPanel.Location = new System.Drawing.Point(200, 50);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(800, 600);
            this.windowPanel.TabIndex = 2;
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.windowPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lbl_Section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel windowPanel;
        public System.Windows.Forms.Label lblTiempo;
        public System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

