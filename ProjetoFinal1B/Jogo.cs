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
    public partial class frmJogo : Form
    {
        List<Jogador> listaJogo = null;
        public List<Jogador> ListaJogo { get => listaJogo; set => listaJogo = value; }
        Jogador jogador = null;
        int[] vet = new int[5];
        PictureBox[] picNumeros = new PictureBox[5];
        Random rand = new Random();
        public frmJogo()
        {
            InitializeComponent();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            jogador = listaJogo[comboBox1.SelectedIndex];
            for(int i=0;i<5;i++)
            {
                vet[i] = rand.Next(10);
                switch(vet[i])
                {
                    case 0:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/0.png");
                        break;
                    case 1:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/1.png");
                        break;
                    case 2:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/2.png");
                        break;
                    case 3:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/3.png");
                        break;
                    case 4:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/4.png");
                        break;
                    case 5:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/5.png");
                        break;
                    case 6:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/6.png");
                        break;
                    case 7:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/7.png");
                        break;
                    case 8:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/8.png");
                        break;
                    case 9:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/9.png");
                        break;
                }
            }

            

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            foreach(Jogador j in listaJogo)
            {
                comboBox1.Items.Add(j.Nome);
            }
            picNumeros[0] = pictureBox1;
            picNumeros[1] = pictureBox2;
            picNumeros[2] = pictureBox3;
            picNumeros[3] = pictureBox4;
            picNumeros[4] = pictureBox5;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdIniciar.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
