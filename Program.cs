using System;

namespace Exercitando_1
{
    public class Program
    {
        static void ExibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta ;

            
            Console.WriteLine("Thiago ");
            
            Console.WriteLine(@"

███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
           
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            ExibirCabecalho();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            opcoesMenu();
        }

        static void opcoesMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Verificar número (positivo/negativo/zero)");
                Console.WriteLine("2. Determinar o maior de três números");
                Console.WriteLine("3. Verificar dias de um mês");
                Console.WriteLine("4. Verificar se um ano é bissexto");
                Console.WriteLine("5. Verificar se é maior ou menor de idade");
                Console.WriteLine("6. Calculadora Simples");
                Console.WriteLine("7. Sair");
                Console.Write("Digite a sua escolha: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        VerificarNumero();
                        break;
                    case "2":
                        DeterminarMaiorNumero();
                        break;
                    case "3":
                        VerificarDiasNoMes();
                        break;
                    case "4":
                        VerificarAnoBissexto();
                        break;
                    case "5":
                        VerificarIdade();
                        break;
                    case "6":
                        CalculadoraSimples();
                        break;
                    case "7":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }

        static void VerificarNumero()
        {
            Console.Clear();
            Console.WriteLine("Digite um número:");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }

        static void DeterminarMaiorNumero()
        {
            Console.Clear();
            Console.WriteLine("Digite três números:");

            double numero1 = Convert.ToDouble(Console.ReadLine());
            double numero2 = Convert.ToDouble(Console.ReadLine());
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double maiorNumero = Math.Max(numero1, Math.Max(numero2, numero3));

            Console.WriteLine("O maior número é: " + maiorNumero);
        }

        static int DiasNoMes(string mes)
        {
            switch (mes.ToLower())
            {
                case "janeiro": return 31;
                case "fevereiro": return 28;
                case "março": return 31;
                case "abril": return 30;
                case "maio": return 31;
                case "junho": return 30;
                case "julho": return 31;
                case "agosto": return 31;
                case "setembro": return 30;
                case "outubro": return 31;
                case "novembro": return 30;
                case "dezembro": return 31;
                default: return -1;
            }
        }

        static void VerificarDiasNoMes()
        {
            Console.Clear();
            Console.Write("Digite o nome do mês: ");
            string mes = Console.ReadLine();

            int dias = DiasNoMes(mes);

            if (dias == -1)
            {
                Console.WriteLine("Mês inválido. Tente novamente.");
            }
            else
            {
                Console.WriteLine($"O mês de {mes} tem {dias} dias.");
            }
        }

        static void VerificarAnoBissexto()
        {
            Console.Clear();
            Console.Write("Digite um ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (EhAnoBissexto(ano))
            {
                Console.WriteLine($"O ano {ano} é bissexto.");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é bissexto.");
            }
        }

        static bool EhAnoBissexto(int ano)
        {
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }

        static void VerificarIdade()
        {
            Console.Clear();
            Console.Write("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }

        static void CalculadoraSimples()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.Write("Digite o número da operação: ");
            string operacao = Console.ReadLine();

            double resultado = 0;

            switch (operacao)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado da adição: {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado da subtração: {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado da divisão: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida. Tente novamente.");
                    break;
            }
        }
    }
}
