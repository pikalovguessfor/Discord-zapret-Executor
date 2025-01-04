#include <iostream>
#include <fstream>
#include <string>
#include <time.h>
#include <direct.h>
#include <Windows.h>

using namespace std;

const string _resoursesDir = "_resourses/";    //constants to work with files
const string _txtAttribute = ".txt";

class Data {								   // this class contains some inf about Paths

private:

	const int _ArrSize = 1000;

public:

	char DataIn[1000];

	Data() {

		for (int i = 0; i < this->_ArrSize; i++) {

			this->DataIn[i] = '0';

		}

	};
};

struct FileLog {

	ofstream FILElog;

	string LogPathDir = "Logs/";
	string LogPath = LogPathDir;

	void CreateFileOfLogAndWriteInside(string ErrorText) {

		FILElog.open(LogPath);
		FILElog << ErrorText;
		FILElog.close();

	}

	void MakeLogDir() {

		_mkdir("Logs");
		
	}

	FileLog(string FileName, string ErrorText) {																						//it`s need to mark file signature (.txt)

		this->LogPath = LogPath + FileName;

		MakeLogDir();
		CreateFileOfLogAndWriteInside(ErrorText);

	}

};

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nShowCmd) {					// point of enter

	Data _ScanPath_Discord;
	Data _ScanPath_Zapr;

	ifstream _ReadingPath_Discord;
	ifstream _ReadingPath_Zapr;

	try {

		_ReadingPath_Discord.open(_resoursesDir + "discord_path" + _txtAttribute);										//algorithm of reading addres of program
		
		if (_ReadingPath_Discord.is_open()) {

			_ReadingPath_Discord >> _ScanPath_Discord.DataIn;
			_ReadingPath_Discord.close();

		}
		else {
			
			FileLog EXDisError("Log.txt", "DiscordCantBeOpen");

		}

		for (int i = 0; i < 1000; i++) {

			if (_ScanPath_Discord.DataIn[i] == ' ') {
				_ScanPath_Discord.DataIn[i] = '\0';
			}

		}
	}
	catch (...) {

		FileLog TryEXDis("Log.txt", "Unknown ERROR discord");

	};

	try {

		_ReadingPath_Zapr.open(_resoursesDir + "zapret_path" + _txtAttribute);										     //algorithm of reading addres of program
		
		if (_ReadingPath_Zapr.is_open()) {


			_ReadingPath_Zapr.getline(_ScanPath_Zapr.DataIn, 1000);
			_ReadingPath_Zapr.close();

		}
		else {

			FileLog LogZaprERROR("Log.txt", "Zapret Cant be open");

		}

		for (int i = 0; i < 1000; i++) {

			if (_ScanPath_Zapr.DataIn[i] == ' ') {
				_ScanPath_Zapr.DataIn[i] = '\0';
			}

		}
	}
	catch (...) {
		
		FileLog TryEXZapr("Log.txt", "Unkown ERROR Zapr");

	};


	WinExec(_ScanPath_Discord.DataIn, 1);																			// execution of programs
	system(_ScanPath_Zapr.DataIn);



	return 0;
}