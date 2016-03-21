namespace AircraftShooter
{
    using Microsoft.Xna.Framework.Input;

    public class InputManager
    {
        private KeyboardState currentKeyBoardState;
        private KeyboardState previousKeyBoardState;

        public KeyboardState CurrentKeyBoardState 
        {
            get { return this.currentKeyBoardState; }
            set { this.currentKeyBoardState = value; }
        }

        public KeyboardState PreviousKeyBoardState 
        {
            get { return this.previousKeyBoardState; }
            set { this.previousKeyBoardState = value; }
        }

        public void Update()
        {
            previousKeyBoardState = currentKeyBoardState;
            currentKeyBoardState = Keyboard.GetState();

        }

        public bool KeyPressed(Keys key)
        {
            return this.currentKeyBoardState.IsKeyDown(key) && this.previousKeyBoardState.IsKeyDown(key);
        }

        public bool KeyPressed(params Keys[] keys)
        {
            foreach(Keys key in keys)
            {
                if (this.currentKeyBoardState.IsKeyDown(key) && this.previousKeyBoardState.IsKeyDown(key))
                    return true;
            }
            return false;
        }

        public bool KeyReleased(Keys key)
        {
            return this.currentKeyBoardState.IsKeyUp(key) && this.previousKeyBoardState.IsKeyUp(key);
        }

        public bool KeyReleased(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (this.currentKeyBoardState.IsKeyUp(key) && this.previousKeyBoardState.IsKeyUp(key))
                    return true;
            }
            return false;
        }

        public bool KeyDown(Keys key)
        {
            return currentKeyBoardState.IsKeyDown(key) && this.previousKeyBoardState.IsKeyUp(key);
        }

        public bool KeyDown(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyBoardState.IsKeyDown(key) && this.previousKeyBoardState.IsKeyUp(key))
                    return true;
            }
            return false;
        }
    }
}
