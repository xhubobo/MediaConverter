#pragma once
#include <string>
using std::string;


class AudioConverterProxy
{
public:
	static bool TransAacToWav(const string& aacPath, const string& wavPath);
};

