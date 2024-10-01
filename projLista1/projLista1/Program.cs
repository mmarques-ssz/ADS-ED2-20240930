using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInteiros;
            listaInteiros = new List<int>();

            listaInteiros.Add(44);
            listaInteiros.Add(33);
            listaInteiros.Add(22);
            listaInteiros.Add(11);
            mostraLista(listaInteiros);

            listaInteiros.Insert(2, 77);
            listaInteiros.Insert(3, 33);
            mostraLista(listaInteiros);

            Console.WriteLine("Posição do 33: {0}", listaInteiros.IndexOf(33));
            Console.WriteLine("Posição do 33: {0}", listaInteiros.LastIndexOf(33));
            Console.WriteLine("Posição do 33: {0}", listaInteiros.IndexOf(99));

            Console.WriteLine("Removeu 44: {0}", 
                listaInteiros.Remove(44) ? "Sim" : "Não");

            Console.WriteLine("Removeu 44: {0}",
                listaInteiros.Remove(44) ? "Sim" : "Não");

            mostraLista(listaInteiros);

            listaInteiros.RemoveAt(3);
            mostraLista(listaInteiros);

        }

        static void mostraLista(List<int> lista)
        {
            Console.WriteLine("=== Qtde: {0} ===", lista.Count);
            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=========");
        }
    }
}
