// stdafx.h : 标准系统包含文件的包含文件，
// 或是经常使用但不常更改的
// 特定于项目的包含文件
//

#pragma once

#include "targetver.h"

#define WIN32_LEAN_AND_MEAN             // 从 Windows 头中排除极少使用的资料
// Windows 头文件: 
#include <windows.h>



// TODO:  在此处引用程序需要的其他头文件
#ifndef AUDIOCONVERTER_EXPORTS
#define AUDIOCONVERTER_EXPORTS
#endif // !AUDIOCONVERTER_EXPORTS

#define AUDIOCONVERTER_NAMESPACE_BEGIN namespace AudioConverterNs {
#define AUDIOCONVERTER_NAMESPACE_END }

#ifdef __cplusplus
extern "C"
{
#pragma comment(lib, "avcodec.lib")
#pragma comment(lib, "avformat.lib")
#pragma comment(lib, "avutil.lib")
#pragma comment(lib, "swresample.lib")

}
#endif