using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWhile
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int G=0;
            int A = 0;
            int i = 0;
            int quantidadeG = 0;
            int quantidadeA = 0;
            Console.Write("dijite quantidade de carros: ");
            int quantidadeDeCarros = Convert.ToInt32(Console.ReadLine());
            int somaAnos = 0;
           double somaValor=0;
            
            while (i < quantidadeDeCarros)
            {
                Console.Write("dijite o modelo: ");
                string modelo = Convert.ToString(Console.ReadLine());

                Console.Write("digite valor do carro: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.Write("digite ano do carro: ");
                int Anos = Convert.ToInt32(Console.ReadLine());

                somaAnos = somaAnos + Anos;
                somaValor=somaValor+valor;
                i = i + 1;

                string letra = modelo.Substring(0, 1);
                if(letra == "G")
                {
                    int quantidade = quantidadeG + 1;
                }
                if(letra == "A")
                {
                    int quantidade = quantidadeA + 1;
                }

            }
            double media = somaAnos / quantidadeDeCarros;
            Console.WriteLine("Media de anos de carro: "+media);
            double mediaV = somaValor / quantidadeDeCarros;
            Console.WriteLine("media de valor: "+mediaV);
            double mediaG = quantidadeG / quantidadeDeCarros;
            Console.WriteLine("media de carros comesam com G: "+mediaG);
            double mediaA = quantidadeA / quantidadeDeCarros;
            Console.WriteLine("madia de carros comesam com A: "+mediaA);

        }

    }
}
