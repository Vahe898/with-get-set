using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_get_set
{
    internal class Queen
    {
        private int _numberForQueen;
        private char[] letterSForQueen = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        private char _letterForQueen;

        public int NumberForQueen
        {
            get
            {
                return _numberForQueen;
            }
            set
            {
                if (value > 0 && value < 9)
                {
                    _numberForQueen = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public char LetterForQueen
        {
            get
            {
                return _letterForQueen;

            }
            set
            {
                if (letterSForQueen.Contains(char.ToUpper(value)))
                {
                    _letterForQueen = char.ToUpper(value);
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }

        public void queenIsMoving(ref int inputNum, ref char inputLet)
        {
            do /*tivy kara luboy lini*/
            {
                Console.WriteLine("Enter number where to move ");
                NumberForQueen = int.Parse(Console.ReadLine());
            } while (NumberForQueen < 1 || NumberForQueen > 8);
            do
            {
                Console.WriteLine("enter letter where to move");
                LetterForQueen = Console.ReadKey().KeyChar;
                /*araji ify horizonakan dirqov kara gna sax tarerov baci vori vra ka*/
                if (NumberForQueen == inputNum && Array.IndexOf(letterSForQueen, LetterForQueen) != Array.IndexOf(letterSForQueen, inputLet))
                {
                    Console.WriteLine();
                    break;
                }
                /*uxxahayaca etum nuyn cev*/
                else if (NumberForQueen != inputNum && Array.IndexOf(letterSForQueen, LetterForQueen) == Array.IndexOf(letterSForQueen, inputLet))
                {
                    Console.WriteLine();
                    break;
                }
                /*diaganalov*/
                else if (Math.Abs(NumberForQueen - inputNum) == Math.Abs(Array.IndexOf(letterSForQueen, LetterForQueen) - Array.IndexOf(letterSForQueen, inputLet)))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    do /*tivy kara luboy lini*/
                    {
                        Console.WriteLine("Enter number where to move fore queen ");
                        NumberForQueen = int.Parse(Console.ReadLine());
                    } while (NumberForQueen < 1 || NumberForQueen > 8);

                }
            } while (true);
            inputNum = NumberForQueen;
            inputLet = LetterForQueen;
        }
    }
}
