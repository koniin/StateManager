using System;

namespace StateManager {
    public class MenuState : State {
        public override bool Update(float deltaTime) {
            return false;
        }

        public override bool Draw() {
            Console.WriteLine("Menustate");
            return false;
        }

        public override void HandleInput(string key) {
            if (key == "g") {
                StateManager.PopState();
                StateManager.PushState(new GameState());
            }
            if (key == "q") {
                StateManager.PopState();
            }
        }
    }
}