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
    public partial class Labrnt : Form
    {
        Point posicaoinicialcursor = new Point(50, 35);
        bool voltarposicao = false;
        public Labrnt()
        {
            InitializeComponent();
        }

        private void MouseEnterObstaculos(object sender, EventArgs e)
        {
            if (voltarposicao)
            Cursor.Position = PointToScreen(posicaoinicialcursor);

            this.BackColor = Color.Red;
            Thread threadvoltar = new Thread(new ThreadStart(MudarCorTela));
            threadvoltar.Start();
        }

        private void MudarCorTela()
        {
            Thread.Sleep(30);
            this.Invoke((MethodInvoker)delegate
            {
                this.BackColor = Color.FromArgb(173, 223, 168);
            });
        }

        private void MouseEnterLixeira(object sender, EventArgs e)
        {
            MessageBox.Show("Você conseguiu levar o lixo até a lixeira, parabéns!");
            this.Close();
        }

        private Cursor CursorLixo(Bitmap lixocursor)
        {
            lixocursor.MakeTransparent();
            return new Cursor(lixocursor.GetHicon());
        }

        private void clickbtnjogar(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(posicaoinicialcursor);
            btnjogar.Visible = false;
            voltarposicao = true;
            
            Bitmap lixocursor = Properties.Resources.papelcursor;
            this.Cursor = CursorLixo(lixocursor);
        }
    }
}
