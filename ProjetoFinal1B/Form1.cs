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
    public partial class Form1 : Form
    {
        List<Jogador> jogadores = new List<Jogador>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arregão!");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmJogo jogo = new frmJogo();
            jogo.ListaJogo = jogadores;
            jogo.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.ListaCadastro = jogadores;
            cad.ShowDialog();
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRanking ranking = new frmRanking();
            ranking.ListaRanking = jogadores;
            ranking.ShowDialog();
        }

        private void doarDinheiroAoDesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoacao doar = new frmDoacao();
            doar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
