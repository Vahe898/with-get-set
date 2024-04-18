using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_get_set
{
    internal class Rook
    {
        private int _numberForRook;
        private char _letterForRook;
        private char[] letterSForRook = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        public int NumberForRook
        {
            get
            {
                return _numberForRook;
            }
            set
            {
                if (value > 0 && value < 9)
                {
                    _numberForRook = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public char LetterForRook
        {
            get
            {
                return _letterForRook;

            }
            set
            {
                if (letterSForRook.Contains(char.ToUpper(value)))
                {
                    _letterForRook = char.ToUpper(value);
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public void RookIsMoving(ref int inputNum, ref char inputLet)
        {
            do /*tivy kara luboy lini*/
            {
                Console.WriteLine("Enter number where to move ");
                NumberForRook = int.Parse(Console.ReadLine());
            } while (NumberForRook < 1 || NumberForRook > 8);
            do
            {
                Console.WriteLine("enter letter where to move");
                LetterForRook = Console.ReadKey().KeyChar;
                /*araji ify horizonakan dirqov kara gna sax tarerov baci vori vra ka*/
                if (NumberForRook == inputNum && Array.IndexOf(letterSForRook, LetterForRook) != Array.IndexOf(letterSForRook, inputLet))
                {
                    Console.WriteLine();
                    break;
                }
                /*uxxahayaca etum nuyn cev*/
                else if (NumberForRook != inputNum && Array.IndexOf(letterSForRook, LetterForRook) == Array.IndexOf(letterSForRook, inputLet))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    do /*tivy kara luboy lini*/
                    {
                        Console.WriteLine("Enter number where to move ");
                        NumberForRook = int.Parse(Console.ReadLine());
                    } while (NumberForRook < 1 || NumberForRook > 8);
                }
            } while (true);
            inputNum = NumberForRook;
            inputLet = LetterForRook;
        }
    }
}
