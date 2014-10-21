using System;

namespace StateManager {
    public class PauseState : State {
        public override bool Update(float deltaTime) {
            return false;
        }

        public override bool Draw() {
            Console.WriteLine("pauseState");
            return true;
        }

        public override void HandleInput(string key) {
            if (key == "p") {
                StateManager.PopState();
            }
            if (key == "q") {
                StateManager.PopState();
                StateManager.PopState();
            }
        }
    }
}