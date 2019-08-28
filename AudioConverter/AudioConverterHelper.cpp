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
		m_sLastError = "��Ƶ�ļ�������";
		return false;
	}
	fin.close();

	//�򿪲����WAV�ļ�������ļ������ھʹ���
	ofstream fout(outFilePath);
	if (!fout)
	{
		m_sLastError = "������Ƶ�ļ�ʧ��";
		return false;
	}
	fout.close();

	return true;
}
