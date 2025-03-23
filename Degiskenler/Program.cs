// See https://aka.ms/new-console-template for more information
using System;

namespace Degiskenler
{
    class Program
    {
        static void Main()
        {
            User kullanici = new User("Berk Ali SARI", 19, "berkalisari679@gmail.com");
            Console.WriteLine(kullanici);

            Console.ReadLine();
        }
    }
}

