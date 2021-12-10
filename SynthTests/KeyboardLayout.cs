using System.Collections.Generic;
using System.Windows.Input;

namespace SynthTests
{
    public class KeyboardLayout
    {
        public List<Key> BlackKeys { get; set; } = new List<Key>()
        { Key.W, Key.E, Key.R, Key.T, Key.Z, Key.U, Key.I, Key.O, Key.P };

        public List<Key> WhiteKeys { get; set; } = new List<Key>()
        { Key.A, Key.S, Key.D, Key.F, Key.G, Key.H, Key.J, Key.K, Key.L };

        #region Singleton          

        private static KeyboardLayout instance;

        public static KeyboardLayout Instance => instance ??= new KeyboardLayout();

        private KeyboardLayout()
        { }

        #endregion Singleton
    }
}
