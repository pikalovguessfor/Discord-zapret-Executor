/*
* Script to automatical execute Zapret and Discord on your computer
* First: script execute Zapret
* Second: script execute Discord
*/
#include <direct.h>
#include <io.h>
#include <tchar.h>
#include <Windows.h>
#include <fstream>
#include <random>

#include "FileAction.h";

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

class Logs {

	/*
	* Log classes to work with logs. It includes a name of files inside log directory
	* Methods to create a directories
	* and generate a txt file names
	*/

private:

	wchar_t nameOfLogDir[5] = L"Logs";

public:
	
	void writeTroubleInLog() {

		struct FileName {
			
			wchar_t Name[4];
			
			bool isFileWithThisNameExist(wchar_t name[4]) {

				ofstream FileChecker;

			}

			void GenerateName() {

				random_device rd;
				mt19937 gen(rd());

				uniform_int_distribution<int> dist(0, 9);

				int ProtoNameINT[3];

				for (int i = 0; i < 3; i++) {

					ProtoNameINT[i] = dist(gen);

				}


				for (int i = 0; i < 3; i++) {

					this->Name[i] = (wchar_t)ProtoNameINT[i];

				}

				return;
			}

		};
		FileName fn;
		fn.GenerateName();

		_mkdir((const char)nameOfLogDir + "/" + (const char)fn.Name + (const char)".txt");
	}

};

wchar_t pathToZaprARR[256] = L"_resourses/zapret_path.txt";
wchar_t pathToDiscARR[256] = L"_resourses/discord_path.txt";

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nShowCmd) {					// point of enter

	Logs logEX;
	logEX.MakeDirectory((wchar_t*)L"Logs");

	wchar_t* TextFromZaprTXT = ReadInfoFromFile(pathToZaprARR);
	wchar_t* TextFromDiscTXT = ReadInfoFromFile(pathToDiscARR);


	_CreateProccesW(TextFromZaprTXT);
	_CreateProccesW(TextFromDiscTXT);


	delete[] TextFromZaprTXT;
	delete[] TextFromDiscTXT;

	return 0;
}