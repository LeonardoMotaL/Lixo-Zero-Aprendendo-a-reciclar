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
    public partial class Historias : Form
    {
        int pagshist = 1;
        public Historias()
        {
            InitializeComponent();
            MudarPag(pagshist);
        }

        private void VoltarPag(object sender, EventArgs e)
        {
            pagshist -= 1;
            if (pagshist < 1)
            {
                pagshist = 1;
            }
            MudarPag(pagshist);
        }

        private void ProximaPag(object sender, EventArgs e)
        {
            pagshist += 1;
            if(pagshist > 8)
            {
                MessageBox.Show("Você terminou de aprender sobre a utilidade de cada tipo de lixeira. Que tal testar seus conhecimentos com o quiz?");
                this.Close();
            }
            MudarPag(pagshist);
        }

        private void MudarPag(int paghist)
        {
            switch(paghist)
            {
                case 1:
                    lbldescricao.Text = "Bem-vindos, amigos! Hoje vamos aprender juntos sobre as cores das lixeiras e onde cada tipo de lixo deve ser jogado.";
                    picbimagens.Image = Properties.Resources.introlixeiras;
                    break;
                case 2:
                    lbldescricao.Text = "Na lixeira vermelha, nós colocamos os plásticos! Isso inclui sacolas, embalagens, frascos, potes, tampinhas, etc.";
                    picbimagens.Image = Properties.Resources.PLASTICO_FINAL;
                    break;
                case 3:
                    lbldescricao.Text = "Na lixeira azul, nós colocamos os papéis! Isso inclui jornais, revistas, folhas de caderno, caixas de papelão, etc.";
                    picbimagens.Image = Properties.Resources.PAPEL_FINAL;
                    break;
                case 4:
                    lbldescricao.Text = "Na lixeira verde, nós colocamos o vidro! Nela, podemos descartar cacos de garrafas, frascos, potes e outros itens de vidro.";
                    picbimagens.Image = Properties.Resources.VIDRO_FINAL;
                    break;
                case 5:
                    lbldescricao.Text = "Na lixeira amarela, nós colocamos os metais! Isso inclui latas, ferragens, arames, pregos, parafusos, ferramentas, etc.";
                    picbimagens.Image = Properties.Resources.METAL_FINAL;
                    break;
                case 6:
                    lbldescricao.Text = "Na lixeira marrom, nós colocamos os resíduos orgânicos! Isso inclui restos de comida, cascas de frutas, legumes, etc.";
                    picbimagens.Image = Properties.Resources.ORGANICO_FINAL;
                    break;
                case 7:
                    lbldescricao.Text = "Na lixeira cinza, nós colocamos resíduos não recicláveis! Isso inclui papéis sujos, espelhos, lentes de óculos e itens que não podem ser reciclados.";
                    picbimagens.Image = Properties.Resources.CINZA_FINALIZADO;
                    break;
                case 8:
                    lbldescricao.Text = "Vamos cuidar do nosso planeta! Sempre coloque o lixo no lugar certo para ajudar a manter o nosso ambiente limpo. Juntos podemos fazer a diferença!";
                    picbimagens.Image = Properties.Resources.lixoia;
                    break;
            }
            labelpags.Text = paghist.ToString() + " / 8";
        }
    }
}
