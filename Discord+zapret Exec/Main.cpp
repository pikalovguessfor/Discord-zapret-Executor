/*
* Script to automatically execute Zapret and Discord on your computer
* First: script execute Zapret
* Second: script execute Discord
*/
#include <io.h>
#include <tchar.h>
#include <Windows.h>
#include <locale>
#include <fstream>

#include "FileAction.h";
#include "logsHandler.h"

using namespace std;

int _CreateProccesW(TCHAR Path[1024]) {


	/*
	* Realisation of independent process execute
	* Working with TCHAR strings aka TCHAR*
	*/

	STARTUPINFO si = { sizeof(si) };
	PROCESS_INFORMATION pi;

	CreateProcess(NULL, Path, NULL, NULL, FALSE, 0, NULL, NULL, &si, &pi);


	return 0;
}

wchar_t pathToZaprARR[256] = L"_resourses/zapret_path.txt";
wchar_t pathToDiscARR[256] = L"_resourses/discord_path.txt";

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nShowCmd) {					// point of enter

	locale::global(locale(""));

	wchar_t* TextFromZaprTXT = ReadInfoFromFile(pathToZaprARR);
	wchar_t* TextFromDiscTXT = ReadInfoFromFile(pathToDiscARR);

	if (pathToZaprARR[0] == (wchar_t)"\0")
	{
		Logs("Путь к файлу zapret.bat пуст");
	}
	else if (pathToDiscARR[0] == (wchar_t)"\0")
	{
		Logs("Путь к файлу Discord.exe пуст")
	}
	
	_CreateProccesW(TextFromZaprTXT);
	_CreateProccesW(TextFromDiscTXT);
	

	delete[] TextFromZaprTXT;
	delete[] TextFromDiscTXT;

	return 0;
}