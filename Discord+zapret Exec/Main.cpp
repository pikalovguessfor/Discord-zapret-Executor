/*
* Script to automatical execute Zapret and Discord on your computer
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
	* Realisation of independent proccess execute
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


	if (!_CreateProccesW(TextFromZaprTXT)) {
		Logs("Ошибка: Текст из файла Zapret_path.txt не может быть прочитан, возможно неверный путь");
	}
	if (_CreateProccesW(TextFromDiscTXT)) {
		Logs("Ошибка: Текст из файла Discord_path.txt не может быть прочитан, возможно неверный путь");
	}


	delete[] TextFromZaprTXT;
	delete[] TextFromDiscTXT;

	return 0;
}