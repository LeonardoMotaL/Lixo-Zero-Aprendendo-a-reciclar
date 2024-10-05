using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Labrnt Labirinto = new Labrnt();
            Labirinto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quiz Quizperguntas = new Quiz();
            Quizperguntas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Historias VerHist = new Historias();
            VerHist.ShowDialog();
        }

        private void btncreditos_Click(object sender, EventArgs e)
        {
            Creditos VerCreditos = new Creditos();
            VerCreditos.ShowDialog();
        }
    }
}
