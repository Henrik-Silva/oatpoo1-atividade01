using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade05
    {
        public void atividade_05()
        {
            int num = 0;

            Console.WriteLine("Informe 1 numero");
            num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                num = num * 2;
                Console.WriteLine("O dobro do seu numero positivo é {0}", num);
            }
            else
            {
                num = num * 3;
                Console.WriteLine("O triplo do seu numero negativo é {0}", num);
            }

            Console.ReadKey();
        }
    }
}
