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
    }
}
