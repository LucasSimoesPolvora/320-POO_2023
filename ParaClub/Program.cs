﻿using System;
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

            // Disable cursor
            Console.CursorVisible = false;

            // Déclaration des variables
            ConsoleKeyInfo keyPressed;

            Plane plane = new Plane(ConsoleColor.Blue);


            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();

                Console.Clear();
                plane.show();

                // Temporiser
                Thread.Sleep(10);

                if (Console.KeyAvailable)
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        case ConsoleKey.Spacebar:
                            {

                                break;
                            }
                    }

                }
            }
        }
    }
}
