using System;
using System.IO;

namespace Path_Auto_filler
{
    public static class Solution
    {

        public static void Main(string[] args)
        { 


            int SwitchCaseChooseOperator = 0;
            Console.WriteLine("Какую бы версию zapret вы хотели бы использовать?");
            Console.WriteLine("Выберите и напишите номер zapret работающий у вас");
            Console.WriteLine("1)discord, 2)general(ALT), 3)general(ALT2), 4)general(ALT3), 5)general(ALT4), 6)general(ALT5)");
            Console.Write(">");
            SwitchCaseChooseOperator = int.Parse(Console.ReadLine());

            string DiscordPath;
            string ZapretPath;
            string ZapretPathNumber;

            Pathfinder discordPath = new Pathfinder("Discord.exe");
            DiscordPath = discordPath.FilePath;
            ClassTXTWork.WriteInfoInFile("./_resourses/discord_path.txt", DiscordPath);

            switch (SwitchCaseChooseOperator)
            {

                case 1:
                    {
                        ZapretPathNumber = "discord.bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);

                        
                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 2:
                    {
                        ZapretPathNumber = "general (ALT).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 3:
                    {
                        ZapretPathNumber = "general (ALT2).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 4:
                    {
                        ZapretPathNumber = "general (ALT3).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 5:
                    {
                        ZapretPathNumber = "general (ALT4).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 6:
                    {
                        ZapretPathNumber = "general (ALT5).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                default:
                    Console.WriteLine("Неправильный ввод, допустимы значения 1-6");

                    break;
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
        }

    }

}