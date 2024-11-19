using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class ExibirMenu
    {
        public void Menu(Produtos varPro)
        {
            List<ProdutoCad> listaP = new List<ProdutoCad>();
            
                
                
                Cabecalho cab = new Cabecalho();

            while (true)
            {
                cab.Cabecalho();

                Console.WriteLine("Digite 0 para sair.");
                Console.WriteLine("Digite 1 para Cadastro de Clientes.");
                Console.WriteLine("Digite 2 para Listar Clientes.");
                Console.WriteLine("Digite 3 para Cadastro de Produtos.");
                Console.WriteLine("Digite 4 para Listar Produtos.");
                Console.WriteLine("\nDigite a opção escolhida:");

                if (!int.TryParse(Console.ReadLine(), out int select))
                {
                    Console.WriteLine("Entrada inválida! Digite um número.");
                    Thread.Sleep(2000);
                    continue;
                }

                switch (select)
                {
                    case 0:
                       varCli.cadCliente();
                    case 1:
                        Console.Clear();
                        Clientes cadastroCliente = new Clientes();
                        cadastroCliente.Cadastro();
                        break;
                    case 2:
                        Console.WriteLine("Listar clientes ainda não implementado.");
                        Thread.Sleep(1500);
                        break;
                    case 3:
                        varPro.CadProdutos();
                            break;
                    case 4:
                        Console.WriteLine("Listar produtos ainda não implementado.");
                        Thread.Sleep(1500);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }
    }
}
