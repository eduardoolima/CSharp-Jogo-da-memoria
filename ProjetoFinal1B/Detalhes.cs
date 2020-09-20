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
    public partial class frmDetalhes : Form
    {
        List<Jogador> listaDetalhes = null;
        internal List<Jogador> ListaDetalhes { get => listaDetalhes; set => listaDetalhes = value; }
        public frmDetalhes()
        {
            InitializeComponent();
        }

        private void frmDetalhes_Load(object sender, EventArgs e)
        {                                  
            
            if (listaDetalhes.Count() == 1)
            {
                lblNome1.Text = listaDetalhes.ElementAt(0).Nome;
                lblSexo1.Text = listaDetalhes.ElementAt(0).Sexo.ToString();
                lblTempo1.Text = string.Format("{0:hh\\:mm\\:ss}", listaDetalhes.ElementAt(0).Tempo);
            }

            if (listaDetalhes.Count() == 2)
            {
                listaDetalhes.Sort((j1, j2) => j1.Pontos.CompareTo(j2.Pontos));
                listaDetalhes.Reverse();

                lblNome1.Text = listaDetalhes.ElementAt(0).Nome;
                lblSexo1.Text = listaDetalhes.ElementAt(0).Sexo.ToString();
                lblTempo1.Text = listaDetalhes.ElementAt(0).Tempo.ToString();
                lblNome2.Text = listaDetalhes.ElementAt(1).Nome;
                lblSexo2.Text = listaDetalhes.ElementAt(1).Sexo.ToString();
                lblTempo2.Text = string.Format("{0:hh\\:mm\\:ss}", listaDetalhes.ElementAt(1).Tempo);

            }

            if (listaDetalhes.Count() >= 3)
            {

                listaDetalhes.Sort((j1, j2) => j1.Pontos.CompareTo(j2.Pontos));
                listaDetalhes.Reverse();

                lblNome1.Text = listaDetalhes.ElementAt(0).Nome;
                lblSexo1.Text = listaDetalhes.ElementAt(0).Sexo.ToString();
                lblTempo1.Text = listaDetalhes.ElementAt(0).Tempo.ToString();
                lblNome2.Text = listaDetalhes.ElementAt(1).Nome;
                lblSexo2.Text = listaDetalhes.ElementAt(1).Sexo.ToString();
                lblTempo2.Text = listaDetalhes.ElementAt(1).Tempo.ToString();
                lblNome3.Text = listaDetalhes.ElementAt(2).Nome;
                lblSexo3.Text = listaDetalhes.ElementAt(2).Sexo.ToString();
                lblTempo3.Text = string.Format("{0:hh\\:mm\\:ss}",listaDetalhes.ElementAt(2).Tempo);

            }

        }
    }
}
