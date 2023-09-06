using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParaClub
{
    public class Plane
    {
        // Déclaration des variable
        public int _x;
        public int _y;

        private ConsoleColor _color;

        // Déclaration de la structure
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public Plane(ConsoleColor color)
        {
            _x = 0;
            _y = 2;
            _color = color;
        }

        public void show()
        {
            Console.ForegroundColor = _color;

            for(int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_y, i+_x);
                Console.Write(view[i]);
            }
        }

        public void update()
        {
            Console.MoveBufferArea(this._x, this._y, view.Length, 6, this._y++, this._x);
        }
    }
}
