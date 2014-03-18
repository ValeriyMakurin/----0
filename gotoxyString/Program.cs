using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoxyString
{
    class Program
    {
        const int maxX = 79;
        const int maxY = 24;

        static void Pole()
        {
            Console.Clear();
            // верхняя граница
            Console.SetCursorPosition(1, 0);
            for (int i = 1; i < maxX; i++) Console.Write("-");
            // боковые границы
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= maxY; i++)
            {
                Console.SetCursorPosition(0, i); Console.Write("|");
                Console.SetCursorPosition(maxX, i); Console.Write("|");
            }
            // нижняя граница
            Console.SetCursorPosition(1, maxY);
            for (int i = 1; i < maxX; i++) Console.Write("-");
            Console.SetCursorPosition(0, 0);
        }

        static void Main(string[] args)
        {
            string str = "Hello world (default)";
            if (args.Length != 0)
            {
                str = "";
                foreach (string s in args)
                {
                    str += s+" ";
                }
                str = str.Remove(str.Length - 1);
            }
            Console.CursorVisible = false; // гасим курсор
            int x = maxX/2 - str.Length/2;
            int y = maxY/2;
            ConsoleKeyInfo k;

            do
            {
                Pole();               
                Console.SetCursorPosition(x, y);
                Console.Write(str);
                k = Console.ReadKey(true);

                if ((k.Key == ConsoleKey.UpArrow)&&(y>1))
                    y--;
                else if ((k.Key == ConsoleKey.DownArrow)&&(y<maxY-1))
                    y++;
                else if ((k.Key == ConsoleKey.LeftArrow)&&(x>1))
                    x--;
                else if ((k.Key == ConsoleKey.RightArrow)&&(x<maxX-str.Length))
                    x++;

                
            } while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc    
        }
    }
}
