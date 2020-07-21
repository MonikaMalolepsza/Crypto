//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        MainMenu.cs
//Datum:        08.06.2020
//Beschreibung:
//Aenderungen:  08.06.2020 Setup

namespace Crypto
{

    partial class main
    {
        static void MainMenu()
        {
            bool activeMenu = true;
            string headline = "Main Menu";
            string[] mainMenuPoints = { "Ceasar", "Vigenere", "OTP", "Exit" };
            string[] encDecMenuPoints = { "Encryption", "Decryption", "Exit" };
            bool encDecSelection = false;
            bool destPathSelection = false;
            bool sourcePathSelection = false;
            string key = "";
            bool encDec = false;

            string sourcePath = "";
            string destinationPath = "";
            string textToEncrypt = "";
            string result = "";


            do
            {
                int menuChoiceEncryptionMethod = ShowMenu(ref mainMenuPoints, headline);

                if (menuChoiceEncryptionMethod == 0)
                {
                    encDecSelection = true;

                  do
                  {
                      int encDecChoice = ShowMenu(ref encDecMenuPoints, "Encryption/Decryption Menu");

                      if (encDecChoice == 0)
                      {
                          // Enc
                          do
                          {
                              destPathSelection = true;
                              encDec = true;

                              if (ImportExportPath(true, true, ref sourcePath))
                              {
                                  ImportData(ref textToEncrypt, sourcePath);
                                  sourcePathSelection = true;

                                  do
                                  {
                                      if (ImportExportPath(false, true, ref destinationPath))
                                      {
                                          if (KeyInput(menuChoiceEncryptionMethod, ref key))
                                          {
                                              RunAlgorithm(false, menuChoiceEncryptionMethod, key, ref textToEncrypt, ref result);
                                              ExportData(ref result, destinationPath);
                                              destPathSelection = false;
                                              sourcePathSelection = false;
                                              encDecSelection = false;
                                          }
                                          else
                                          {
                                            //empty
                                          }

                                      }
                                      else
                                      {
                                          sourcePathSelection = false;
                                      }

                                  } while (sourcePathSelection);

                              }
                              else
                              {
                                  destPathSelection = false;
                              }

                          } while (destPathSelection);


                      }
                      else if (encDecChoice == 1)
                      {
                         // Dec
                         do
                         {
                             destPathSelection = true;
                             encDec = true;

                             if (ImportExportPath(true, false, ref sourcePath))
                             {
                                 ImportData(ref textToEncrypt, sourcePath);
                                 sourcePathSelection = true;

                                 do
                                 {
                                     if (ImportExportPath(false, false, ref destinationPath))
                                     {
                                         if (KeyInput(menuChoiceEncryptionMethod, ref key))
                                         {
                                             RunAlgorithm(false, menuChoiceEncryptionMethod, key, ref textToEncrypt, ref result);
                                             ExportData(ref result, destinationPath);
                                             destPathSelection = false;
                                             sourcePathSelection = false;
                                             encDecSelection = false;
                                         }
                                         else
                                         {
                                            //empty
                                         }

                                     }
                                     else
                                     {
                                         sourcePathSelection = false;
                                     }

                                 } while (sourcePathSelection);

                             }
                             else
                             {
                                 destPathSelection = false;
                             }

                         } while (destPathSelection);

                      }
                      else
                      {
                          encDecSelection = false;
                      }


                  } while (encDecSelection);


                }
                else if (menuChoiceEncryptionMethod == 1)
                {
                    //Vigenere
                       encDecSelection = true;

                  do
                  {
                      int encDecChoice = ShowMenu(ref encDecMenuPoints, "Encryption/Decryption Menu");

                      if (encDecChoice == 0)
                      {
                          // Enc
                          do
                          {
                              destPathSelection = true;
                              encDec = true;

                              if (ImportExportPath(true, true, ref sourcePath))
                              {
                                  ImportData(ref textToEncrypt, sourcePath);
                                  sourcePathSelection = true;

                                  do
                                  {
                                      if (ImportExportPath(false, true, ref destinationPath))
                                      {
                                          if (KeyInput(menuChoiceEncryptionMethod, ref key))
                                          {
                                              RunAlgorithm(false, menuChoiceEncryptionMethod, key, ref textToEncrypt, ref result);
                                              ExportData(ref result, destinationPath);
                                              destPathSelection = false;
                                              sourcePathSelection = false;
                                              encDecSelection = false;
                                          }
                                          else
                                          {
                                            //empty
                                          }

                                      }
                                      else
                                      {
                                          sourcePathSelection = false;
                                      }

                                  } while (sourcePathSelection);

                              }
                              else
                              {
                                  destPathSelection = false;
                              }

                          } while (destPathSelection);


                      }
                      else if (encDecChoice == 1)
                      {
                         // Dec
                         do
                         {
                             destPathSelection = true;
                             encDec = true;

                             if (ImportExportPath(true, false, ref sourcePath))
                             {
                                 ImportData(ref textToEncrypt, sourcePath);
                                 sourcePathSelection = true;

                                 do
                                 {
                                     if (ImportExportPath(false, false, ref destinationPath))
                                     {
                                         if (KeyInput(menuChoiceEncryptionMethod, ref key))
                                         {
                                             RunAlgorithm(false, menuChoiceEncryptionMethod, key, ref textToEncrypt, ref result);
                                             ExportData(ref result, destinationPath);
                                             destPathSelection = false;
                                             sourcePathSelection = false;
                                             encDecSelection = false;
                                         }
                                         else
                                         {
                                            //empty
                                         }

                                     }
                                     else
                                     {
                                         sourcePathSelection = false;
                                     }

                                 } while (sourcePathSelection);

                             }
                             else
                             {
                                 destPathSelection = false;
                             }

                         } while (destPathSelection);

                      }
                      else
                      {
                          encDecSelection = false;
                      }


                  } while (encDecSelection);

                }
                else if (menuChoiceEncryptionMethod == 2)
                {
                    //OTP
                }
                else if (menuChoiceEncryptionMethod == 3)
                {
                    activeMenu = false;
                }
                else
                {
                    //Nichts
                }

            } while (activeMenu);
        }
    }
}