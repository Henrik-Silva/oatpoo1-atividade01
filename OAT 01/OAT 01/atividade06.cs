using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade06
    {
        public void atividade_06()
        {
            bool valor1;
            bool valor2;

            Console.Write("Digite o primeiro valor booleano (true/false): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor booleano (true/false): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos os valores são VERDADEIROS.");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos os valores são FALSOS.");
            }
            else
            {
                Console.WriteLine("Um dos valores é verdadeiro e o outro é falso.");
            }
            Console.ReadKey();
        }
    }
}
