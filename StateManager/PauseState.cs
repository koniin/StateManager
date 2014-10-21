using System;

namespace StateManager {
    public class PauseState : State {
        public PauseState(StateManager stateManager) : base(stateManager) {}

        public override bool Update(float deltaTime) {
            return false;
        }

        public override bool Draw() {
            Console.WriteLine("pauseState");
            return true;
        }

        public override void HandleInput(string key) {
            if (key == "p") {
                stateManager.PopState();
            }
            if (key == "q") {
                stateManager.PopState();
                stateManager.PopState();
            }
        }
    }
}