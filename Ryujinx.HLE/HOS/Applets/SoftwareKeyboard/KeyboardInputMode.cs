﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryujinx.HLE.HOS.Applets.SoftwareKeyboard
{
    /// <summary>
    /// Active input options set by the keyboard applet. These options allow keyboard
    /// players to input text without conflicting with the controller mappings.
    /// </summary>
    enum KeyboardInputMode : uint
    {
        ControllerAndKeyboard,
        KeyboardOnly,
        ControllerOnly,
        Count,
    }
}
