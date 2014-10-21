using System;
using System.Collections.Generic;

namespace StateManager {
    public class StateManager {
        private readonly Stack<State> stateStack;
        private readonly Queue<Action> stateQueue;

        public StateManager() {
            stateStack = new Stack<State>();
            stateQueue = new Queue<Action>();
        }

        public void Update(float deltaTime) {
            foreach (var state in stateStack) {
                if (!state.Update(deltaTime))
                    return;
            }
        }

        public void Draw() {
            foreach (var state in stateStack) {
                if (!state.Draw())
                    return;
            }
        }

        public void HandleInput(string key) {
            State currentState = stateStack.Peek();
            currentState.HandleInput(key);
        }

        public void PopState() {
            stateQueue.Enqueue(() => stateStack.Pop());
        }

        public void PushState(State state) {
            stateQueue.Enqueue(() => stateStack.Push(state));
        }

        public void ChangeState() {
            while (stateQueue.Count != 0) {
                Action action = stateQueue.Dequeue();
                action();
            }
        }

        public bool IsEmpty() {
            return stateStack.Count == 0;
        }
    }
}
