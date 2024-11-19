using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Cabecalho
    {
        public void Cabecalho()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+========================================================+");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Thiago Bispo Souza");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+========================================================+");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\r\n██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗\r\n██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝\r\n██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░\r\n██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░\r\n██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗\r\n╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.WriteLine("+========================================================+");
            Console.ResetColor();
        }
    }
}