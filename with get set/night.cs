using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_get_set
{
    internal class night
    {
        private int _numberForNight;
        private char _letterForNight;
        private char[] letterSForNight = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        public int NumberForNight
        {
            get
            {
                return _numberForNight;
            }
            set
            {
                if (value > 0 && value < 9)
                {
                    _numberForNight = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public char LetterForNight
        {
            get
            {
                return _letterForNight;

            }
            set
            {
                if (letterSForNight.Contains(char.ToUpper(value)))
                {
                    _letterForNight = char.ToUpper(value);
                }
                else
                {
                    throw new ArgumentException($"{value} is not correct");
                }
            }
        }
        public void NightIsMoving(ref int inputNum, ref char inputLet)
        {
            do /*tivy kara  lini baci irranic 2 hat verev 2 hat nerqev*/
            {
                Console.WriteLine("Enter number where to move ");
                NumberForNight = int.Parse(Console.ReadLine());


            } while (NumberForNight == inputNum || Math.Abs(NumberForNight - inputNum) > 2);
            do
            {
                Console.WriteLine("enter letter where to move");
                LetterForNight = Console.ReadKey().KeyChar;

                if (Math.Abs(NumberForNight - inputNum) == 2 && Math.Abs(Array.IndexOf(letterSForNight, LetterForNight) - Array.IndexOf(letterSForNight, inputLet)) == 1)
                {
                    Console.WriteLine();
                    break;
                }
                if (Math.Abs(NumberForNight - inputNum) == 1 && Math.Abs(Array.IndexOf(letterSForNight, LetterForNight) - Array.IndexOf(letterSForNight, inputLet)) == 2)
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Enter number where to move ");
                        NumberForNight = int.Parse(Console.ReadLine());
                    } while (NumberForNight == inputNum || Math.Abs(NumberForNight - inputNum) > 2);
                }
            } while (true);
            inputNum = NumberForNight;
            inputLet = LetterForNight;
        }
    }
}
