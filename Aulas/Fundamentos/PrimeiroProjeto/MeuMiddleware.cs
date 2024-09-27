using System;

namespace PrimeiroProjeto
{
    public static class MeuMiddleware
    {
        public static void Middleware1()
        {
            Console.WriteLine("Logando...");
        }

        public static void Middleware2()
        {
            Console.WriteLine("Autenticando...");
        }

        public static void Middleware3()
        {
            Console.WriteLine("Acessando...");
        }
    }
}