using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenhas.Entities
{
    public class SenhaLetras
    {
        public string SenhaGerada { get; set; }
        public SenhaLetras() 
        {
            char[] letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToArray();
            Random random = new Random();            
            Console.Write("Selecione a quantidade de caracteres desejados: ");
            string senha = null;
            int carac = int.Parse(Console.ReadLine());

           for (int i = 1; i <= carac; i++)
            {
              senha += letras[random.Next(0, letras.Length)];
            }
            Console.WriteLine();

            Console.WriteLine(senha);

            Console.WriteLine();
        }
    }
}
