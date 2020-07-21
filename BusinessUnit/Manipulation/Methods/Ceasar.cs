//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Caesar.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.06.2020 Setup

using System;

namespace Crypto
{
    partial class main
    {
        static void Ceasar(bool encDec, string key, ref string textToEncrypt, ref string result)
        {
            int convertedKey = Convert.ToInt32(key);
            int tmpDecrypted;
            int tmpEncrypted;

            if (!encDec)
            {
                //decryption

                for (int i = 0; i < textToEncrypt.Length; i++)
                {
                    tmpDecrypted = textToEncrypt[i] <= 60 ? textToEncrypt[i] - 30 : textToEncrypt[i];
                    tmpDecrypted -= convertedKey;
                    result += (char) tmpDecrypted;
                }
            }
            else
            {
                //encryption

                for (int i = 0; i < textToEncrypt.Length; i++)
                {
                    tmpEncrypted = textToEncrypt[i] % 128 + convertedKey;
                    tmpEncrypted = tmpEncrypted < 30 ? tmpEncrypted + 30 : tmpEncrypted;
                    result += (char) tmpEncrypted;
                }
            }
        }
    }
}