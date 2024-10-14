using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria {
    class Conta {
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public int Numero { get; private set; }

        public Conta(string nome, int numero) {
            Nome = nome;
            Saldo = 0;
            Numero = numero;
        }
        public Conta(string nome, int numero, double saldo) {
            Nome = nome;
            Saldo = saldo;
            Numero = numero;
        }
        public string MostrarDados() {
            return "Dados da conta:\n" + "Conta " + Numero + ", Titular: " + Nome + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void Depositar(double dep) {
            Saldo += dep;
        }
        public string MostrarDadosAtt() {
            return "Dados da conta atualizados:\n" + "Conta " + Numero + ", Titular: " + Nome + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void Sacar(double saque) {
            if (saque <= Saldo) {
                Saldo -= saque+5;
                Console.WriteLine(MostrarDadosAtt());
            }
            else if (saque > Saldo) {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
