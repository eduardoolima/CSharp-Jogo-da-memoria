using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal1B
{
    public class Jogador
    {

        private string nome;
        private int pontos;
        private TimeSpan tempo;
        private char sexo;

        public string Nome { get => nome; set => nome = value; }
        public int Pontos { get => pontos; set => pontos = value; }
        public TimeSpan Tempo { get => tempo; set => tempo = value; }
        public char Sexo { get => sexo; set => sexo = value; }

        public Jogador()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + nome);
            sb.AppendLine("Pontos: " + pontos);
            sb.AppendLine("Tempo: " + tempo);
            sb.AppendLine("Sexo: " + sexo);
            return sb.ToString();
        }
        //http.//gg.gg/m63ms
    }
}
