using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade03
    {
        public void atividade_3()
        {
            int num = 0;

            Console.WriteLine("Escolha um numero");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Seu numero é par");
            }

            else
            {
                Console.WriteLine("Seu numero é impar");
            }

            Console.ReadKey();
        }
    }

}
