#pragma once

#include <direct.h>
#include <fstream>
#include <string>

using namespace std;

struct logs {

	struct FileName {

		string Name;
		string TxTExtension = ".txt";

		bool isSameFileExist(string name) {

			ifstream FileChecker;

			FileChecker.open(name + TxTExtension);
			if (FileChecker.is_open()) {
				return true;
			}
			else {
				return false;
			}

			return false;
		}

		FileName() {

			bool isNameGenerated = false;
			unsigned int CounterToGenerateName = 0;

			while (!isNameGenerated) {

				CounterToGenerateName++;
				this->Name = to_string();


			}
		}
	};
};