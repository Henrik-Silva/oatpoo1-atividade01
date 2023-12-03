using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade12
    {
        public void atividade_12()
        {
            int numeroIdentificacao = 0;
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double mediaExercicios = 0;
            double mediaAproveitamento = 0;

            Console.WriteLine("Digite o número de identificação do aluno: ");
            numeroIdentificacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota (de 0 a 100): ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota (de 0 a 100): ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota (de 0 a 100): ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a média dos exercícios (de 0 a 100): ");
            mediaExercicios = double.Parse(Console.ReadLine());

            mediaAproveitamento = (nota1 + (nota2 * 2) + (nota3 * 3) + mediaExercicios) / 7;

            char conceito;
            if (mediaAproveitamento >= 90)
            {
                conceito = 'A';
            }
            else if (mediaAproveitamento >= 75)
            {
                conceito = 'B';
            }
            else if (mediaAproveitamento >= 60)
            {
                conceito = 'C';
            }
            else if (mediaAproveitamento >= 40)
            {
                conceito = 'D';
            }
            else
            {
                conceito = 'E';
            }

            Console.WriteLine("Número do aluno: {0}", numeroIdentificacao);
            Console.WriteLine("Notas do aluno: {0}, {1}, {2}", nota1, nota2, nota3);
            Console.WriteLine("Média dos exercícios: {0}", mediaExercicios);
            Console.WriteLine("Média de aproveitamento: {0}", mediaAproveitamento);
            Console.WriteLine("Conceito: {0}", conceito);

            if (conceito == 'A' || conceito == 'B' || conceito == 'C')
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.ReadKey();
        }
    }
}

