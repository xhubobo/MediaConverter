/*
** FileName     : CodeConverter.h
** Author       : pigautumn
** Date         : 2016/8/23
** Description  : 编码转换类（提供静态方法）
*/

#ifndef CODE_CONVERTER_H
#define CODE_CONVERTER_H

#include <string>
#include <xstring>

#include <windows.h>
#include <comdef.h>

using std::string;
using std::wstring;

class CodeConverter
{
public:
	static wstring AcsiiToUnicode(const string& acsii_string);		//ACSII转Unicode
	static string AcsiiToUtf8(const string& acsii_string);			//ACSII转UTF8

	static string UnicodeToAcsii(const wstring& unicode_string);	//Unicode转ACSII
	static string UnicodeToUtf8(const wstring& unicode_string);		//Unicode转UTF8

	static string Utf8ToAcsii(const string& utf8_string);			//UTF8转ACSII
	static wstring Utf8ToUnicode(const string& utf8_string);		//UTF8转Unicode

	static string BSTRToString(const BSTR& str);					//BSTR转string
	static BSTR StringToBSTR(const string& str);					//string转BSTR
};

#endif	//CODE_CONVERTER_H