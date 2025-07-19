#pragma once

#include <fstream>;

wchar_t* ReadInfoFromFile(wchar_t path[]) {

    wchar_t* text = new wchar_t[1024];

    std::wifstream ifstreamObj;
    ifstreamObj.open(path);

    if (ifstreamObj.is_open()) {
        ifstreamObj.getline(text, 1024);
    }
	
    return text;
}