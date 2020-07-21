//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Splashinfo.cs
//Datum:        08.06.2020
//Beschreibung: Displays a splash info about the project.
//Aenderungen:  08.06.2020 Setup

using System;
using System.Threading;

namespace Crypto
{
    partial class main
    {
        static void Splashinfo()
        {
            string[] titles = { "Project name:", "Version:", "Data:", "Author:", "Class:" };
            string[] information = { "Encryption", "1.0", "08.06.2020", "Monika Malolepsza", "IA119" };
            Console.CursorTop = 5;
            for (int i = 0; i < information.Length; i++)
            {
                Console.CursorLeft = (Console.WindowWidth - 32) / 2;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("{0,-13}{1,20}", titles[i], information[i]);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(400);
            }
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.WindowHeight - 2);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

        }
    }
}