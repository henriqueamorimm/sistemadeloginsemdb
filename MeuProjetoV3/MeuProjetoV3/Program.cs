using System;
using System.Timers;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Clear();
            Console.Title = "Sistema de login e criar conta.";
            string user = "Aligg";
            string senha = "henrique@lindo";
            Console.WriteLine("Deseja fazer log-in ou criar uma conta?");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Log-in");
            Console.WriteLine("2. Criar Conta");
            Console.Write("Sua escolha:"); int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.Clear();
                goto Login;

            }
            if (escolha == 2)
            {
                Console.Clear();
                goto CriarConta;

            }
        Login:
            Console.WriteLine("Olá usuário, faça seu Log-in!");
            Console.Write("User:"); string user_RES = Console.ReadLine();
            Console.Write("Senha:"); string senha_RES = Console.ReadLine();
            if (user_RES == user && senha_RES == senha)
            {
                Console.Clear();
                Console.WriteLine($"Sucesso! Você logou como {user}!");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(5000);
                Console.WriteLine("Retornando para o sistema em 10 segundos...");
                Thread.Sleep(10000);
                goto Inicio;
            }
        CriarConta:
            Console.Clear();
            Console.WriteLine("Preencha as informações abaixo:");
            Console.Write("Seu nome de usuário:"); user = Console.ReadLine();
            Console.Write("Senha:"); senha = Console.ReadLine();
            Console.Clear();
            goto Login;



        }



    }
}
