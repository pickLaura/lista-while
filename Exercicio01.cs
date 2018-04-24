using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio01
    {
        public Exercicio01()
        { 
            Console.WriteLine("digite sou nome");
            string nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite fim quando quiser sair");
            while (nome != "fim")
            {
                Console.WriteLine("digite seu nome");
                nome = Console.ReadLine();

            }
        }

    }
}
