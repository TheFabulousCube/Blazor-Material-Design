using Microsoft.JSInterop;
using System;

namespace MaterialDesign.Data
{
    public class GlobalData
    {
        public static int GlobalCount {get;set;}

        [JSInvokable]
        public static void UpdateGlobal (int newValue)
        {
            GlobalCount = newValue;
        }

    }
}

