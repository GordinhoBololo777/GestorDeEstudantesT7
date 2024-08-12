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
        Color corPalMeninos;
        Color corPainelMeninas;

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPaielTotal = panelTotalDeEstudos.BackColor;
            corPaielTotal = panelMeninos.BackColor;
            corPaielTotal = panelMeninas.BackColor;

           //Exibe os valores (total geral, total de meninos, meninas etc)
           Estudante estudante = new Estudante();
            double totalEstudantes = Convert.ToDouble(estudante.totalDeEstudantes());
            double totalMeninos = Convert.ToDouble(estudante.totalDeEstudantesMeninos()); 
            double totalMeninas = Convert.ToDouble(estudante.totalDeEstudantesMeninas());

            // Contar a porcetagem (%)
            double porcenragemDeMeninos = totalMeninos * 100 / totalEstudantes;
            double porcentagemDeMeninas = totalMeninas * 100 / totalEstudantes;

            labelTotalDeEstudos.Text = "Total de Estudantes: " + totalEstudantes.ToString();
            labelMeninos.Text = "% de Meninos: " + porcenragemDeMeninos.ToString("0.00") + "%";
            labelMeninas.Text = "% de Meninas: " + porcentagemDeMeninas.ToString("0.00") + "%";


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
            panelMeninas.BackColor = corPaielTotal;
            labelMeninas.ForeColor = Color.Black;

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

        private void labelTotalDeEstudos_MouseEnter(object sender, EventArgs e)
        {
            panelTotalDeEstudos.BackColor = Color.Black;
            labelTotalDeEstudos.ForeColor = corPaielTotal;

        }
    }
}
