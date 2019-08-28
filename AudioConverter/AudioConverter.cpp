// AudioConverter.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "AudioConverter.h"
#include "AudioConverterHelper.h"
#include "CodeConverter.h"
#include <string>
using std::string;

AudioConverterHelper helper;

AUDIOCONVERTER_NAMESPACE_BEGIN

//AAC转WAV
AUDIOCONVERTER_API bool TransAacToWav(const wchar_t* szAacPath, const wchar_t* szWavPath)
{
	string aacPath = CodeConverter::UnicodeToUtf8(szAacPath);
	string wavPath = CodeConverter::UnicodeToUtf8(szWavPath);
	return helper.TransAacToWav(aacPath, wavPath);
}

AUDIOCONVERTER_NAMESPACE_END