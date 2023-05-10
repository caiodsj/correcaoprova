using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExeFinalListaLaco
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }
        public static char[] gabarito = { 'a', 'b', 'c', 'd', 'e', 'e', 'd', 'c', 'b', 'a' };

        public static List<Aluno> lista = new List<Aluno>();
        public Aluno()
        {
        }
        public Aluno(string nome, int soma)
        {
            Nome = nome;
            Nota = soma;
        }
        
        public void Entrega() {
            int soma = 0;
            char[] entrega = new char[10];
            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();
            for (int i = 0; i < 10;  i++)
            {
                Console.Write("Questão " + (i+1) + ": ");
                entrega[i] = char.Parse(Console.ReadLine());
                if (entrega[i] == gabarito[i])
                    soma++;
            }
            Aluno aluno = new Aluno(nome, soma);
            lista.Add(aluno);
        }

        /*public static Ranking()
        {
            int maiorNota = lista.Max(a => a.Nota);
        }*/
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Aluno a in lista)
            {
                sb.AppendLine($"Aluno(a): {a.Nome}, nota final: {a.Nota}");
            }
            return sb.ToString();
        }
    }
}
