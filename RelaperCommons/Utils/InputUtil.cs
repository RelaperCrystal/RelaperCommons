// (C) RelaperCrystal 2021. See LICENSE for license.

// Codes from this file is conveyed from:
// https://github.com/Albo1125/Albo1125-Common/blob/master/Albo1125.Common/CommonLibrary/ExtensionMethods.cs
// Source file (C) Albo1125

using System.Windows.Forms;
using Rage;
using Rage.Native;

namespace RelaperCommons.Utils
{
    /// <summary>
    /// Provides methods to process user inputs (such as keyboard, mouse).
    /// </summary>
    public static class InputUtil
    {
        /// <summary>
        /// Determines whether the specified key is down in a safe condition.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key is down; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsKeyDown(Keys key)
        {
            if (NativeFunction.Natives.UPDATE_ONSCREEN_KEYBOARD<int>() != 0)
            {
                return Game.IsKeyDown(key);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified is down right now in a safe condition.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key is down; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsKeyDownRightNow(Keys key)
        {
            if (NativeFunction.Natives.UPDATE_ONSCREEN_KEYBOARD<int>() != 0)
            {
                return Game.IsKeyDownRightNow(key);
            }
            else
            {
                return false;
            }
        }
    }
}
