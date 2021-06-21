using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Project_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Variables
            char a1 = ' ', a2 = ' ', a3 = ' ', a4 = ' ', a5 = ' ', a6 = ' ', a7 = ' ', a8 = ' ', a9 = ' ';
            int Turn = 1;
            string p1 = "Ali",p2 = "Selin",p3 = "Utku",name;
            int Position1, Position2, Position3;
            int X, Y;
            int length;
            int horitest;
            bool horizontal;
            bool rightInput = false;
            char Replay='Y';
            int Ali = 8, Selin = 16, Utku = 25;
            Position1 = Ali;
            Position2 = Selin;
            Position3 = Utku;
            SoundPlayer player1 = new SoundPlayer("a.wav");
            SoundPlayer player2 = new SoundPlayer("b.wav");
            //Creating the Board
            Console.WriteLine("------------Turn " + Turn + "-------------");
            Console.WriteLine("           + - - - +");
            Console.WriteLine("          3| " + a1 + " " + a2 + " " + a3 + " |");
            Console.WriteLine("          2| " + a4 + " " + a5 + " " + a6 + " |");
            Console.WriteLine("          1| " + a7 + " " + a8 + " " + a9 + " |");
            Console.WriteLine("           + - - - +");
            Console.WriteLine("             1 2 3  ");
            while (Replay == 'Y')
            {
                player1.Play();
                Turn = 1;
                a1 = ' ';
                a2 = ' ';
                a3 = ' ';
                a4 = ' ';
                a5 = ' ';
                a6 = ' ';
                a7 = ' ';
                a8 = ' ';
                a9 = ' ';
                Replay = 'N';
                Console.SetCursorPosition(13, 2);
                Console.Write("      ");
                Console.SetCursorPosition(13, 3);
                Console.Write("      ");
                Console.SetCursorPosition(13, 4);
                Console.Write("      ");
                Console.SetCursorPosition(0, 22);
                Console.WriteLine("                                                        ");
                Console.Write("                                       ");
                Console.SetCursorPosition(0, 12);
                Console.Write("                                       ");
                Console.SetCursorPosition(0, 13);
                Console.Write("                                      ");
                while ((a1 == 'X' && a2 == 'X' && a3 == 'X' && a4 == 'X' && a5 == 'X' && a6 == 'X' && a7 == 'X' && a8 == 'X' && a9 == 'X') == false)
                {                    
                    //Cleanse of the Board
                    Console.SetCursorPosition(0, 0);
                    Console.Write("------------Turn " + Turn + "-------------");
                    Console.SetCursorPosition(14, 8);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(14, 9);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("                   ");
                    //Random Piece Generation
                    Random random = new Random();
                    length = random.Next(1, 4);
                    horitest = random.Next(1, 3);
                    if (horitest == 1)
                        horizontal = true;
                    else
                        horizontal = false;
                    Console.SetCursorPosition(30, 1);
                    Console.WriteLine("Generated Piece");
                    Console.SetCursorPosition(35, 2);
                    if (length == 1)
                        Console.WriteLine("X");
                    else if (length == 2)
                    {
                        if (horizontal)
                            Console.WriteLine("X X");
                        else
                        {
                            Console.WriteLine("X");
                            Console.SetCursorPosition(35, 3);
                            Console.WriteLine("X");
                        }
                    }
                    else
                    {
                        if (horizontal)
                            Console.WriteLine("X X X");
                        else
                        {
                            Console.WriteLine("X");
                            Console.SetCursorPosition(35, 3);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(35, 4);
                            Console.WriteLine("X");
                        }
                    }
                    //Reading the coordinates
                    X = -1;
                    Y = -1;
                    while (rightInput == false)
                    {
                        try
                        {
                            Console.SetCursorPosition(0, 8);
                            Console.Write("X coordinate:  ");
                            X = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Y coordinate:  ");
                            Y = Convert.ToInt16(Console.ReadLine());
                            Console.SetCursorPosition(0, 10);
                            Console.Write("                                              ");
                            rightInput = true;
                        }
                        catch
                        {
                            Console.SetCursorPosition(0, 10);
                            Console.Write("Please Enter an Integer");
                            Console.SetCursorPosition(14, 8);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(14, 9);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(0, 10);
                        }
                    }
                    rightInput = false;
                    // Placement
                    if (X == 0 && Y == 0)
                    {
                        Turn++;
                    }
                    else if ((X > 0 && X <= 3) && (Y > 0 && Y <= 3))
                    {
                        if (X == 1 && Y == 3)
                        {
                            if (length == 1)
                            {
                                if (a1 == ' ')
                                {
                                    a1 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(13, 2);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                {
                                    if (a1 == ' ' && a2 == ' ')
                                    {
                                        a1 = 'X';
                                        a2 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 2);
                                        Console.Write('X');

                                    }
                                    else
                                        Turn++;
                                }
                                else
                                {
                                    if (a1 == ' ' && a4 == ' ')
                                    {
                                        a1 = 'X';
                                        a4 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(13, 3);
                                        Console.Write('X');

                                    }
                                    else
                                        Turn++;
                                }

                            }
                            else
                            {
                                if (horizontal)
                                {
                                    if (a1 == ' ' && a2 == ' ' && a3 == ' ')
                                    {
                                        a1 = 'X';
                                        a2 = 'X';
                                        a3 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 2);
                                        Console.Write('X');

                                    }
                                    else
                                        Turn++;
                                }
                                else
                                {
                                    if (a1 == ' ' && a4 == ' ' && a7 == ' ')
                                    {
                                        a1 = 'X';
                                        a4 = 'X';
                                        a7 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(13, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(13, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                            }

                        }
                        else if (X == 2 && Y == 3)
                        {
                            if (length == 1)
                            {
                                if (a2 == ' ')
                                {
                                    a2 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(15, 2);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                {
                                    if (a2 == ' ' && a3 == ' ')
                                    {
                                        a2 = 'X';
                                        a3 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(15, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 2);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                                else
                                    if (a2 == ' ' && a5 == ' ')
                                {
                                    a2 = 'X';
                                    a5 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(15, 2);
                                    Console.Write('X');
                                    Console.SetCursorPosition(15, 3);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else
                            {
                                if (horizontal)
                                {
                                    Turn++;
                                }
                                else
                                {
                                    if (a2 == ' ' && a5 == ' ' && a8 == ' ')
                                    {
                                        a2 = 'X';
                                        a5 = 'X';
                                        a8 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(15, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 4);
                                        Console.Write('X');

                                    }
                                    else
                                        Turn++;
                                }
                            }
                        }
                        else if (X == 3 && Y == 3)
                        {
                            if (length == 1)
                            {
                                if (a3 == ' ')
                                {
                                    a3 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(17, 2);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                {
                                    Turn++;
                                }
                                else
                                {
                                    if (a3 == ' ' && a6 == ' ')
                                    {
                                        a3 = 'X';
                                        a6 = 'X';
                                        Console.SetCursorPosition(17, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 3);
                                        Console.Write('X');

                                    }
                                    else
                                        Turn++;
                                }
                            }
                            else
                            {
                                if (horizontal)
                                {
                                    Turn++;
                                }
                                else
                                {
                                    if (a3 == ' ' && a6 == ' ' && a9 == ' ')
                                    {
                                        a3 = 'X';
                                        a6 = 'X';
                                        a9 = 'X';
                                        Console.SetCursorPosition(17, 2);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                            }
                        }
                        else if (X == 1 && Y == 2)
                        {
                            if (length == 1)
                            {
                                if (a4 == ' ')
                                {
                                    a4 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(13, 3);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                {
                                    if (a4 == ' ' && a5 == ' ')
                                    {
                                        a4 = 'X';
                                        a5 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 3);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                                else
                                {
                                    if (a4 == ' ' && a7 == ' ')
                                    {
                                        a4 = 'X';
                                        a7 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(13, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                            }
                            else
                            {
                                if (horizontal)
                                {
                                    if (a4 == ' ' && a5 == ' ' && a6 == ' ')
                                    {
                                        a4 = 'X';
                                        a5 = 'X';
                                        a6 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 3);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                                else
                                    Turn++;
                            }

                        }
                        else if (X == 2 && Y == 2)
                        {
                            if (length == 1)
                            {
                                if (a5 == ' ')
                                {
                                    a5 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(15, 3);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                {
                                    if (a5 == ' ' && a6 == ' ')
                                    {
                                        a5 = 'X';
                                        a6 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(15, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 3);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                                else
                                {
                                    if (a5 == ' ' && a8 == ' ')
                                    {
                                        a5 = 'X';
                                        a8 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(15, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }

                            }
                            else
                                Turn++;
                        }
                        else if (X == 3 && Y == 2)
                        {
                            if (length == 1)
                            {
                                if (a6 == ' ')
                                {
                                    a6 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(17, 3);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                    Turn++;
                                else
                                {
                                    if (a6 == ' ' && a9 == ' ')
                                    {
                                        a6 = 'X';
                                        a9 = 'X';
                                        Console.SetCursorPosition(17, 3);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                            }
                            else
                                Turn++;
                        }
                        else if (X == 1 && Y == 1)
                        {
                            if (length == 1)
                            {
                                if (a7 == ' ')
                                {
                                    a7 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(13, 4);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                {
                                    if (a7 == ' ' && a8 == ' ')
                                    {
                                        a7 = 'X';
                                        a8 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 4);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                                else
                                    Turn++;
                            }
                            else
                            {
                                if (horizontal)
                                {
                                    if (a7 == ' ' && a8 == ' ' && a9 == ' ')
                                    {
                                        a7 = 'X';
                                        a8 = 'X';
                                        a9 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(13, 4);
                                        Console.Write('X');
                                        Console.SetCursorPosition(15, 4);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                                else
                                    Turn++;
                            }

                        }
                        else if (X == 2 && Y == 1)
                        {
                            if (length == 1)
                            {
                                if (a8 == ' ')
                                {
                                    a8 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(15, 4);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else if (length == 2)
                            {
                                if (horizontal)
                                {
                                    if (a8 == ' ' && a9 == ' ')
                                    {
                                        a8 = 'X';
                                        a9 = 'X';
                                        Turn++;
                                        Console.SetCursorPosition(15, 4);
                                        Console.Write('X');
                                        Console.SetCursorPosition(17, 4);
                                        Console.Write('X');
                                    }
                                    else
                                        Turn++;
                                }
                                else
                                    Turn++;
                            }
                            else
                                Turn++;
                        }
                        else if (X == 3 && Y == 1)
                        {
                            if (length == 1)
                            {
                                if (a9 == ' ')
                                {
                                    a9 = 'X';
                                    Turn++;
                                    Console.SetCursorPosition(17, 4);
                                    Console.Write('X');
                                }
                                else
                                    Turn++;
                            }
                            else
                                Turn++;
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine("Wrong Input!");
                    }
                }
                //Ending
                player1.Stop();
                player2.Play();
                Console.SetCursorPosition(0, 0);
                Console.Write("                                          ");
                Console.SetCursorPosition(0, 0);
                Console.Write("           Completed!");
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("Your Turn : " + (Turn - 1));
                Console.Write("Your Name : ");
                name = "Mahmut";
                while (rightInput == false)
                {
                    try
                    {
                        name = Convert.ToString(Console.ReadLine());
                        rightInput = true;
                    }
                    catch
                    {
                        Console.SetCursorPosition(0, 14);
                        Console.Write("Please Enter Your Name");
                    }
                }
                //Assigning the positions
                if (Turn <= Position1)
                {
                    p3 = p2;
                    p2 = p1;                   
                    p1 = name;
                    Position3 = Position2;
                    Position2 = Position1;
                    Position1 = Turn-1;
                }
                else if (Turn >Position1 && Turn <= Position2)
                {
                    p3 = p2;
                    p2 = name;
                    Position3 = Position2;
                    Position2 = Turn-1;
                }
                else if (Turn > Position2 && Turn <= Position3)
                {
                    p3 = name;
                    Position3 = Turn-1;
                }
                //High Score Table
                Console.SetCursorPosition(3, 18);
                Console.WriteLine("                   ");
                Console.SetCursorPosition(3, 19);
                Console.WriteLine("                   ");
                Console.SetCursorPosition(3, 20);
                Console.WriteLine("                   ");
                Console.SetCursorPosition(20, 18);
                Console.WriteLine("                   ");
                Console.SetCursorPosition(20, 19);
                Console.WriteLine("                   ");
                Console.SetCursorPosition(20, 20);
                Console.WriteLine("                   ");
                Console.SetCursorPosition(0, 16);
                Console.WriteLine("      High Score Table");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. " + p1);
                Console.WriteLine("2. " + p2);
                Console.WriteLine("3. " + p3);                
                Console.SetCursorPosition(20, 18);
                Console.WriteLine(Position1);
                Console.SetCursorPosition(20, 19);
                Console.WriteLine(Position2);
                Console.SetCursorPosition(20, 20);
                Console.WriteLine(Position3);
                //Replay
                Console.SetCursorPosition(0, 22);
                Console.WriteLine("Enter Y to play again");
                int z = Convert.ToChar((Console.ReadLine()));
                if (z =='Y' || z == 'y')
                {
                    Replay = 'Y';
                }                
            }           
        }
    }
}
