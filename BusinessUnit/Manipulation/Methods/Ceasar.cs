//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Caesar.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.06.2020 Setup
//              08.08.2020 Fixed the incorrect method

using System;

namespace Crypto
{
    partial class main
    {
        static void Ceasar(bool encDec, string key,ref string textToEncrypt, ref string result)
        {
            int convertedKey = Convert.ToInt32(key);

            if (encDec)
            {
                //encryption

                for (int i = 0; i < textToEncrypt.Length; i++)
                {

                    result += (char)((textToEncrypt[i] + convertedKey) % 127);

                }
            }
            else
            {
                //decryption

                for (int i = 0; i < textToEncrypt.Length; i++)
                {

                    result += (char)((textToEncrypt[i] + (127-convertedKey)) % 127);

                }

            }
        }
    }
}