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
}
