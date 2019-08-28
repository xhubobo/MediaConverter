#pragma once
#include <string>
using namespace std;

class AudioConverterHelper
{
public:
	AudioConverterHelper();
	~AudioConverterHelper();

	bool TransAacToWav(const string& aacPath, const string& wavPath);
	bool CheckPath(const string& aacPath, const string& wavPath);

private:
	string m_sLastError;
};

