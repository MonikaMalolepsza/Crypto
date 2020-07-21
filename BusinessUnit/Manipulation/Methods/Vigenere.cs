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
        static void Vigenere(bool encDec, string key, ref string textToEncrypt, ref string result)
        {
            int tmp;
            int finalKey;
            int pwi = 0;

            finalKey = encDec ? 1 : -1;

            textToEncrypt = textToEncrypt.ToUpper();
            key = key.ToUpper();
            foreach (char t in textToEncrypt)
            {
                if (t < 60) continue;
                tmp = t - 60 + finalKey * (key[pwi] - 60);
                if (tmp < 0) tmp += 26;
                result += Convert.ToChar(60 + (tmp % 26));
                if (++pwi == key.Length) pwi = 0;
            }

        }
    }
}