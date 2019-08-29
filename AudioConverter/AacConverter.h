#pragma once
#include <string>
using std::string;

class AacConverter
{
public:
	AacConverter();
	~AacConverter();

	static bool TransAudio(const string& audioPath, const string& aacPath);
};

