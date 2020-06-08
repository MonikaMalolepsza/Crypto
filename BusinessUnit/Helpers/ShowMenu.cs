//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ShowMenu.cs
//Datum:        08.06.2020
//Beschreibung: Requires a string array with the menu items and a headline to be displayed.
//              After selection with the Enter key, the position of the selected
//              value is returned.
//Aenderungen:  08.06.2020 Setup

using System;

namespace Crypto
{

    partial class main
    {
        static int ShowMenu(ref string[] menuPoints, string headline)
        {
            int currentItem = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                Console.Clear();
                Console.WriteLine(headline + "\n");

                for (int counter = 0; counter < menuPoints.Length; counter++)
                {
                    if (currentItem == counter)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(menuPoints[counter]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(menuPoints[counter]);
                    }
                }

                Console.WriteLine("\n\nYou can navigate with the arrow keys.\nConfirm your entry with the return key.");
                key = Console.ReadKey(true);
                if (key.Key.ToString() == "DownArrow")
                {
                    currentItem++;
                    if (currentItem > menuPoints.Length - 1) currentItem = 0;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    currentItem--;
                    if (currentItem < 0) currentItem = menuPoints.Length - 1;
                }
            } while (key.Key.ToString() != "Enter");

            return currentItem;
        }
    }
}