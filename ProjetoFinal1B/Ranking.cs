using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal1B
{
    public partial class frmRanking : Form
    {
        List<Jogador> listaRanking = null;
        internal List<Jogador> ListaRanking { get => listaRanking; set => listaRanking = value; }
        List<int> aux = new List<int>();
        public frmRanking()
        {
            InitializeComponent();
        }

        private void lblNome1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            foreach (Jogador jogador in listaRanking)
            {
                aux.Add(jogador.Pontos);
            }
            aux.Sort();

            int i = 0;
            foreach (Jogador item in listaRanking)
            {
                if (item.Pontos >= aux[i])
                {
                    lblNome1.Text = item.Nome;
                    lblPontos1.Text = item.Pontos.ToString();
                }
                else
                    i++;
            }

            int j = i++;
            foreach (Jogador item in listaRanking)
            {
                if (item.Pontos >= aux[j] )
                {
                    lblNome2.Text = item.Nome;
                    lblPontos2.Text = item.Pontos.ToString();
                }
                else
                    j++;
            }

            int k = j++;
            foreach (Jogador item in listaRanking)
            {
                if (item.Pontos >= aux[k])
                {
                    lblNome3.Text = item.Nome;
                    lblPontos3.Text = item.Pontos.ToString();
                }
                else
                    k++;
            }
        }
    }
}
