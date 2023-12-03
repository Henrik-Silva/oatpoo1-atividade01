using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    public class atividade11
    {
        public void atividade_11()
        {
            int codigoPagamento = 0;
            double precoEtiqueta = 0;
            double valorPago = 0;


            Console.WriteLine("Escolha a condição de pagamento:");
            Console.WriteLine("1 - À vista em dinheiro ou cheque (10% de desconto)");
            Console.WriteLine("2 - À vista no cartão de crédito (15% de desconto)");
            Console.WriteLine("3 - Em duas vezes, preço normal de etiqueta sem juros");
            Console.WriteLine("4 - Em duas vezes, preço normal de etiqueta mais juros de 10%");

            Console.WriteLine("Digite o código da condição de pagamento: ");
            codigoPagamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço normal de etiqueta do produto: ");
            precoEtiqueta = double.Parse(Console.ReadLine());

            valorPago = 0;

            if (codigoPagamento == 1)
            {
                valorPago = precoEtiqueta - (precoEtiqueta * 0.10); 
            }
            else if (codigoPagamento == 2)
            {
                valorPago = precoEtiqueta - (precoEtiqueta * 0.15); 
            }
            else if (codigoPagamento == 3)
            {
                valorPago = precoEtiqueta / 2; 
            }
            else if (codigoPagamento == 4)
            {
                valorPago = (precoEtiqueta / 2) * 1.10; 
            }

            Console.WriteLine("Valor a ser pago: R$ {0}", valorPago);
            Console.ReadKey();
        }
    }
}
