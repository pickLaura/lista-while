using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio02
    {
        public Exercicio02()
        {
            Console.WriteLine("digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            
            while (idade < 128)
            {
                Console.WriteLine("digite sua idade");
                idade =  Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
