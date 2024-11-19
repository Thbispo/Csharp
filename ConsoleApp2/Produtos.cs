using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Produtos
    {
        List<ProdutoCad> listaProdutos = new List<ProdutoCad>();
        public void Produtoss()
        {


            Console.WriteLine("Bem-vindo ao Cadastro de Produtos!");
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

        public void CadastroDetalhes()
        {
            Console.Clear();
            Console.WriteLine("Registro de Produto:");

            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Produto.marca = marca;

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();


            var Produto = ProdutoCad(descPro);

            Console.Write("Tamanho: ");
            string tamanho = Console.ReadLine();
            Produto.tam = tamanho;

            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Produto.corPro = cor;

            Console.Write("Categoria: ");
            string categoria = Console.ReadLine();
            Produto.catPro = categoria;

            Console.Write("Valor: ");
            double valor = double.Parse(Console.ReadLine());
            Produto.valorPro = valor;

            Console.Write("Peso: ");
            double peso = double.Parse(Console.ReadLine());
            Produto.pesoPro = pesoPro;

            listaProdutos.Add(Produto);

            Console.WriteLine("\nCadastro concluído!");

            foreach (var produto in listaProdutos)
            //            nova variavel
            {
                Console.WriteLine ($"Descrição:{produto.descPro}," +
                $" " + $"Valor:{produto.valPro} ");
            }

            Console.WriteLine($"Marca: {marca}, Tamanho: {tamanho}, Cor: {cor}, Categoria: {categoria}, Valor: {valor}");
            Thread.Sleep(2000);
            Console.Clear();

            Cabecalho variavel = new Cabecalho();
            variavelCabecalho.Cabecalho();
        }
    }
}