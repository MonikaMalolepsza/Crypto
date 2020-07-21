//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Crypto.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.06.2020 Setup

using System;

namespace Crypto
{
    partial class main
    {
        static bool KeyInput(int menuChoice,ref string encrKey)
        {
            bool userInputActive = true;
            encrKey = "";

            do
            {
                Console.Clear();
                Console.WriteLine($"Please provide the key for {IntToMethodConverter(menuChoice)} encryption");
                Console.WriteLine(encrKey);
                Console.CursorTop = 2;
                Console.CursorLeft = encrKey.Length;
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Backspace)
                {
                    encrKey = encrKey.Substring(0, encrKey.Length > 0 ? encrKey.Length-1 : 0);
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    userInputActive = false;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    return true;
                }

                else
                {
                    if (menuChoice == 0)
                    {
                        if (char.IsDigit(key.KeyChar)
                            && ((key.KeyChar == '0'
                                 && encrKey.Length > 0) || (key.KeyChar != '0'))
                            || key.KeyChar == '-' && encrKey.Length == 0)
                        {
                            encrKey += key.KeyChar;
                        }
                        else
                        {
                            //empty
                        }
                    }
                    else if (menuChoice == 1)
                    {
                        //Vigenere
                        encrKey += key.KeyChar;

                    }
                    else if (menuChoice == 2)
                    {
                        //OTP
                    }
                    else
                    {
                        //empty
                    }
                }
            } while (userInputActive);
            return false;
        }

    }
}