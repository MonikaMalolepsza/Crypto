//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Crypto.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.06.2020 Setup

namespace Crypto
{
    partial class main
    {
        static string IntToMethodConverter(int id)
        {
            switch (id)
            {
                case 0:
                    return "Ceasar";
                case 1:
                    return "Vigenere";
                case 2:
                   return "OTP";
                default:
                    return "";
            }
        }
    }
}