using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Coisa> listaCoisas = new List<Coisa>();

            listaCoisas.Add(new Coisa(1, "Coisa Um"));
            listaCoisas.Add(new Coisa(2, "Coisa Dois"));
            listaCoisas.Add(new Coisa(3, "Coisa Três"));
            listaCoisas.Add(new Coisa(4, "Coisa Quatro"));
            mostraCoisas(listaCoisas);

            Console.WriteLine(listaCoisas.IndexOf(new Coisa(3)));

            Coisa outraCoisa = new Coisa(10, "Coisa Dez");
            listaCoisas.Insert(2, outraCoisa);
            mostraCoisas(listaCoisas);

           
            outraCoisa.Y = "Coisa vinte";
            mostraCoisas(listaCoisas);

            listaCoisas[2].Y = "Outra coisa";
            mostraCoisas(listaCoisas);

            Console.WriteLine(outraCoisa.ToString());








            Console.WriteLine("Removeu a coisa 2: {0}",
                listaCoisas.Remove(new Coisa(2)) ? "Sim" : "Não");

            mostraCoisas(listaCoisas);

            





        }
        
        static void mostraCoisas(List<Coisa> asCoisas)
        {
            Console.WriteLine("=== Qtde: {0} ===", asCoisas.Count);  
            foreach(Coisa coisa in asCoisas)
            {
                Console.WriteLine(coisa.ToString());
            }
            Console.WriteLine("========="); 
        }

    }
}
