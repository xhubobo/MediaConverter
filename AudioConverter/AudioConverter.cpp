// AudioConverter.cpp : ���� DLL Ӧ�ó���ĵ���������
//

#include "stdafx.h"
#include "AudioConverter.h"
#include "AudioConverterHelper.h"
#include "CodeConverter.h"
#include <string>
using std::string;

AudioConverterHelper helper;

AUDIOCONVERTER_NAMESPACE_BEGIN

//AACתWAV
AUDIOCONVERTER_API bool TransAacToWav(const wchar_t* szAacPath, const wchar_t* szWavPath)
{
	string aacPath = CodeConverter::UnicodeToUtf8(szAacPath);
	string wavPath = CodeConverter::UnicodeToUtf8(szWavPath);
	return helper.TransAacToWav(aacPath, wavPath);
}

AUDIOCONVERTER_NAMESPACE_END