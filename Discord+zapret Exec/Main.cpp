/*
* Script to automatical execute Zapret and Discord on your computer
* First: script execute Zapret
* Second: script execute Discord
*/
#include <iostream>
#include <direct.h>
#include <tchar.h>
#include <Windows.h>

using namespace std;

int _CreateProcces(TCHAR Path[256]) {


	/*
	* Realisation of independent proccess execute
	* Working with TCHAR strings aka TCHAR*
	*/

	STARTUPINFO si = { sizeof(si) };
	PROCESS_INFORMATION pi;

	CreateProcess(NULL, Path, NULL, NULL, FALSE, 0, NULL, NULL, &si, &pi);


	return 0;
}

const wchar_t pathToZaprARR[256] = L"_resourses/zapret_path.txt";
const wchar_t pathToDiscArr[256] = L"_resorses/zapret_path.txt";

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nShowCmd) {					// point of enter



	return 0;
}