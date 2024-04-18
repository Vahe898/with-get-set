using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_get_set
{
    internal class King
    {
        private int _numberForKing;
        private char _letterForKing;
        private char[] letterSForKing = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        public int NumberForKing
        {
            get
            {
                return _numberForKing;
            }
            set
            {
                if (value>0 && value<9)
                {
                    _numberForKing = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public char LetterForKing
        {
            get
            {
                return _letterForKing;

            }
            set
            {
                if (letterSForKing.Contains(char.ToUpper(value)))
                {
                    _letterForKing = char.ToUpper(value);
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public void kingIsMoving(ref int inputNum, ref char inputLet)
        {
            do/*nayuma tagavory kara gna et tvov texy te che*/
            {
                Console.WriteLine("Enter number wher to move ");
                NumberForKing = int.Parse(Console.ReadLine());
                if (NumberForKing == inputNum || NumberForKing + 1 == inputNum || NumberForKing - 1 == inputNum)
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("King cant reach to that number");
                }

                

            } while (true);

            do /*senc tarnenq tali*/
            {
                Console.WriteLine("enter letter where to move");
                LetterForKing = Console.ReadKey().KeyChar;
                if (Array.IndexOf(letterSForKing, LetterForKing) == Array.IndexOf(letterSForKing, inputLet) || Array.IndexOf(letterSForKing, LetterForKing) + 1 == Array.IndexOf(letterSForKing, inputLet) || Array.IndexOf(letterSForKing, LetterForKing) - 1 == Array.IndexOf(letterSForKing, inputLet))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine(  );
                    Console.WriteLine("King cant reach to that letter");

                }


            } while (true);
            inputNum = NumberForKing; inputLet = LetterForKing;

        }
    }
}
