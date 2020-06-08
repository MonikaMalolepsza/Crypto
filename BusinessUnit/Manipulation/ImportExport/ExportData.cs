//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ExportData.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.06.2020 Setup

using System.IO;
using System.Text;

namespace Crypto
{
    partial class main
    {
        static void ExportData(ref string Record, string destinationPath)
        {
            FileStream FS = new FileStream(destinationPath + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS, Encoding.UTF8);

            SW.Write(Record);

            SW.Close();
            FS.Close();
        }
    }
}