using System;

namespace StateManager {
    public class GameState : State {
        public override bool Update(float deltaTime) {
            return false;
        }

        public override bool Draw() {
            Console.WriteLine("gameState");
            return false;
        }

        public override void HandleInput(string key) {
            if (key == "p") {
                StateManager.PushState(new PauseState());
            }
            if (key == "m") {
                StateManager.PopState();
                StateManager.PushState(new MenuState());
            }
        }
    }
}