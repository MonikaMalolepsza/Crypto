//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        RunAlgorithm.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.07.2020 Setup


namespace Crypto
{
     partial class main
    {
        static void RunAlgorithm(bool encDec, int menuChoiceEncryptionMethod, string key, ref string textToEncrypt, ref string result)

        {
            switch (menuChoiceEncryptionMethod)
            {
                case 0:
                    Ceasar(encDec, key,ref textToEncrypt, ref result);
                    break;
                case 1:
                    Vigenere(encDec, key,ref textToEncrypt, ref result);
                    break;
                case 2:
                    OTP(encDec, key, ref textToEncrypt, ref result);
                    break;
                default:
                    //empty
                    break;


            }
        }

    }
}