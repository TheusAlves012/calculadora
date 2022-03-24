using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado = 0;
            string sair;
            string operacao;

            Console.WriteLine("digite a operacao");
            operacao = Console.ReadLine();

            Console.WriteLine("digite o primeiro numero");
            num1 = int.Parse(Console.ReadLine());

           

            Console.WriteLine("digite o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case "+":
                     resultado = num1 + num2;
                break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                default:
                    Console.WriteLine("operacao invalida!");
                    break;
            }

            Console.WriteLine("{0} {1} {2} {3}", num1, operacao, num2, resultado);
            Console.WriteLine("Deseja realizar uma nova operação? s/n?");
            sair = Console.ReadLine();
            while ((sair != "n" && sair != "N") && (sair != "s" && sair != "S")) ;
            sair = Console.ReadLine();
            Console.ReadKey();

            Console.ReadKey(true);

       }

    }

}
