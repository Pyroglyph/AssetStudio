using OpenTK.Input;

namespace AssetStudio.StudioClasses
{
    public static class InputHelper
    {
        private static KeyboardState _ks, _oks;


        public static void Begin()
        {
            _ks = Keyboard.GetState();
        }
        public static void End()
        {
            _oks = _ks;
        }


        public static bool IsKeyDown(Key key) => 
            _ks.IsKeyDown(key);

        public static bool IsNewKeyDown(Key key) => 
            _ks.IsKeyDown(key) && _oks.IsKeyUp(key);


        public static bool IsCtrlDown => 
            _ks.IsKeyDown(Key.LControl) || _ks.IsKeyDown(Key.RControl);

        public static bool IsAltDown => 
            _ks.IsKeyDown(Key.LAlt) || _ks.IsKeyDown(Key.RAlt);

        public static bool IsShiftDown => 
            _ks.IsKeyDown(Key.LShift) || _ks.IsKeyDown(Key.RShift);
    }
}
