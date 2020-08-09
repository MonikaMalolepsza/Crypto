//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        OTP.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  09.08.2020 Setup - one Time Pad encryption and decryption method

namespace Crypto
{
    partial class main
    {
        static void OTP(bool encDec,string key, ref string textToEncrypt,ref string result)
        {

            if (encDec)
            {
                // encryption
                for (int i = 0; i < textToEncrypt.Length; i++)
                {
                    result += (char) (textToEncrypt[i] ^ key[i]);
                }
            }
            else
            {
                // decryption
                for (int i = 0; i < textToEncrypt.Length; i++)
                {
                    result += (char) (textToEncrypt[i] ^ key[i]);
                }
            }

        }
    }
}