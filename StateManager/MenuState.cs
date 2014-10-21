using System;

namespace StateManager {
    public class MenuState : State {
        public MenuState(StateManager stateManager) : base(stateManager) {}

        public override bool Update(float deltaTime) {
            return false;
        }

        public override bool Draw() {
            Console.WriteLine("Menustate");
            return false;
        }

        public override void HandleInput(string key) {
            if (key == "g") {
                stateManager.PopState();
                stateManager.PushState(new GameState(stateManager));
            }
            if (key == "q") {
                stateManager.PopState();
            }
        }
    }
}