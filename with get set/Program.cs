using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace with_get_set
{
    internal class Program
    {
        static void makingChase(int inputNum, char inputLet, string inputFigur)
        {
            int[,] boardSize = new int[10, 10];
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0 && i < 8)/*tverna tpum*/
                    {
                        Console.Write(8 - i);
                    }
                    else if (i == 8 && j >= 0)/*tareri hamra*/
                    {
                        Console.Write($"  {letters[j]}");
                    }
                    if ((i + j) % 2 == 0 && i < 8)
                    {

                        Console.BackgroundColor = ConsoleColor.White;

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (8 - i == inputNum && letters[j] == char.ToUpper(inputLet)) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(inputFigur + "  ");
                    }
                    else if (i != 8 && j >= 0)
                    {
                        Console.Write("   ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public static void FigurGattintPoint(int inputNum, char inputLet, string inputFigur)
        {

            Figur figur = (Figur)Enum.Parse(typeof(Figur), inputFigur);
            switch (figur)
            {
                case Figur.k:
                    King redKing = new King();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redKing.kingIsMoving(ref inputNum, ref inputLet);
                        makingChase(redKing.NumberForKing, redKing.LetterForKing, inputFigur);
                    } while (true);


                    break;
                case Figur.q:
                    Queen redQueen = new Queen();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redQueen.queenIsMoving(ref inputNum, ref inputLet);/*refov em tve vor es tivy hety beri. aranc sra nuynner mnum  */
                        makingChase(redQueen.NumberForQueen, redQueen.LetterForQueen, inputFigur);/*ese clasic ogtvelov*/
                    } while (true);

                    break;
                case Figur.b:/*queen ic vercrel em diaganlov qaylely. bishopIsmoving i mej */
                    Bishop redBishop = new Bishop();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redBishop.BishopIsMoving(ref inputNum, ref inputLet);
                        makingChase(redBishop.NumberForBishop, redBishop.LetterForBishop, inputFigur);
                    } while (true);

                    break;
                case Figur.r:
                    Rook redRook = new Rook();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redRook.RookIsMoving(ref inputNum, ref inputLet);
                        makingChase(redRook.NumberForRook, redRook.LetterForRook, inputFigur);
                    } while (true);
                    break;
                case Figur.n:
                    night redNight = new night();

                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redNight.NightIsMoving(ref inputNum, ref inputLet);
                        makingChase(redNight.NumberForNight, redNight.LetterForNight, inputFigur);
                    } while (true);
                    break;
                //case Figur.p:
                //    makingChase(inputNum, inputLet, inputFigur);
                //    break;
                default:
                    break;
            }
        }
        public static void gettingStart(int number,char letter,string figur)
        {

            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            do
            {
                Console.WriteLine("Enter number ");
                number = int.Parse(Console.ReadLine());
            } while (number < 1 || number > 8);
            do
            {
                Console.WriteLine("enter letter");
                letter = Console.ReadKey().KeyChar;
                if (Array.IndexOf(letters, letter) != -1)
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                }

            } while (true);
            do
            {
                Console.WriteLine("Enter your figur");
                figur = Console.ReadLine();
                Figur figurEnum = (Figur)Enum.Parse(typeof(Figur), figur);
            } while (false);
        }
        static void Main(string[] args)
        {
            int num
            FigurGattintPoint(b, c, "n");
            
        }
    }
}
