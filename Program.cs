using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Criando instancia da conta
            ContaBancaria contaJoao = new ContaBancaria("João", 1000);

            //Realizando operações na conta criada
            contaJoao.Depositar(500);
            contaJoao.Sacar(200);
            contaJoao.ExibirSaldo();

        }
    }
}
