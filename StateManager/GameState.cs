using System;

namespace StateManager {
    public class GameState : State {
        public GameState(StateManager stateManager) : base(stateManager) {}

        public override bool Update(float deltaTime) {
            return false;
        }

        public override bool Draw() {
            Console.WriteLine("gameState");
            return false;
        }

        public override void HandleInput(string key) {
            if (key == "p") {
                stateManager.PushState(new PauseState(stateManager));
            }
            if (key == "m") {
                stateManager.PopState();
                stateManager.PushState(new MenuState(stateManager));
            }
        }
    }
}