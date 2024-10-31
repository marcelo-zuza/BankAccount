using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contaBancaria.src
{
    public class ContaBancaria
    {
        public int NumeroConta {get; private set;}
        public string NomeTitular {get; set;}
        public double Saldo {get; set;}
        public List<string> HistoricoTransacoes {get; private set;}

        // Construtor
        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = 0.0;
            HistoricoTransacoes = new List<string>();
            HistoricoTransacoes.Add("Conta criada com saldo inicial de 0");
        }


        public void Depositar(double valor)
        {
            Saldo += valor;
            HistoricoTransacoes.Add($"Depósito: +{valor}");
            Console.WriteLine($"Depósito realizado com sucesso. Saldo atual: {Saldo}");
        }

        public bool Sacar(double valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                HistoricoTransacoes.Add($"Saque: -{valor}");
                Console.WriteLine($"Saque realizado com sucesso. Saldo atual: {Saldo}");
                return true;
            }else
            {
                HistoricoTransacoes.Add($"Tentativa de saque falhou. Saldo insuficiente");
                Console.WriteLine($"Tentativa de saque falhou. Saldo insuficiente");
                return false;
            }
        }

        public void Transferir(double valor, ContaBancaria contaDestino)
        {
            if(Sacar(valor))
            {
                contaDestino.Depositar(valor);
                HistoricoTransacoes.Add($"Tranferencia de R${valor} realizada com sucesso para {contaDestino.NomeTitular}");
                contaDestino.HistoricoTransacoes.Add($"Tranferencia de R${valor} realizada com sucesso para {contaDestino.NomeTitular}");
                Console.WriteLine($"Tranferencia de R${valor} realizada com sucesso para {contaDestino.NomeTitular}");
            }else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }




    }
}