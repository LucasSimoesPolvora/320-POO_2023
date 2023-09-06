using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Screen config
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            Plane plane = new Plane(ConsoleColor.Blue);

            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();


                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.show();

                // Temporiser
                Thread.Sleep(100);
            }
        }
    }
}
