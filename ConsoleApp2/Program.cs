using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ExibirMenu select = new ExibirMenu();
            select.Menu(varPro);

            Produtos varPro = new Produtos();

            
            Clientes varCLi = new Clientes();
            //Vai criar um novo produto,dando o nome de varPro
        }
    }
}