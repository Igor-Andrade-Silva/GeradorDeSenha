using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenhas.Entities
{
    public class SenhaLetraNum
    {
        public string SenhaGerada { get; set; }
        public SenhaLetraNum()
        {
            char[] letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToArray();
            char[] numeros = "123456789".ToArray();
            Random random = new Random();
            Console.Write("Selecione a quantidade de caracteres desejados: ");
            string senha = null;
            int carac = int.Parse(Console.ReadLine());
            carac = carac / 2;
            string senhaReal = null;

            for (int i = 1; i <= carac; i++)
            {
                senha += letras[random.Next(0, letras.Length)];
                senha += numeros[random.Next(0, numeros.Length)];
                senha.ToArray();
            }
            for (int i = 1; i <= carac * 2; i++)
            {
                senhaReal += senha[random.Next(0, senha.Length)];
            }

            Console.WriteLine();

            Console.WriteLine(senhaReal);

            Console.WriteLine();
        }
    }
}
