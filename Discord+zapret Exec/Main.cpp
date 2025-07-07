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

	char nameOfLogDir[5] = "Logs";

public:
	
	void writeTroubleInLog(const char Trouble[]) {

		struct FileName {
			
			char Name[4];
			
			bool isFileWithThisNameExist(char name[4]) {

				ifstream FileChecker;

				FileChecker.open(string(name)+ ".txt");
				if (FileChecker.is_open()) {
					FileChecker.close();
					return true;
				}
				else {
					FileChecker.close();
					return false;
				}

				return true;
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

					this->Name[i] = (char)ProtoNameINT[i];

				}

				return;
			}

		};

		/*
		* begin of proccedure to write in log.
		*/

		ofstream FileWriter;
		FileName fn;
		fn.GenerateName();

		_mkdir(nameOfLogDir);
		
		FileWriter.open(string(fn.Name) + "txt");
		FileWriter << Trouble;
	}

};

wchar_t pathToZaprARR[256] = L"_resourses/zapret_path.txt";
wchar_t pathToDiscARR[256] = L"_resourses/discord_path.txt";

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nShowCmd) {					// point of enter

	Logs logEX;

	wchar_t* TextFromZaprTXT = ReadInfoFromFile(pathToZaprARR);
	wchar_t* TextFromDiscTXT = ReadInfoFromFile(pathToDiscARR);


	if (!_CreateProccesW(TextFromZaprTXT)) {
		logEX.writeTroubleInLog("Процесс не может быть создан!!! Неправильно записан путь в папке _resourses/zapret_path.txt");
	}
	if (_CreateProccesW(TextFromDiscTXT)) {
		logEX.writeTroubleInLog("Процесс не может быть создан!!! Неправильно записан путь в папке _resourses/discord-path.txt");
	}


	delete[] TextFromZaprTXT;
	delete[] TextFromDiscTXT;

	return 0;
}