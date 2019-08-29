// AudioConverter.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "AacConverter.h"
#include "AudioConverter.h"
#include "AudioConverterProxy.h"
#include "CodeConverter.h"
#include <string>
using std::string;

AUDIOCONVERTER_NAMESPACE_BEGIN

//AAC2WAV
AUDIOCONVERTER_API bool TransAacToWav(const wchar_t* szAacPath, const wchar_t* szWavPath)
{
	string aacPath = CodeConverter::UnicodeToUtf8(szAacPath);
	string wavPath = CodeConverter::UnicodeToUtf8(szWavPath);
	return AudioConverterProxy::TransAacToWav(aacPath, wavPath);
}

//Any2AAC
AUDIOCONVERTER_API bool TransAudioToAac(const wchar_t* szAudioPath, const wchar_t* szAacPath)
{
	string audioPath = CodeConverter::UnicodeToUtf8(szAudioPath);
	string aacPath = CodeConverter::UnicodeToUtf8(szAacPath);
	return AacConverter::TransAudio(audioPath, aacPath);
}

AUDIOCONVERTER_NAMESPACE_END