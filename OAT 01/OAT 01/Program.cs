using OAT2_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validador = 0;
            do
            {
                Console.WriteLine("Olá");
                Console.WriteLine("Escolha a atividade que deseja verificar (1 a 12)");
                int numeroatividade = int.Parse(Console.ReadLine());

                while (numeroatividade < 1 || numeroatividade > 12)
                {
                    Console.WriteLine("Opção invalida, Tente novamente");
                    numeroatividade = int.Parse(Console.ReadLine());
                }

                switch (numeroatividade)
                {
                    case 1:
                        atividade01 atividade01 = new atividade01();
                        atividade01.atividade_1();

                        break;

                    case 2:
                        atividade02 atividade02 = new atividade02();
                        atividade02.atividade_2();

                        break;

                    case 3:
                        atividade03 atividade03 = new atividade03();
                        atividade03.atividade_3();

                        break;

                    case 4:
                        atividade04 atividade04 = new atividade04();
                        atividade04.atividade_04();

                        break;

                    case 5:
                        atividade05 atividade05 = new atividade05();
                        atividade05.atividade_05();

                        break;

                    case 6:
                        atividade06 atividade06 = new atividade06();   
                        atividade06.atividade_06();

                        break;

                    case 7:
                        atividade07 atividade07 = new atividade07();
                        atividade07.atividade_07();

                        break;

                    case 8:
                        atividade08 atividade08 = new atividade08();
                        atividade08.atividade_08();

                        break;

                    case 9:
                        atividade09 atividade09 = new atividade09();
                        atividade09.atividade_09();
                        break;

                    case 10:
                        atividade10 atividade10 = new atividade10();
                        atividade10.atividade_10();
                        break;

                    case 11:
                        atividade11 atividade11 = new atividade11();
                        atividade11.atividade_11();
                        break; 

                    case 12:
                        atividade12 atividade12 = new atividade12();
                        atividade12.atividade_12();
                        break; 

                }
                Console.Clear();

                Console.WriteLine("Gostaria de verificar mais algum atividade ? Digite 0 para 'SIM' e -1 para 'NÃO'");
                validador = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (validador != -1) ;
        }
    }
}
