using System;
using System.Runtime.InteropServices;

namespace AudioConverterTestWinform
{
    internal class AudioConverterWrapperX64
    {
        internal const string DllName = @"AudioConverter_x64.dll";

        //AAC2WAV
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool TransAacToWav(string aacPath, string wavPath);

        //Audio2AAC
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool TransAudioToAac(string audioPath, string aacPath);
    }

    internal class AudioConverterWrapperX86
    {
        internal const string DllName = @"AudioConverter_x86.dll";

        //AAC2WAV
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool TransAacToWav(string aacPath, string wavPath);

        //Audio2AAC
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool TransAudioToAac(string audioPath, string aacPath);
    }

    internal class AudioConverterWrapper
    {
        internal const string DllName = @"AudioConverter_x64.dll";

        //AAC2WAV
        public static bool TransAacToWav(string aacPath, string wavPath)
        {
            if (IntPtr.Size == 4)
            {
                return AudioConverterWrapperX86.TransAacToWav(aacPath, wavPath);
            }
            else if (IntPtr.Size == 8)
            {
                return AudioConverterWrapperX64.TransAacToWav(aacPath, wavPath);
            }
            else
            {
                return false;
            }
        }

        //Audio2AAC
        public static bool TransAudioToAac(string audioPath, string aacPath)
        {
            if (IntPtr.Size == 4)
            {
                return AudioConverterWrapperX86.TransAudioToAac(audioPath, aacPath);
            }
            else if (IntPtr.Size == 8)
            {
                return AudioConverterWrapperX64.TransAudioToAac(audioPath, aacPath);
            }
            else
            {
                return false;
            }
        }
    }
}
