#pragma once

#include <fstream>
#include <string>
#include <direct.h>

const std::string ErrorFileDiscord = "discord_path.txt cant be open";
const std::string ErrorFileZapret = "zapret_path.txt cant be open";

int IFError(std::string ErrorText) {

	std::ofstream ErrorLog;

	_mkdir("Logs");

	ErrorLog.open("Logs/ErrorLog.txt");
	if (ErrorLog.is_open()) {

		ErrorLog << ErrorText;
		ErrorLog.close();
	}
	else {
		return 1;
	}


	return 0;
};

int IFFileCantBeOpen(std::string ErrorText) {

	std::ofstream ErrorLog;

	_mkdir("Logs");

	ErrorLog.open("Logs/ErrorLog.txt");
	if (ErrorLog.is_open()) {

		ErrorLog << ErrorText;
		ErrorLog.close();
	}
	else {
		return 1;
	}

};