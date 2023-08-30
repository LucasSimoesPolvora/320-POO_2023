using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclarations des constantes
            const string CONST_STRING_ESCARGOT_VIVANT = "_@_ö";                 // Constante qui sauvegardera la forme de l'escargot vivant
            const string CONST_STRING_ESCARGOT_MORT = "____";                   // Constante qui sauvegardera la forme de l'escargot mort
            const int CONST_INT_PV_MAX = 50;                                    // PV max de l'escargot
            const int CONST_INT_VITESSE = 100;                                  // Vitesse de l'escargot

            // Déclarations des variables
            int intPVRestants;                                                  // Variable qui aura le nombre de pv de l'escargot
            int intPositionX = 0;                                               // Variable qui aura la position de l'escargot dans l'axe X 
            int intPositionY = 10;                                              // Variable qui aura la position de l'escargot dans l'axe Y

            // Début du programme
            Console.CursorVisible = false;


            // Mettre la couleur de l'escargot
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(intPositionX, intPositionY);
            Console.Write(CONST_STRING_ESCARGOT_VIVANT);
            do
            {
                intPVRestants = CONST_INT_PV_MAX - intPositionX;
                Console.MoveBufferArea(intPositionX, intPositionY, CONST_STRING_ESCARGOT_VIVANT.Length,1, intPositionX + 1, intPositionY);
                Console.CursorVisible = false;
                intPositionX++;
                Thread.Sleep(CONST_INT_VITESSE);
            }
            while (intPVRestants > 0) ;
            Console.SetCursorPosition(intPositionX, intPositionY);
            Console.Write(CONST_STRING_ESCARGOT_MORT);
            Console.Read();
        }
    }
}
