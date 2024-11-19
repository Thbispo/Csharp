using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Clientes
    {
        public void Cadastro()
        {

            Console.WriteLine("Bem-vindo ao Cadastro de Clientes!");
            Console.WriteLine("Digite 1 para criar um novo cadastro.");
            Console.WriteLine("Digite 2 para voltar ao menu principal.");

            if (!int.TryParse(Console.ReadLine(), out int select) || (select != 1 && select != 2))
            {
                Console.WriteLine("Opção inválida! Voltando ao menu principal.");
                Thread.Sleep(1500);
                return;
            }

            if (select == 1)
            {
                CadastroDetalhes();
            }
        }

        private void CadastroDetalhes()
        {
            Console.Clear();
            Console.WriteLine("Digite as informações do cliente:");

            Console.Write("Nome: ");
            string nomeCli = Console.ReadLine(); ;
            
            Console.Write("CPF: ");
            string cpfCli = Console.ReadLine();
            
            Console.Write("Telefone: ");
            string telCli = Console.ReadLine();
            
            Console.Write("Idade: ");
            string idadeCli = Console.ReadLine();

            Console.Write("E-mail: ");
            string mailCli = Console.ReadLine();




            Console.WriteLine("\nCadastro concluído!");
            Console.WriteLine($"Nome: {nomeCli}, CPF: {cpfCli}, Telefone: {telCli}, Idade: {idadeCli}, E-mail: {mailCli}");
            Thread.Sleep(2000);
            Console.Clear();
            Menu Select = new Menu();
            Select.Menu();
        }
    }
}