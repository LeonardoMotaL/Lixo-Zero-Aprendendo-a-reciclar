using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class Quiz : Form
    {
        int alternativacerta;
        int qntperguntas;
        int numerodapergunta = 1;
        int nota;

        public Quiz()
        {
            InitializeComponent();
            perguntas(numerodapergunta);
            qntperguntas = 10;
        }

        private void eventrespostas(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == alternativacerta) 
            {
                nota++;

                this.BackColor = Color.Green;
                Thread tacerto = new Thread(new ThreadStart(MudarCorTela));
                tacerto.Start();
            }
            else
            {
                this.BackColor = Color.Red;
                Thread terro = new Thread(new ThreadStart(MudarCorTela));
                terro.Start();
            }

            if (numerodapergunta == qntperguntas)
            {
                lblpontos.Visible = false;
                label1.Visible = false;
                MessageBox.Show("Você terminou de responder ao quiz, das 10 questões, você acertou " +
                nota + "." + Environment.NewLine + "Obrigado por jogar!");
                this.Close();

                nota = 0;
                numerodapergunta = 0;
                perguntas(numerodapergunta);
            }
            numerodapergunta++;
            perguntas(numerodapergunta);
        }

        private void MudarCorTela()
        {
            Thread.Sleep(30);
            this.Invoke((MethodInvoker)delegate
            {
                this.BackColor = Color.FromArgb(173, 223, 168);
            });
        }

        private void perguntas (int qnum)
        {
            switch(qnum)
            {
                case 1:
                    picbquiz.Image = Properties.Resources.papel200resized;
                    lblquiz.Text = "1- Em qual lixeira o papel amassado deve ser jogado?";
                    alternativacerta = 2;
                    break;
                case 2:
                    picbquiz.Image = Properties.Resources.sacola_resized;
                    lblquiz.Text = "2- Em qual lixeira a sacola plástica deve ser jogada?";
                    alternativacerta = 1;
                    break;
                case 3:
                    picbquiz.Image = Properties.Resources.lata_resized;
                    lblquiz.Text = "3- Em qual lixeira a latinha de refrigerante deve ser jogada?";
                    alternativacerta = 4;
                    break;
                case 4:
                    picbquiz.Image = Properties.Resources.garrafavidro_resized;
                    lblquiz.Text = "4- Em qual lixeira a garrafa de vidro quebrada deve ser jogada?";
                    alternativacerta = 3;
                    break;
                case 5:
                    picbquiz.Image = Properties.Resources.ppbala_resized;
                    lblquiz.Text = "5- Em qual lixeira a embalagem de bala deve ser jogada?";
                    alternativacerta = 1;
                    break;
                case 6:
                    picbquiz.Image = Properties.Resources.latametal_resized;
                    lblquiz.Text = "6- Em qual lixeira a lata deve ser jogada?";
                    alternativacerta = 4;
                    break;
                case 7:
                    picbquiz.Image = Properties.Resources.caixa_resized;
                    lblquiz.Text = "7- Em qual lixeira o papelão deve ser jogado?";
                    alternativacerta = 2;
                    break;
                case 8:
                    picbquiz.Image = Properties.Resources.potevidro_resized;
                    lblquiz.Text = "8- Em qual lixeira o pote de vidro quebrado deve ser jogado?";
                    alternativacerta = 3;
                    break;
                case 9:
                    picbquiz.Image = Properties.Resources.garrafa_resized;
                    lblquiz.Text = "9- Em qual lixeira a garrafa pet deve ser jogada?";
                    alternativacerta = 1;
                    break;
                case 10:
                    picbquiz.Image = Properties.Resources.caderno_resized;
                    lblquiz.Text = "10- Em qual lixeira o caderno velho deve ser jogado?";
                    alternativacerta = 2;
                    break;
            }
            lblpontos.Text = nota.ToString() + " / 10";
        }
    }
}
