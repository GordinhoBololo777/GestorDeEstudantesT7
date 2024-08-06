namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
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
            this.panelTotalDeEstudos = new System.Windows.Forms.Panel();
            this.labelTotalDeEstudos = new System.Windows.Forms.Label();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.panelTotalDeEstudos.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalDeEstudos
            // 
            this.panelTotalDeEstudos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTotalDeEstudos.Controls.Add(this.labelTotalDeEstudos);
            this.panelTotalDeEstudos.Location = new System.Drawing.Point(-2, -1);
            this.panelTotalDeEstudos.Name = "panelTotalDeEstudos";
            this.panelTotalDeEstudos.Size = new System.Drawing.Size(814, 289);
            this.panelTotalDeEstudos.TabIndex = 0;
            this.panelTotalDeEstudos.MouseEnter += new System.EventHandler(this.panelTotalDeEstudos_MouseEnter);
            // 
            // labelTotalDeEstudos
            // 
            this.labelTotalDeEstudos.AutoSize = true;
            this.labelTotalDeEstudos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeEstudos.Location = new System.Drawing.Point(257, 129);
            this.labelTotalDeEstudos.Name = "labelTotalDeEstudos";
            this.labelTotalDeEstudos.Size = new System.Drawing.Size(302, 29);
            this.labelTotalDeEstudos.TabIndex = 0;
            this.labelTotalDeEstudos.Text = "Total de Estudantes: 999";
            this.labelTotalDeEstudos.MouseLeave += new System.EventHandler(this.labelTotalDeEstudos_MouseLeave);
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(405, 294);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(408, 189);
            this.panelMeninas.TabIndex = 1;
            this.panelMeninas.MouseEnter += new System.EventHandler(this.panelMeninas_MouseEnter);
            this.panelMeninas.MouseLeave += new System.EventHandler(this.panelMeninas_MouseLeave);
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(113, 75);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(176, 29);
            this.labelMeninas.TabIndex = 0;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.MouseEnter += new System.EventHandler(this.labelMeninas_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.labelMeninas_MouseLeave);
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(92, 75);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(177, 29);
            this.labelMeninos.TabIndex = 0;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.Click += new System.EventHandler(this.label2_Click_1);
            this.labelMeninos.DragLeave += new System.EventHandler(this.label2_DragLeave);
            this.labelMeninos.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(-2, 294);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(408, 189);
            this.panelMeninos.TabIndex = 2;
            this.panelMeninos.MouseEnter += new System.EventHandler(this.panelMeninos_MouseEnter);
            this.panelMeninos.MouseLeave += new System.EventHandler(this.panelMeninos_MouseLeave);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelTotalDeEstudos);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelTotalDeEstudos.ResumeLayout(false);
            this.panelTotalDeEstudos.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalDeEstudos;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Label labelTotalDeEstudos;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Panel panelMeninos;
    }
}