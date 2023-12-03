using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade04
    {
        public void atividade_04()
        {
            int num = 0;
            int num2 = 0;

            Console.WriteLine("me informe 2 numeros");
            num = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num == num2)
            {
                int num3 = num + num2;
                Console.WriteLine("A soma dos dois numeros é {0}", num3);
            }

            else
            {
                int num3 = num * num2;
                Console.WriteLine("A multiplicação dos numeros é {0}", num3);
            }

            Console.ReadKey();
        }
    }
}
