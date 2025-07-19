#pragma once

#include <fstream>
#include <string>

namespace TF_WORK
{
    void WriteInFile(std::string content, std::string path)
    {
        std::ofstream outfile(path);
        outfile << content;
        outfile.close();
    }
    std::string* ReadFromFile(std::string path)
    {
        std::ifstream ifs(path);
        std::string content;
        std::getline(ifs, content);
        return &content;
    }
}
