#include <iostream>
#include <fstream>
#include <Windows.h>
#include <string>
#include "ErrorHeader.h"

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

			IFFileCantBeOpen(ErrorFileDiscord);

		}

		for (int i = 0; i < 1000; i++) {

			if (_ScanPath_Discord.DataIn[i] == ' ') {
				_ScanPath_Discord.DataIn[i] = '\0';
			}

		}
	}
	catch (...) {

		IFError("Something went wrong with program");

	};

	try {

		_ReadingPath_Zapr.open(_resoursesDir + "zapret_path" + _txtAttribute);										     //algorithm of reading addres of program
		
		if (_ReadingPath_Zapr.is_open()) {


			_ReadingPath_Zapr.getline(_ScanPath_Zapr.DataIn, 1000);
			_ReadingPath_Zapr.close();

		}
		else {

			IFFileCantBeOpen(ErrorFileZapret);

		}

		for (int i = 0; i < 1000; i++) {

			if (_ScanPath_Zapr.DataIn[i] == ' ') {
				_ScanPath_Zapr.DataIn[i] = '\0';
			}

		}
	}
	catch (...) {

		IFError("Something went wrong with program");

	};


	WinExec(_ScanPath_Discord.DataIn, 1);																			// execution of programs
	system(_ScanPath_Zapr.DataIn);



	return 0;
}