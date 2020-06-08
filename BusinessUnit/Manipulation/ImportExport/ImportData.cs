﻿﻿//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Import.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.06.2020 Setup

using System;
using System.IO;
using System.Text;

namespace Crypto
{
    partial class main
    {
        static void ImportData(ref string Record, string filePath)
        {
            FileStream FS = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS, Encoding.UTF8); ;

             //Save into string
             Record = SR.ReadToEnd();

            SR.Close();
            FS.Close();
        }
    }
}