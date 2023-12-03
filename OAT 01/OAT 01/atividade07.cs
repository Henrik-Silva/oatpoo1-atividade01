using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade07
    {
        public void atividade_07()
        {
            int num = 0;

            Console.WriteLine("Informe 1 numero");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                num = num + 5;
                Console.WriteLine("A soma do seu numero + 5 foi {0}", num);
            }

            else
            {
                num = num + 8;
                Console.WriteLine("A soma do seu numero + 8 foi {0}", num);
            }

            Console.ReadKey();
        }
    }
}
