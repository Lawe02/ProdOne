using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace ProjectOne.Services
{
    public class Library
    {
        public int MenuHandler(string[] options)
        {
            ConsoleKeyInfo keyinfo;
            int option = 0;
            var player = new SoundPlayer(@"C:\Users\Lawe Zangena\csharp\ProjectOne\anka.wav");

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--Använd upp/ner pilarna för att navigera i menyn, samt enter för att välja-- \n");
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < options.Length; i++)
                {
                    if(i == option)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(options[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.WriteLine(options[i]);
                }
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    option--;
                    if (option < 0)
                        option = options.Length -1;
                    player.Play();
                }
                else if(keyinfo.Key == ConsoleKey.DownArrow)
                {
                    option++;
                    if (option > options.Length-1)
                        option = 0;
                    player.Play();
                }
                else if(keyinfo.Key == ConsoleKey.Enter)
                {
                    return option + 1;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Följ instruktionerna från åvan");
                    Console.ReadLine();
                }
            }
        }
    }
}
