using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne.Data;

namespace ProjectOne.Services
{
    public class RPSServices
    {
        public RPSResult Game(ApplicationDbContext db)
        {
            var gamearr = new[] { "sten", "sax", "påse" };
            

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("STEN...");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("SAXX...");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("PÅ.");
                Thread.Sleep(500);
                Console.WriteLine("SE");

                int human_Choise = Choise();
                int computer_Choise = ComputersChoise();
                char result;
                
                if(human_Choise == computer_Choise)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lika båda tog {gamearr[human_Choise-1]}");
                    result = 'D';
                }
                else if((human_Choise == 1 && computer_Choise == 2) || (human_Choise == 2 && computer_Choise == 3) || (human_Choise == 3 && computer_Choise == 1))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Grattis, du slog makinen! {gamearr[human_Choise-1]} slår {gamearr[computer_Choise-1]}");
                    result = 'W';
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Datorn vann! {gamearr[computer_Choise-1]} slår {gamearr[human_Choise-1]}");
                    result = 'L';
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tryck enter för att gå vidare");
                Console.ReadLine();
                var RPSObj = new RPSResult(result, DateTime.Now, gamearr[computer_Choise-1], gamearr[human_Choise-1], GetWinRate(db, result == 'W' ? 1 : 0));
                return RPSObj;
                break;
            }
        }
        public void ShowRate(ApplicationDbContext db)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var rate = db.Results.ToList().Select(x => x.WinRate).Last();
            rate *= 100;
            rate = Math.Round(rate, 2);
            Console.WriteLine($"Nuvarande snitt ligger på {rate} %");
            Console.WriteLine($"Tryck enter för att gå vidare");
            Console.ReadLine();
        }
        public int Choise()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ange 1 för sten, 2 för sax, 3 för påse");
                if(int.TryParse(Console.ReadLine(), out int val))
                {
                    if (val > 0 && val < 4)
                    {
                        return val;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ange 1,2 eller 3");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ange en siffra");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        public int ComputersChoise()
        {
            Random rnd = new Random();
            int randomChoise = rnd.Next(1,4);
            return randomChoise;
        }
        public double GetWinRate(ApplicationDbContext db, int win)
        {
            var wins = db.Results.ToList().Count(x => x.Result == 'W');
            wins += win;
            var games = db.Results.ToList().Count();
            games += 1;
            double winrate = (double)wins / games;
            return winrate;
        }
    }
}
