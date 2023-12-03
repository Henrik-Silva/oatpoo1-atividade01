using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade01
    {
        public void atividade_1()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int soma = 0;

            Console.WriteLine("escolha o valor de A,B,C");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            soma = a + b;
            Console.WriteLine("A + B é");
            Console.WriteLine(soma);

            if (soma < c)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }

            Console.ReadKey();
        }
    }
}
