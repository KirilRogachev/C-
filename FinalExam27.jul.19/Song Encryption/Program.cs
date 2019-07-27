using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = "";
            while ((comand=Console.ReadLine())!="end")
            {
                string[] comandSplit = comand
                    .Split(":")
                    .ToArray();
                string artist = comandSplit[0];
                string song = comandSplit[1];

                string patternArt = @"^[A-Z][a-z\s']+$";
                string patternSOng = @"^[A-Z\s]+$";

                var validArt = Regex.Match(artist, patternArt);
                var validSong = Regex.Match(song,patternSOng);

                

                if(validArt.Success&&validSong.Success)
                {
                    StringBuilder encartist = new StringBuilder();
                    StringBuilder encsong = new StringBuilder();

                    int code = artist.Length;

                    for (int i = 0; i < artist.Length; i++)
                    {
                        int encrLetter = 0;
                        if (char.IsUpper(artist[i]) && artist[i] + code > 90)
                        {
                            encrLetter = artist[i] + code - 26;
                            encartist.Append((char)encrLetter);
                        }
                        else if (char.IsLower(artist[i]) && artist[i] + code > 122)
                        {
                            encrLetter = artist[i] + code - 26;
                            encartist.Append((char)encrLetter);
                        }
                        else if (artist[i] ==' ')
                        {
                            encartist.Append(' ');
                        }
                        else if(artist[i]=='\'')
                        {
                            encartist.Append('\'');
                        }
                        else
                        {
                            encrLetter = artist[i] + code;
                            encartist.Append((char)encrLetter);
                        }
                    }
                    for (int i = 0; i < song.Length; i++)
                    {
                        int encletter = 0;
                        if(song[i]+code>90)
                        {
                            encletter = song[i] + code - 26;
                            encsong.Append((char)encletter);
                        }
                        else if(song[i]==' ')
                        {
                            encsong.Append(' ');
                        }
                        else if(song[i]=='\'')
                        {
                            encsong.Append('\'');
                        }
                        else
                        {
                            encsong.Append((char)(song[i] + code));
                        }

                    }
                    Console.WriteLine($"Successful encryption: {encartist}@{encsong}");
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

            

            }
        }
    }
}
