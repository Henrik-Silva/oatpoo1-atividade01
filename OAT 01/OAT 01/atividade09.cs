using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade09
    {
        public void atividade_09()
        {
            double altura = 0;
            double pesoIdeal = 0;

            Console.WriteLine("Digite a altura em metros: ");
            altura = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Digite o sexo (M para masculino ou F para feminino): ");
            char sexo = char.Parse(Console.ReadLine());

           
            if (sexo == 'M' || sexo == 'm')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("O peso ideal para um homem com altura {0}m é: {1} kg", altura, pesoIdeal);
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("O peso ideal para uma mulher com altura {0}m é: {1} kg", altura, pesoIdeal);
            }
            else
            {
                Console.WriteLine("Sexo não reconhecido. Por favor, insira M para masculino ou F para feminino.");
            }
            Console.ReadKey();
        }
    }
}
