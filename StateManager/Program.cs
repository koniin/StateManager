using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StateManager {
    internal class Program {
        private static void Main(string[] args) {
            StateManager stateManager = new StateManager();
            stateManager.PushState(new MenuState());

            bool gameIsRunning = true;
            while (gameIsRunning) {
                stateManager.ChangeState();
                string key = GetKey();
                if (!string.IsNullOrEmpty(key))
                    stateManager.HandleInput(key);
                stateManager.Update(100);
                stateManager.Draw();

                if (stateManager.IsEmpty())
                    gameIsRunning = false;
                Thread.Sleep(200);
            }

            Console.WriteLine("Game Ended");
            Console.Read();
        }

        private static string GetKey() {
            if (Console.KeyAvailable) {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key) {
                    case ConsoleKey.F1:
                        Console.WriteLine("You pressed F1!");
                        break;
                    default:
                        return key.KeyChar.ToString();
                        break;
                }
            }
            return string.Empty;
        }
    }
}
