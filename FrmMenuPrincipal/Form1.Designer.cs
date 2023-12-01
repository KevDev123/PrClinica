namespace FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.btnHistorCon = new System.Windows.Forms.Button();
            this.btnProgramCon = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pnlPaciente = new System.Windows.Forms.Panel();
            this.btnRegistroPac = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.pnlMedico = new System.Windows.Forms.Panel();
            this.btnRegistroMed = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExpedientePac = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlPaciente.SuspendLayout();
            this.pnlMedico.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.pnlConsulta);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.pnlPaciente);
            this.panel1.Controls.Add(this.btnPaciente);
            this.panel1.Controls.Add(this.pnlMedico);
            this.panel1.Controls.Add(this.btnMedico);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 620);
            this.panel1.TabIndex = 0;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlConsulta.Controls.Add(this.btnHistorCon);
            this.pnlConsulta.Controls.Add(this.btnProgramCon);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsulta.Location = new System.Drawing.Point(0, 424);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(196, 91);
            this.pnlConsulta.TabIndex = 8;
            // 
            // btnHistorCon
            // 
            this.btnHistorCon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorCon.FlatAppearance.BorderSize = 0;
            this.btnHistorCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorCon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorCon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistorCon.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorCon.Image")));
            this.btnHistorCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorCon.Location = new System.Drawing.Point(0, 45);
            this.btnHistorCon.Name = "btnHistorCon";
            this.btnHistorCon.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHistorCon.Size = new System.Drawing.Size(196, 46);
            this.btnHistorCon.TabIndex = 5;
            this.btnHistorCon.Text = "Historial \r\nConsultas\r\n";
            this.btnHistorCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorCon.UseVisualStyleBackColor = true;
            this.btnHistorCon.Click += new System.EventHandler(this.btnHistorCon_Click);
            // 
            // btnProgramCon
            // 
            this.btnProgramCon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProgramCon.FlatAppearance.BorderSize = 0;
            this.btnProgramCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramCon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramCon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProgramCon.Image = ((System.Drawing.Image)(resources.GetObject("btnProgramCon.Image")));
            this.btnProgramCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgramCon.Location = new System.Drawing.Point(0, 0);
            this.btnProgramCon.Name = "btnProgramCon";
            this.btnProgramCon.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProgramCon.Size = new System.Drawing.Size(196, 45);
            this.btnProgramCon.TabIndex = 4;
            this.btnProgramCon.Text = "Programar Consulta";
            this.btnProgramCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProgramCon.UseVisualStyleBackColor = true;
            this.btnProgramCon.Click += new System.EventHandler(this.btnProgramCon_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 382);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(196, 42);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            this.btnConsulta.MouseEnter += new System.EventHandler(this.btnConsulta_MouseEnter);
            this.btnConsulta.MouseLeave += new System.EventHandler(this.btnConsulta_MouseLeave);
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlPaciente.Controls.Add(this.btnExpedientePac);
            this.pnlPaciente.Controls.Add(this.btnRegistroPac);
            this.pnlPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaciente.Location = new System.Drawing.Point(0, 298);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(196, 84);
            this.pnlPaciente.TabIndex = 7;
            // 
            // btnRegistroPac
            // 
            this.btnRegistroPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroPac.FlatAppearance.BorderSize = 0;
            this.btnRegistroPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroPac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistroPac.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroPac.Image")));
            this.btnRegistroPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroPac.Location = new System.Drawing.Point(0, 0);
            this.btnRegistroPac.Name = "btnRegistroPac";
            this.btnRegistroPac.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRegistroPac.Size = new System.Drawing.Size(196, 42);
            this.btnRegistroPac.TabIndex = 5;
            this.btnRegistroPac.Text = "Registro \r\nPaciente\r\n\r\n\r\n";
            this.btnRegistroPac.UseVisualStyleBackColor = true;
            this.btnRegistroPac.Click += new System.EventHandler(this.btnRegistroPac_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPaciente.Image = global::FrmMenuPrincipal.Properties.Resources.icons8_paciente_26;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 256);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(196, 42);
            this.btnPaciente.TabIndex = 6;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            this.btnPaciente.MouseEnter += new System.EventHandler(this.btnPaciente_MouseEnter);
            this.btnPaciente.MouseLeave += new System.EventHandler(this.btnPaciente_MouseLeave);
            // 
            // pnlMedico
            // 
            this.pnlMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlMedico.Controls.Add(this.btnRegistroMed);
            this.pnlMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMedico.Location = new System.Drawing.Point(0, 216);
            this.pnlMedico.Name = "pnlMedico";
            this.pnlMedico.Size = new System.Drawing.Size(196, 40);
            this.pnlMedico.TabIndex = 3;
            // 
            // btnRegistroMed
            // 
            this.btnRegistroMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroMed.FlatAppearance.BorderSize = 0;
            this.btnRegistroMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroMed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistroMed.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroMed.Image")));
            this.btnRegistroMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroMed.Location = new System.Drawing.Point(0, 0);
            this.btnRegistroMed.Name = "btnRegistroMed";
            this.btnRegistroMed.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRegistroMed.Size = new System.Drawing.Size(196, 40);
            this.btnRegistroMed.TabIndex = 4;
            this.btnRegistroMed.Text = "Registro \r\nMedico\r\n";
            this.btnRegistroMed.UseVisualStyleBackColor = true;
            this.btnRegistroMed.Click += new System.EventHandler(this.btnRegistroMed_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedico.FlatAppearance.BorderSize = 0;
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedico.Location = new System.Drawing.Point(0, 173);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(196, 43);
            this.btnMedico.TabIndex = 2;
            this.btnMedico.Text = "Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            this.btnMedico.MouseEnter += new System.EventHandler(this.btnMedico_MouseEnter);
            this.btnMedico.MouseLeave += new System.EventHandler(this.btnMedico_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 173);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(840, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExpedientePac
            // 
            this.btnExpedientePac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpedientePac.FlatAppearance.BorderSize = 0;
            this.btnExpedientePac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpedientePac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpedientePac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExpedientePac.Image = ((System.Drawing.Image)(resources.GetObject("btnExpedientePac.Image")));
            this.btnExpedientePac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpedientePac.Location = new System.Drawing.Point(0, 42);
            this.btnExpedientePac.Name = "btnExpedientePac";
            this.btnExpedientePac.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnExpedientePac.Size = new System.Drawing.Size(196, 42);
            this.btnExpedientePac.TabIndex = 6;
            this.btnExpedientePac.Text = "Expediente \r\nPaciente\r\n\r\n\r\n";
            this.btnExpedientePac.UseVisualStyleBackColor = true;
            this.btnExpedientePac.Click += new System.EventHandler(this.btnExpedientePac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(874, 606);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica";
            this.panel1.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlPaciente.ResumeLayout(false);
            this.pnlMedico.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistroMed;
        private System.Windows.Forms.Panel pnlMedico;
        private System.Windows.Forms.Panel pnlPaciente;
        private System.Windows.Forms.Button btnRegistroPac;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Button btnHistorCon;
        private System.Windows.Forms.Button btnProgramCon;
        private System.Windows.Forms.Button btnExpedientePac;
    }
}

