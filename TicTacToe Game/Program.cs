using System;

namespace TicTacToe_Game
{
    internal class Program
    {
        static readonly char[,] array2D =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static bool isGameOver = false;

        static void Main()
        {

            int player = 2;
            string input;
            int inputNumber = 0;

            //do
            //{

            //    if (player == 2)
            //    {
            //        player = 1;

            //    }
            //    else if (player == 1)
            //    {
            //        player = 2;

            //    }
            //    SetField();

            //    bool inputCorrect;
            //    do
            //    {
            //        Console.Write("\nPlayer {0} : Choose Your Field!  ", player);
            //        input = Console.ReadLine();
            //        if (int.TryParse(input, out int numberInput))
            //        {
            //            if (numberInput > 0 && numberInput <= 9)
            //            {
            //                inputCorrect = true;
            //                inputNumber = numberInput;
            //            }
            //            else
            //            {
            //                inputCorrect = false;
            //            }
            //        }
            //        else
            //        {
            //            inputCorrect = false;
            //        }

            //    } while (!inputCorrect);
            //    EnterXOrO(player, inputNumber);

            //} while (!isGameOver);

            SetField();

            while (!isGameOver)
            {
                if (player == 2)
                {
                    player = 1;
                }else if(player == 1)
                {
                    player = 2;
                }

                bool inputCorrect = false;

                while (!inputCorrect)
                {
                    Console.Write("\nPlayer {0} : Choose Your Field!  ", player);
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int numberInput))
                    {
                        if(numberInput > 0 && numberInput <= 9)
                        {
                            inputCorrect = true;
                            inputNumber = numberInput;

                        }
                        else
                        {
                            inputCorrect = false;
                        }
                    }
                    else
                    {
                        inputCorrect = false;
                    }
                }

                EnterXOrO(player, inputNumber);

                SetField();

                Checker(player);

            }
            
            //Console.ReadKey();
        }

        static void SetField()
        {

            if (!isGameOver)
            {
                Console.Clear();
            }
           
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.WriteLine("     |     |     ");

                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if(j < 2)
                    {
                        Console.Write("  " + array2D[i, j] + "  |");
                    }
                    else
                    {
                        Console.Write("  " + array2D[i, j] + "  ");
                    }
                    
                                
                }
                Console.WriteLine();
                Console.WriteLine("_____|_____|_____");
            }

        }
       
        static void EnterXOrO(int player, int input)
        {
            char PlayerSign;
            if(player == 1)
            {
                PlayerSign = 'O';
            }
            else
            {
                PlayerSign = 'X';
            }

            switch (input)
            {
                case 1:
                    array2D[0, 0] = PlayerSign;break;
                case 2:
                    array2D[0, 1] = PlayerSign;break;
                case 3:
                    array2D[0, 2] = PlayerSign;break;
                case 4:
                    array2D[1, 0] = PlayerSign;break;
                case 5:
                    array2D[1, 1] = PlayerSign;break;
                case 6:
                    array2D[1, 2] = PlayerSign;break;
                case 7:
                    array2D[2, 0] = PlayerSign;break;
                case 8:
                    array2D[2,1] = PlayerSign;break;
                case 9:
                    array2D[2,2] = PlayerSign;break;
                default:
                    break;
            }
        }
        static void Checker(int player)
        {
            int playerWins = 0;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if(array2D[i,0] == array2D[i,1] && array2D[i,1] == array2D[i, 2])
                    {
                        playerWins = player;
                        isGameOver = true;
                    }else if(array2D[0,j] == array2D[1,j] && array2D[1,j] == array2D[2,j])
                    {
                        playerWins = player;
                        isGameOver = true;
                    }else if(array2D[0,0] == array2D[1,1] && array2D[1,1] == array2D[2, 2])
                    {
                        playerWins = player;
                        isGameOver = true;
                    }else if(array2D[0,2] == array2D[1,1] && array2D[1,1] == array2D[2, 0])
                    {
                        playerWins = player;
                        isGameOver = true;
                    }
                 
                }
            }

            if(playerWins != 0)
            {
                Console.WriteLine("Player {0} wins", playerWins);
            }

        }

    }
}
