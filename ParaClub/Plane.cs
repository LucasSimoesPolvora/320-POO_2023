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
        public int _y;
        public int _x;
        public int _compteur;

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
            _y = 2;
            _x = 2;
            _color = color;
        }

        public void show()
        {
            Console.ForegroundColor = _color;

            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x + _compteur, i + _y);
                Console.Write(view[i]);
            }
        }

        public void update()
        {
            _compteur++;
            if (this._compteur == Console.WindowWidth - 2)
            {
                this._compteur = 0;
            }
        }
    }
}
