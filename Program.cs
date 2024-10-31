using System.Diagnostics;
using contaBancaria.src;

class Program
{
    static List<ContaBancaria> contas = new List<ContaBancaria>();
    static int contatdorNumeroConta = 1;

    static void Main()
    {
        while(true)
        {
            Console.WriteLine("---CONTA BANCARIA---");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("[1] Criar nova conta bancária");
            Console.WriteLine("[2] Exibir Saldo em conta");
            Console.WriteLine("[3] Depositar Dinheiro");
            Console.WriteLine("[4] Sacar Dinheiro");
            Console.WriteLine("[5] Transferir dinheiro entre contas");
            Console.WriteLine("[6] Exibir histórico de transações");
            Console.WriteLine("[0] Sair");


            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    CriarConta();
                    break;
                case "2":
                    ExibirSaldo();
                    break;
                case "3":
                    DepositarDinheiro();
                    break;
                case "4":
                    SacarDinheiro();
                    break;
                case "5":
                    TransferirDinheiro();
                    break;
                case "6":
                    ExibirHistoricoTransacoes();
                    break;
                case "0":
                    Console.WriteLine("Saindo do sistema...");
                    return;
                default:
                    Console.WriteLine("Opção INVÁLIDA, tente novamente");
                    break;
                

            }


            static void CriarConta()
            {
                Console.WriteLine("Digite o nome do titular da conta: ");
                string nomeTitular = Console.ReadLine();

                ContaBancaria novaConta = new ContaBancaria(contatdorNumeroConta++, nomeTitular);
                contas.Add(novaConta);
                Console.Write($"Sr {nomeTitular} sua conta foi criada com sucesso\nO número da sua conta é {novaConta.NumeroConta}");

            }

            static ContaBancaria SelecionarConta()
            {
                Console.WriteLine("Insira o número da conta: ");
                int numeroConta;
                if(int.TryParse(Console.ReadLine(), out numeroConta))
                {
                    return contas.Find(c => c.NumeroConta == numeroConta);
                }else
                {
                    Console.WriteLine("Conta não encontrada");
                    return null;
                }

            }

            static void ExibirSaldo()
            {
                var conta = SelecionarConta();
                if(conta != null)
                {
                    Console.WriteLine($"Saldo atual da conta {conta.NumeroConta}: {conta.Saldo}");
                }
            }

            static void DepositarDinheiro()
            {
                var conta = SelecionarConta();
                if(conta != null)
                {
                    Console.Write("Digite o valor do depósito");
                    double valor;
                    if(double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                    {
                        conta.Depositar(valor);
                        Console.WriteLine($"Depósito de R${valor} realizado com sucesso");
                    }else
                    {
                        Console.WriteLine("Depósito inválido");
                    }
                }
            }

            static void SacarDinheiro()
            {
                var conta = SelecionarConta();
                if(conta != null)
                {
                    Console.Write("Digite o valor de saque: ");
                    double valor;
                    if(double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                    {
                        if(conta.Sacar(valor))
                        {
                            Console.WriteLine($"Saque de R${valor} realizado com SUCESSO");
                        }else
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                    }
                }else
                {
                    Console.WriteLine("Valor de saque inválido");
                }
            }

            static void TransferirDinheiro()
            {
                Console.Write("Conta de origem: ");
                var contaOrigem = SelecionarConta();
                if(contaOrigem != null)
                {
                    Console.WriteLine("Conta de destino");
                    var contaDestino = SelecionarConta();

                    if(contaDestino != null){
                        Console.Write("Digite o valor de transferência: ");
                        double valor;
                        if(double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                        {
                            contaOrigem.Transferir(valor, contaDestino);
                            Console.WriteLine($"Transferencia de R${valor} realizada com sucesso");
                        }else
                        {
                            Console.WriteLine("Valor de transferência inválido");
                        }
                    }
                }
            }

            static void ExibirHistoricoTransacoes()
            {
                var conta = SelecionarConta();
                if(conta != null)
                {
                    Console.WriteLine("Histórico de transações");
                    foreach(var transacao in conta.HistoricoTransacoes)
                    {
                        Console.WriteLine(transacao);
                    }
                }
            }
        }
    }
}