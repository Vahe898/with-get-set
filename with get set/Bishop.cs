using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_get_set
{
    internal class Bishop

    {
        private int _numberForBishop;
        private char _letterForBishop;
        private char[] letterSForBishop = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        public int NumberForBishop
        {
            get
            {
                return _numberForBishop;
            }
            set
            {
                if (value > 0 && value < 9)
                {
                    _numberForBishop = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public char LetterForBishop
        {
            get
            {
                return _letterForBishop;

            }
            set
            {
                if (letterSForBishop.Contains(char.ToUpper(value)))
                {
                    _letterForBishop = char.ToUpper(value);
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public void BishopIsMoving(ref int inputNum, ref char inputLet)
        {
            do /*tivy kara luboy lini*/
            {
                Console.WriteLine("Enter number where to move ");
                NumberForBishop = int.Parse(Console.ReadLine());
            } while (NumberForBishop < 1 || NumberForBishop > 8);
            do
            {
                Console.WriteLine("enter letter where to move");
                LetterForBishop = Console.ReadKey().KeyChar;
                if (Math.Abs(NumberForBishop - inputNum) == Math.Abs(Array.IndexOf(letterSForBishop, LetterForBishop) - Array.IndexOf(letterSForBishop, inputLet)))
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
                        NumberForBishop = int.Parse(Console.ReadLine());
                    } while (NumberForBishop < 1 || NumberForBishop > 8);

                }
            } while (true);
            inputNum = NumberForBishop;
            inputLet = LetterForBishop;
        }
    }
}
