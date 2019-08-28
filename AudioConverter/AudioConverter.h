#pragma once

#ifdef AUDIOCONVERTER_EXPORTS
#define AUDIOCONVERTER_API extern "C" _declspec(dllexport)
#else
#define AUDIOCONVERTER_API extern "C" _declspec(dllimport)
#endif

AUDIOCONVERTER_NAMESPACE_BEGIN

//AACתWAV
AUDIOCONVERTER_API bool TransAacToWav(const wchar_t* szAacPath, const wchar_t* szWavPath);

AUDIOCONVERTER_NAMESPACE_END