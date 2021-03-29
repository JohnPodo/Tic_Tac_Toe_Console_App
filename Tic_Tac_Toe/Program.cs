using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {

        static void show(string x, string y,string z)
        {
            
          
                Console.Write($"{x}|{y}|{z}");
                Console.WriteLine();
            
        }

        static bool Checkme(string x,string y, string z,string a)
        {
            if ((a == x && x != "X" && x != "O") || (a == y && y != "X" && y != "O") || (a == z && z != "X" && z != "O")) 
                return true;
            else
                return false;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a two player game of tic tac toe");
            Console.Write("Please give me the name of the first player: ");
            string nameone = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please give me the name of the second player: ");
            string nametwo = Console.ReadLine();
            Console.WriteLine();
            Random random = new Random();
            int playagain = 0;
            int score1 = 0;
            int score2 = 0;
            while (playagain == 0)
            {
                int who_plays_first = random.Next(1, 3);
                int towin = 0;
                string[] tic = new string[3] { "1", "4", "7" };
                string[] tac = new string[3] { "2", "5", "8" };
                string[] toe = new string[3] { "3", "6", "9" };
                int count = 0;

                while (towin == 0)
                {
                    if ((who_plays_first == 1) && (towin == 0))
                    {
                        Console.WriteLine($"{nameone} its your turn");
                        for (int i = 0; i < 3; i++)
                        {
                            show(tic[i], tac[i], toe[i]);
                        }
                        Console.Write("Make your move : ");
                        string answer = Console.ReadLine();
                        Console.WriteLine();
                        bool check = false;
                        bool checkone = false;
                        while (check == false)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (Checkme(tic[i], tac[i], toe[i], answer) == true)
                                {
                                    i = 3;
                                    checkone = true;
                                }

                            }
                            if (checkone == true)
                            {
                                check = true;
                                for (int i = 0; i < 3; i++)
                                {
                                    if (tic[i] == answer)
                                    {
                                        tic[i] = "X";
                                        count = count + 1;
                                    }
                                    else if (tac[i] == answer)
                                    {
                                        tac[i] = "X";
                                        count = count + 1;
                                    }
                                    else if (toe[i] == answer)
                                    {
                                        toe[i] = "X";
                                        count = count + 1;
                                    }
                                }
                            }
                            else
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    show(tic[i], tac[i], toe[i]);
                                }
                                Console.Write("Invalid move please make a valid move");
                                answer = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        if (((tic[0] == tic[1]) && (tic[0] == tic[2]) && (tic[0] == "X")) || ((tac[0] == tac[1]) && (tac[0] == tac[2]) && (tac[0] == "X")) || ((toe[0] == toe[1]) && (toe[0] == toe[2]) && (toe[0] == "X")))
                        {
                            towin = 1;
                            Console.WriteLine($"{nameone} won the game.Good game");
                            score1 = score1 + 1;
                            for (int i = 0; i < 3; i++)
                            {
                                show(tic[i], tac[i], toe[i]);
                            }
                        }
                        else if (((tic[0] == tac[0]) && (tic[0] == toe[0]) && (tic[0] == "X")) || ((tic[1] == tac[1]) && (tic[1] == toe[1]) && (tic[1] == "X")) || ((tic[2] == tac[2]) && (tic[2] == toe[2]) && (tic[2] == "X")))
                        {
                            towin = 1;
                            Console.WriteLine($"{nameone} won the game.Good game");
                            score1 = score1 + 1;
                            for (int i = 0; i < 3; i++)
                            {
                                show(tic[i], tac[i], toe[i]);
                            }
                        }
                        else if (((tic[0] == tac[1]) && (tic[0] == toe[2]) && (tic[0] == "X")) || ((tic[2] == tac[1]) && (tic[2] == toe[0]) && (tic[2] == "X")))
                        {
                            towin = 1;
                            Console.WriteLine($"{nameone} won the game.Good game");
                            score1 = score1 + 1;
                            for (int i = 0; i < 3; i++)
                            {
                                show(tic[i], tac[i], toe[i]);
                            }
                        }
                        who_plays_first = 2;

                    }

                    if ((who_plays_first == 2) && (towin == 0))
                    {
                        Console.WriteLine($"{nametwo} its your turn");
                        for (int i = 0; i < 3; i++)
                        {
                            show(tic[i], tac[i], toe[i]);
                        }
                        Console.Write("Make your move : ");
                        string answer = Console.ReadLine();
                        Console.WriteLine();
                        bool check = false;
                        bool checkone = false;
                        while (check == false)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (Checkme(tic[i], tac[i], toe[i], answer) == true)
                                {
                                    i = 3;
                                    checkone = true;
                                }

                            }
                            if (checkone == true)
                            {
                                check = true;
                                for (int i = 0; i < 3; i++)
                                {
                                    if (tic[i] == answer)
                                    {
                                        tic[i] = "O";
                                        count = count + 1;
                                    }
                                    else if (tac[i] == answer)
                                    {
                                        tac[i] = "O";
                                        count = count + 1;
                                    }
                                    else if (toe[i] == answer)
                                    {
                                        toe[i] = "O";
                                        count = count + 1;
                                    }
                                }
                            }
                            else
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    show(tic[i], tac[i], toe[i]);
                                }
                                Console.Write("Invalid move please make a valid move:  ");
                                answer = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        if (((tic[0] == tic[1]) && (tic[0] == tic[2]) && (tic[0] == "O")) || ((tac[0] == tac[1]) && (tac[0] == tac[2]) && (tac[0] == "O")) || ((toe[0] == toe[1]) && (toe[0] == toe[2]) && (toe[0] == "O")))
                        {
                            towin = 1;
                            Console.WriteLine($"{nametwo} won the game.Good game");
                            score2 = score2 + 1;
                            for (int i = 0; i < 3; i++)
                            {
                                show(tic[i], tac[i], toe[i]);
                            }
                        }
                        else if (((tic[0] == tac[0]) && (tic[0] == toe[0]) && (tic[0] == "O")) || ((tic[1] == tac[1]) && (tic[1] == toe[1]) && (tic[1] == "O")) || ((tic[2] == tac[2]) && (tic[2] == toe[2]) && (tic[2] == "O")))
                        {
                            towin = 1;
                            Console.WriteLine($"{nametwo} won the game.Good game");
                            score2 = score2 + 1;
                            for (int i = 0; i < 3; i++)
                            {
                                show(tic[i], tac[i], toe[i]);
                            }
                        }
                        else if (((tic[0] == tac[1]) && (tic[0] == toe[2]) && (tic[0] == "O")) || ((tic[2] == tac[1]) && (tic[2] == toe[0]) && (tic[2] == "O")))
                        {
                            towin = 1;
                            Console.WriteLine($"{nametwo} won the game.Good game");
                            score2 = score2 + 1;
                            for (int i = 0; i < 3; i++)
                            {
                                show(tic[i], tac[i], toe[i]);
                            }
                        }
                        who_plays_first = 1;

                    }
                    if ((count >= 7) && (towin == 0))
                    {
                        Console.WriteLine("Its a Draw");
                        for (int i = 0; i < 3; i++)
                        {
                            show(tic[i], tac[i], toe[i]);
                        }
                        towin = 1;
                    }
                }
                Console.WriteLine($"{nameone} {score1}  :  {score2} {nametwo}");
                Console.WriteLine("If you wish a rematch press 1 otherwise press 0 to end me");
                string rematch = Console.ReadLine();
                int re = 0;
                while (re == 0)
                {
                    if (rematch == "1")
                    {
                        Console.WriteLine("Here we go again");
                        re = 1;
                    }
                    else if (rematch == "0")
                    {
                        Console.WriteLine("Bye");
                        playagain = 1;
                        re = 1;
                    }
                    else
                    {
                        Console.WriteLine("If you wish a rematch press 1 otherwise press 0 to end me");
                        rematch = Console.ReadLine();
                    }
                }
            }           
        }
    }
}
