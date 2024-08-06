using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }


        Color corPaielTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPaielTotal = panelTotalDeEstudos.BackColor;
            corPaielTotal = panelMeninos.BackColor;
            corPaielTotal = panelMeninas.BackColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panelTotalDeEstudos_MouseEnter(object sender, EventArgs e)
        {
            panelTotalDeEstudos.BackColor = Color.Black;
            labelTotalDeEstudos.ForeColor = corPaielTotal;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPaielTotal;

        }

        private void labelTotalDeEstudos_MouseLeave(object sender, EventArgs e)
        {
            panelTotalDeEstudos.BackColor = corPaielTotal;
            labelTotalDeEstudos.ForeColor = Color.Black;

        }

        private void label2_DragLeave(object sender, EventArgs e)
        {

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPaielTotal;
            labelMeninos.ForeColor = Color.Black;

        }

        private void panelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPaielTotal;
            labelMeninos.ForeColor = Color.Black;

        }

        private void panelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPaielTotal;
            labelMeninos.ForeColor = Color.Black;

        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPaielTotal;

        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPaielTotal;
            labelMeninos.ForeColor = Color.Black;

        }

        private void panelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPaielTotal;

        }

        private void panelMeninos_MouseLeave(object sender, EventArgs e)
        {

            panelMeninos.BackColor = corPaielTotal;
            labelMeninos.ForeColor = Color.Black;
        }
    }
}
