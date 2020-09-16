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
    public partial class frmCadastro : Form
    {
        List<Jogador> lista = null;
        internal List<Jogador> ListaCadastro { get => lista; set => lista = value; }
        char sexo;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMasculino.Checked == true)
                sexo = 'M';
        }

        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFeminino.Checked == true)
                sexo = 'F';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador();
            jogador.Nome = textBox1.Text;
            jogador.Pontos = 0;
            jogador.Tempo = TimeSpan.Zero;
            jogador.Sexo = sexo;
            listBox1.Items.Add(jogador.Nome);
            lista.Add(jogador);
        }
    }
}
