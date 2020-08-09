//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Vigenere.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.07.2020 Setup

using System;

namespace Crypto
{
    partial class main
    {
        static void Vigenere(bool encDec, string key, ref string textToEncrypt, ref string result)
        {
            if (encDec)
            {
                // encryption
                int keyIndex = 0;
                for (int i = 0; i < textToEncrypt.Length; i++)
                {
                    result += (char) ((textToEncrypt[i] + key[keyIndex]) % 127);
                    keyIndex++;
                    if (keyIndex > key.Length - 1)
                    {
                        keyIndex = 0;
                    }
                }
            }
            else
            {
                // decryption
                int keyIndex = 0;
                for (int i = 0; i < textToEncrypt.Length; i++)
                {
                    result += (char) ((textToEncrypt[i] + (127 - key[keyIndex])) % 127);
                    keyIndex++;
                    if (keyIndex > key.Length - 1)
                    {
                        keyIndex = 0;
                    }
                }

            }
        }
    }
}