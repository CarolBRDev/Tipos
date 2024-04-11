using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    class ContaBancaria
    {
        public string Titular;

        public double Saldo; //usa-se double por ter precisao dupla enquanto float é ponto flutuante de precisão simples, evitando dizima periodica
        
        //método construtor
        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor; //soma o valor do deposito ao saldo existente;
            Console.WriteLine($"Deposito de {valor} realizado com sucesso.");
        }

        public void Sacar(double valor){
            if (valor>Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta de {Titular}: {Saldo}");
        }


    }



}
