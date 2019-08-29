#pragma once

#ifdef AUDIOCONVERTER_EXPORTS
#define AUDIOCONVERTER_API extern "C" _declspec(dllexport)
#else
#define AUDIOCONVERTER_API extern "C" _declspec(dllimport)
#endif

AUDIOCONVERTER_NAMESPACE_BEGIN

//AAC2WAV
AUDIOCONVERTER_API bool TransAacToWav(const wchar_t* szAacPath, const wchar_t* szWavPath);

//Any2AAC
AUDIOCONVERTER_API bool TransAudioToAac(const wchar_t* szAudioPath, const wchar_t* szAacPath);

AUDIOCONVERTER_NAMESPACE_END