using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBancarioAbstract.Control;
using ControleBancarioAbstract.Model;

namespace ControleBancarioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente cc = new ContaCorrente(1000 , 500);

            ContaPoupanca cp = new ContaPoupanca(0.1 , 5000);

            GerenciadorContas gerenciador = new GerenciadorContas(0);

            int operadorPrincipal = 0, operadorSecundario = 0;
            float valor = 0;

            do
            {

                Console.WriteLine("Digite a operação desejada \n1 - Conta Corrente" +
                    "\n2 - Conta Poupança" +
                    "\n3 - Consultar tolta dos saldos" +
                    "\n0 - Sair");

                operadorPrincipal = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (operadorPrincipal)
                {

                    case 1:
                        do
                        {

                            Console.WriteLine("Digite a operação desejada:" +
                                "\n1 - Depositar" +
                                "\n2 - Sacar" +
                                "\n3 - Consultar Saldo" +
                                "\n4 - Reajustar Saldo" +
                                "\n0 - sair para o menu principal");

                            operadorSecundario = int.Parse(Console.ReadLine());

                            Console.Clear();

                            switch (operadorSecundario)
                            {
                                case 1:
                                    Console.WriteLine("Digite o valor a ser depositado: \n");
                                    valor = float.Parse(Console.ReadLine());
                                    if (valor > 0)
                                    {
                                        cc.creditar(valor);
                                        Console.WriteLine("Operação eefetuada com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Operação não efetuado, valor inválido!");
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("Digite o valor a ser depositado: \n");
                                    valor = float.Parse(Console.ReadLine());

                                    if (cc.debitar(valor))
                                    {
                                        Console.WriteLine("Operação realizada com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficiente! Ou valor inserido inválido");
                                    }

                                    break;

                                case 3:
                                    Console.WriteLine("Saldo atual: " + cc.getSaldo());
                                    break;

                                case 4:
                                    cc.atualizarSaldos();
                                    Console.WriteLine("Atualizado com sucesso!");
                                    break;

                                case 0:
                                    //Quebra o loop pelo while, precisa desse case para funcionar//
                                    break;

                                default:
                                    Console.WriteLine("Caracetere digitado inválido");
                                    break;
                            }

                            Console.ReadKey();
                            Console.Clear();

                        } while (operadorSecundario != 0);
                        break;

                    case 2:
                        do
                        {

                            Console.WriteLine("Digite a operação desejada: " +
                                "\n1 - Depositar" +
                                "\n2 - Sacar" +
                                "\n3 - Consultar Saldo" +
                                "\n4 - Reajustar Saldo" +
                                "\n0 - sair para o menu principal");

                            operadorSecundario = int.Parse(Console.ReadLine());

                            Console.Clear();

                            switch (operadorSecundario)
                            {
                                case 1:
                                    Console.WriteLine("Digite o valor a ser depositado: \n");
                                    valor = float.Parse(Console.ReadLine());
                                    if (valor > 0)
                                    {
                                        cp.creditar(valor);
                                        Console.WriteLine("Operação eefetuada com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Operação não efetuado, valor inválido!");
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("Digite o valor a ser depositado: \n");
                                    valor = float.Parse(Console.ReadLine());

                                    if (cp.debitar(valor))
                                    {
                                        Console.WriteLine("Operação realizada com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficiente! Ou valor inserido inválido");
                                    }

                                    break;

                                case 3:
                                    Console.WriteLine("Saldo atual: " + cp.getSaldo());
                                    break;

                                case 4:
                                    cp.atualizarSaldos(0);
                                    Console.WriteLine("Atualizado com sucesso!");
                                    break;
                                case 0:
                                    //Quebra o loop pelo while, precisa desse case para funcionar//
                                    break;
                                default:
                                    Console.WriteLine("Caracetere digitado inválido");
                                    break;
                            }

                            Console.ReadKey();
                            Console.Clear();

                        } while (operadorSecundario != 0);
                        break;

                    case 3:
                        do
                        {

                            Console.WriteLine("Digite a operação desejada: " +
                               "\n1 - Consultar Saldo" +
                               "\n2 - Reajustar Saldo" +
                               "\n0 - sair para o menu principal");

                            operadorSecundario = int.Parse(Console.ReadLine());

                            Console.Clear();

                            switch (operadorSecundario)
                            {
                                case 1:
                                    Console.WriteLine("O saldo total é igual: " + gerenciador.getSaldoTotal());
                                    break;

                                case 2:
                                    gerenciador.setSaldoTotal(0);
                                    gerenciador.totalizarSaldos(cp);
                                    gerenciador.totalizarSaldos(cc);
                                    Console.WriteLine("Atualizado com sucesso!");
                                    break;
                                case 0:
                                    //Quebra o loop pelo while, precisa desse case para funcionar//
                                    break;
                                default:
                                    Console.WriteLine("Caractere inválido");
                                    break;
                            }

                            Console.ReadKey();
                            Console.Clear();

                        } while (operadorSecundario != 0);
                        break;

                    case 0:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Caractere inválido! Insira um número válido!");
                        break;

                }

            } while (operadorPrincipal != 0);

        }
    }
}
