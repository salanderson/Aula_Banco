using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S' )
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Deseja efetuar um deposito (s/n)");
            char respDeposito = char.Parse(Console.ReadLine());
            if (respDeposito == 's' || respDeposito == 'S')
            {

                Console.Write("Entre com o valor para depósito: ");
                double quantiaDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(quantiaDeposito);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
            }


                Console.WriteLine();
                Console.WriteLine("Deseja efetuar um saque (s/n)");
                char respSaque = char.Parse(Console.ReadLine());
                if (respSaque == 's' || respSaque == 'S')
                {

                    Console.WriteLine();
                    Console.WriteLine("Entre com o valor para saque: ");
                    double quantiaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Saque(quantiaSaque);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta);

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Dados da conta: ");
                    Console.WriteLine(conta);
                }
            
           
        }
    }
}
