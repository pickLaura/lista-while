using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWhile
{
    class exercicio3
    {public exercicio3()
        {
            Console.WriteLine("Digite seu peso");
            double peso = Convert.ToDouble(Console.ReadLine());
            while ((peso < 0) && (peso > 300.00))
            {
                Console.WriteLine("digite seu peso");
                peso = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
