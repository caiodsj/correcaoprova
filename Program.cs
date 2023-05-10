using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeFinalListaLaco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Professor, deseja modificar o gabarito? [1] - Sim | [2] - Não: ");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao ==1)
            {
                Aluno.gabarito = new char[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Questão {i+1}: ");
                    char resp = char.Parse(Console.ReadLine());
                    Aluno.gabarito[i] = resp;
                }
                Console.WriteLine();
                Console.WriteLine("Gabarito atualizado com sucesso!");
                Console.WriteLine();
            }

            Console.WriteLine("---- Inserir respostas dos alunos ----");
            Console.WriteLine();
            Aluno aluno = new Aluno();
            while (true)
            {
                aluno.Entrega();
                Console.Write("Adicionar novo aluno: [1] - Sim | [2] - Não: ");
                int op = int.Parse(Console.ReadLine());
                if (op == 2) { break; }
            }
            Console.WriteLine();
            Console.WriteLine(aluno);

            //Nome e nota do(s) aluno(s) que tiraram a maior nota.
            int maiorNota = Aluno.lista.Max(a => a.Nota);
            //string nomeMaiorNota = Aluno.lista.OrderByDescending(a => a.Nota).First().Nome;
            List<Aluno> alunosComMaiorNota = Aluno.lista.Where(a => a.Nota == maiorNota).ToList();
            Console.WriteLine("A maior nota tirada na prova foi: " + maiorNota + ", por: ");
            foreach (Aluno a in alunosComMaiorNota)
            {
                Console.WriteLine(a.Nome);
            }
            Console.WriteLine();
            //Nome e nota do(s) aluno(s) que tiraram a menor nota.
            int menorNota = Aluno.lista.Min(a => a.Nota);
            //string nomeMenorNota = Aluno.lista.OrderBy(a => a.Nota).First().Nome;
            List<Aluno> alunosComMenorNota = Aluno.lista.Where(a => a.Nota == menorNota).ToList();
            Console.WriteLine("A menor nota tirada na prova foi: " + menorNota + ", por: ");
            foreach (Aluno a in alunosComMenorNota)
            {
                Console.WriteLine(a.Nome);
            }
            Console.WriteLine();
            Console.WriteLine(Aluno.lista.Count + " alunos utilizaram o sistema.\n");
            double media = (double)(Aluno.lista.Sum(a => a.Nota)) / (double)(Aluno.lista.Count);
            Console.WriteLine("Média da turma: " + media.ToString("F2"));


            Console.ReadKey();
        }
    }
}
