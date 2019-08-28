#include "stdafx.h"
#include "AudioConverterHelper.h"
#include <fstream>


AudioConverterHelper::AudioConverterHelper()
{
}


AudioConverterHelper::~AudioConverterHelper()
{
}

bool AudioConverterHelper::TransAacToWav(const string& aacPath, const string& wavPath)
{
	if (!CheckPath(aacPath, wavPath))
	{
		return false;
	}

	return false;
}

bool AudioConverterHelper::CheckPath(const string& inFilePath, const string& outFilePath)
{
	ifstream fin(inFilePath);
	if (!fin)
	{
		m_sLastError = "音频文件不存在";
		return false;
	}
	fin.close();

	//打开并情况WAV文件，如果文件不存在就创建
	ofstream fout(outFilePath);
	if (!fout)
	{
		m_sLastError = "创建音频文件失败";
		return false;
	}
	fout.close();

	return true;
}
