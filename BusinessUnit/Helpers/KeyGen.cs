//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        KeyGen.cs
//Datum:        08.06.2020
//Beschreibung: generates randomized key. Used for the one time pad encryption
//Aenderungen:  08.08.2020 Setup


using System;

namespace Crypto
{
    partial class main
    {
        static void KeyGen(ref string key, int length)
        {
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                key += (char)random.Next(0, 128);
            }

            ExportData(ref key, "key");
        }
    }
}