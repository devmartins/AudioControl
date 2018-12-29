using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Windowws.Media
{
    public static class AudioControl
    {
        [DllImport("AudioControlNative.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetMasterVolume();

        [DllImport("AudioControlNative.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetMasterVolume(float volume);
    }
}
