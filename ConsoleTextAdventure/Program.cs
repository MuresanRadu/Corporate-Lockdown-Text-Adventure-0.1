using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateLockdown
{
    class Program
    {
        public static bool quit;

        static void Main()
        {
            GameManager.ShowTitleScreen();
            Level.Initialize();
            GameManager.StartGame();

            while (!quit)
            {
                CommandProcessor.ProcessCommand(Console.ReadLine());
            }
        }
    }
}
