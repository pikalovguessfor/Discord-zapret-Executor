#pragma once

#include <fstream>
#include <direct.h>
#include <string>

class Logs {

private:

	unsigned int CurrentTime = time(NULL);
	std::string CurrentTimeStr = std::to_string(CurrentTime);

	void My_mkdir() {

		_mkdir("Logs");

	}

public:

	Logs(const char* Input) {

		My_mkdir();
		std::ofstream FileLog;

		FileLog.open(this->CurrentTimeStr + ".txt");
		FileLog << Input;
		FileLog.close();

	}

};