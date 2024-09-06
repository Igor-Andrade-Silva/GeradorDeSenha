using GeradorDeSenhas.Entities;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa gerador de senhas!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Escolha o tipo de senha que deseja gerar: ");
            Console.WriteLine();
            Console.WriteLine("1 - Apenas letras");
            Console.WriteLine("2 - Letras e números");
            Console.WriteLine("3 - Letras, números e caracteres especiais");
            Console.WriteLine();
            Console.Write("Digite o número da sua escolha: ");
            int tipoDeSenha = int.Parse(Console.ReadLine());
            Console.WriteLine();


            switch (tipoDeSenha)
            {
                case 1:
                    SenhaLetras senhaCharGerada = new SenhaLetras();
                    break;

                    case 2:
                    SenhaLetraNum senhaCharNumGerada = new SenhaLetraNum();
                    break;

                case 3:
                    SenhaLetraNumEsp senhaCharNumEspGerada = new SenhaLetraNumEsp();
                    break;
            }

        }

    }
}
