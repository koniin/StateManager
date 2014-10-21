namespace StateManager {
    public abstract class State {
        protected StateManager stateManager;

        protected State(StateManager stateManager) {
            this.stateManager = stateManager;
        }

        // the bool return value marks if its fall through or not
        public abstract bool Update(float deltaTime);
        public abstract bool Draw();
        public abstract void HandleInput(string key);
    }
}