using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INeedPopUpWindow
{
    public event EventHandler<OnPopUpWindowEventArgs> OnPopUpWindow;
    public class OnPopUpWindowEventArgs : EventArgs
    {
        public string windowContent;
    }
}
