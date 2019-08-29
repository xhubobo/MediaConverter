#pragma once
#include <string>
using std::string;

#ifdef __cplusplus
extern "C"
{
#include "libavformat/avformat.h"
#include "libavformat/avio.h"

#include "libavcodec/avcodec.h"

#include "libavutil/audio_fifo.h"
#include "libavutil/avassert.h"
#include "libavutil/avstring.h"
#include "libavutil/frame.h"
#include "libavutil/opt.h"

#include "libswresample/swresample.h"
}
#endif

class AudioConverterProxy
{
public:
	static bool TransAacToWav(const string& aacPath, const string& wavPath);
};

