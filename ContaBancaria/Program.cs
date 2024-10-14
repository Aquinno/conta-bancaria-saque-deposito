using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {
            Conta c = new Conta("", 0, 0);
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(titular, conta, depositoinicial);
                Console.WriteLine(c.MostrarDados());
            }
            else {
                c = new Conta(titular, conta);
                Console.WriteLine(c.MostrarDados());
            }
            Console.Write("Entre com um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(dep);
            Console.WriteLine(c.MostrarDadosAtt());
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(saque);
        }
    }
}
