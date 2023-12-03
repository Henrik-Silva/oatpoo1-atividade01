using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade02
    {
        public void atividade_2()
        {
            string nome = "";
            string estadoCivil = "";
            int tempoCasada = 0;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o sexo (M para masculino ou F para feminino):");
            char sexo = char.Parse(Console.ReadLine());

            Console.Write("Digite o estado civil (SOLTEIRA, CASADA) :");
            estadoCivil = Console.ReadLine();

            if (sexo == 'F' && estadoCivil == "CASADO" || estadoCivil == "CASADA")
            {
                Console.Write("Digite o tempo de casamento (em anos): ");
                tempoCasada = int.Parse(Console.ReadLine());

            }
            Console.ReadKey();
        }
    }
}
