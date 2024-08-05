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
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.panelTotalDeEstudos.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalDeEstudos
            // 
            this.panelTotalDeEstudos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTotalDeEstudos.Controls.Add(this.label1);
            this.panelTotalDeEstudos.Location = new System.Drawing.Point(-2, -1);
            this.panelTotalDeEstudos.Name = "panelTotalDeEstudos";
            this.panelTotalDeEstudos.Size = new System.Drawing.Size(814, 289);
            this.panelTotalDeEstudos.TabIndex = 0;
            this.panelTotalDeEstudos.MouseEnter += new System.EventHandler(this.panelTotalDeEstudos_MouseEnter);
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMeninas.Controls.Add(this.label3);
            this.panelMeninas.Location = new System.Drawing.Point(405, 294);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(408, 189);
            this.panelMeninas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Estudantes: 999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meninas: 50%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Meninos: 50%";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelMeninos.Controls.Add(this.label2);
            this.panelMeninos.Location = new System.Drawing.Point(-2, 294);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(408, 189);
            this.panelMeninos.TabIndex = 2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMeninos;
    }
}