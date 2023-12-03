using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade10
    {
        public void atividade_10()
        {
            double peso = 0;
            double altura = 0;
            double imc = 0;
            
            Console.WriteLine("Digite o peso em kg: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura em metros: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso.");
            }
            else
            {
                Console.WriteLine("Condição: Obeso.");
            }
            Console.ReadKey();
        }
    }
}
