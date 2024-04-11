using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Criando instancia da conta
            ContaBancaria contaJoao = new ContaBancaria("João", 1000);

            contaJoao.ExibirSaldo();

            ////Realizando operações na conta criada
            contaJoao.Depositar(500);
            contaJoao.Sacar(200);
            contaJoao.ExibirSaldo();

            //criando nova conta
            ContaBancaria contaMaria = new ContaBancaria("Maria", 2000);

           
            //transferindo valor de uma conta para outra
            double valorTransferencia = 300;

            contaMaria.Sacar(valorTransferencia);
            contaJoao.Depositar(valorTransferencia);

            contaMaria.ExibirSaldo();
            contaJoao.ExibirSaldo();



        }
    }
}
