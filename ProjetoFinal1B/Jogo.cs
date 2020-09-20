using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        List<int> listaNumeros = new List<int>();
        PictureBox[] picNumeros = new PictureBox[5];
        Random rand = new Random();
        Stopwatch cronometro;
        int contadorRevelar = 0;

        public frmJogo()
        {
            InitializeComponent();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            contadorRevelar = 0;

            progressBar1.Value = 0;

            timer1.Enabled = true;

            panel1.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            jogador = listaJogo[comboBox1.SelectedIndex];

            listaNumeros.Clear();

            contadorRevelar = 0;

            for (int i = 0; i < 5; i++)
            {
                picNumeros[i].Visible = true;
            }

            for (int i = 0; i < 5; i++)
            {
                vet[i] = rand.Next(10);
                switch(vet[i])
                {
                    case 0:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/0.png");
                        listaNumeros.Add(0);
                        break;
                    case 1:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/1.png");
                        listaNumeros.Add(1);
                        break;
                    case 2:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/2.png");
                        listaNumeros.Add(2);
                        break;
                    case 3:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/3.png");
                        listaNumeros.Add(3);
                        break;
                    case 4:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/4.png");                        
                        listaNumeros.Add(4);
                        break;
                    case 5:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/5.png");
                        listaNumeros.Add(5);
                        break;
                    case 6:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/6.png");
                        listaNumeros.Add(6);
                        break;
                    case 7:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/7.png");
                        listaNumeros.Add(7);
                        break;
                    case 8:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/8.png");
                        listaNumeros.Add(8);
                        break;
                    case 9:
                        picNumeros[i].Load("F:/Unifenas/4° Período/Linguagens e tecnicas de programacao/ProjetoFinal1B/ProjetoFinal1B/img/9.png");
                        listaNumeros.Add(9);
                        break;
                }
                
            }
            listaNumeros.Sort();

            var t = Task.Run(async delegate
            {
                await Task.Delay(3000);
                for (int i = 0; i < 5; i++)
                {
                    picNumeros[i].Visible = false;
                }
            });
            t.Wait();

            cronometro.Restart();
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

            progressBar1.Maximum = 100;

            cronometro = new Stopwatch();
           // mostraNumeros = new Stopwatch();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdIniciar.Enabled = true;
        }

        //sair
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            pictureBox1.Visible = true;
            if(vet[0] == listaNumeros.First())
            {
                jogador.Pontos++;
                listaNumeros.RemoveAt(0);
                progressBar1.Value+=20;
                button1.Enabled = false;
                contadorRevelar++;
            }
            else
            {
                MessageBox.Show("Você Perdeu!");
                panel1.Enabled = false;
                cronometro.Stop();
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            if (vet[1] == listaNumeros.First())
            {
                jogador.Pontos++;
                listaNumeros.RemoveAt(0);
                progressBar1.Value+=20;
                button2.Enabled = false;
                contadorRevelar++;
            }
            else
            {
                MessageBox.Show("Você Perdeu!");
                panel1.Enabled = false;
                cronometro.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            if (vet[2] == listaNumeros.First())
            {
                jogador.Pontos++;
                listaNumeros.RemoveAt(0);
                progressBar1.Value+=20;
                button3.Enabled = false;
                contadorRevelar++;
            }
            else
            {
                MessageBox.Show("Você Perdeu!");
                panel1.Enabled = false;
                cronometro.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            if (vet[3] == listaNumeros.First())
            {
                jogador.Pontos++;
                listaNumeros.RemoveAt(0);
                progressBar1.Value+=20;
                button4.Enabled = false;
                contadorRevelar++;
            }
            else
            {
                MessageBox.Show("Você Perdeu!");
                panel1.Enabled = false;
                cronometro.Stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            if (vet[4] == listaNumeros.First())
            {
                jogador.Pontos++;
                listaNumeros.RemoveAt(0);
                progressBar1.Value+=20;
                button5.Enabled = false;
                contadorRevelar++;
            }
            else
            {
                MessageBox.Show("Você Perdeu!");
                panel1.Enabled = false;
                cronometro.Stop();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (contadorRevelar == 5)
            {
                MessageBox.Show("Você venceu!");
                jogador.Tempo = cronometro.Elapsed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCronometro.Text = string.Format("{0:hh\\:mm\\:ss}", cronometro.Elapsed);
            if(contadorRevelar==5)
            {             
                cronometro.Stop();
                timer1.Enabled = false;
            }
            
        }

    }
}
