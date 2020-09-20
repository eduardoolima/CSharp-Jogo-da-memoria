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
        List<Jogador> rankingOrdenado = new List<Jogador>();
        public frmRanking()
        {
            InitializeComponent();
        }

        private void lblNome1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            
            if (listaRanking.Count() == 1) 
            {
                lblNome1.Text = listaRanking.ElementAt(0).Nome;
                lblPontos1.Text = listaRanking.ElementAt(0).Pontos.ToString();
            }

            if (listaRanking.Count() == 2)
            {
                lblNome1.Text = listaRanking.ElementAt(0).Nome;
                lblPontos1.Text = listaRanking.ElementAt(0).Pontos.ToString();

                lblNome2.Text = listaRanking.ElementAt(1).Nome;
                lblPontos2.Text = listaRanking.ElementAt(1).Pontos.ToString();

            }

            if (listaRanking.Count( )== 3)
            {
                listaRanking.Sort((j1, j2) => j1.Pontos.CompareTo(j2.Pontos));
                listaRanking.Reverse();

                lblNome1.Text = listaRanking.ElementAt(0).Nome;
                lblPontos1.Text = listaRanking.ElementAt(0).Pontos.ToString();

                lblNome2.Text = listaRanking.ElementAt(1).Nome;
                lblPontos2.Text = listaRanking.ElementAt(1).Pontos.ToString();

                lblNome3.Text = listaRanking.ElementAt(2).Nome;
                lblPontos3.Text = listaRanking.ElementAt(2).Pontos.ToString();
            }

        }

        private void lblPontos1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalhes detalhes = new frmDetalhes();
            detalhes.ListaDetalhes = listaRanking;
            detalhes.ShowDialog();
        }
    }
}
