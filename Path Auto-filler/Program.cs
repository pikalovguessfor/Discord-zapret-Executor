﻿using System;
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------");
            Console.WriteLine("1)discord");
            Console.WriteLine("2)general(ALT)");
            Console.WriteLine("3)general(ALT2)");
            Console.WriteLine("4)general(ALT3");
            Console.WriteLine("5)general(ALT4)");
            Console.WriteLine("6)general(ALT5)");
            Console.WriteLine("7)general(ALT6)");
            Console.WriteLine("8)general (FAKE TLS ALT)");
            Console.WriteLine("9)general (FAKE TLS AUTO ALT)");
            Console.WriteLine("10)general (FAKE TLS AUTO ALT2)");
            Console.WriteLine("11)general (FAKE TLS AUTO)");
            Console.WriteLine("12)general (FAKE TLS)");
            Console.WriteLine("13)general (МГТС)");
            Console.WriteLine("14)general (МГТС2)");
            Console.WriteLine("15)general");
            Console.WriteLine("--------------------------");
            Console.ForegroundColor= ConsoleColor.White;
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
                case 7:
                    {
                        ZapretPathNumber = "general (ALT6).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 8:
                    {
                        ZapretPathNumber = "general (FAKE TLS ALT).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 9:
                    {
                        ZapretPathNumber = "general (FAKE TLS AUTO ALT).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 10:
                    {
                        ZapretPathNumber = "general (FAKE TLS AUTO ALT2).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 11:
                    {
                        ZapretPathNumber = "general (FAKE TLS AUTO).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 12:
                    {
                        ZapretPathNumber = "general (FAKE TLS).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 13:
                    {
                        ZapretPathNumber = "general (МГТС).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 14:
                    {
                        ZapretPathNumber = "general (МГТС2).bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                case 15:
                    {
                        ZapretPathNumber = "general.bat";
                        Pathfinder DiscordBat = new Pathfinder(ZapretPathNumber);


                        ClassTXTWork.WriteInfoInFile("./_resourses/zapret_path.txt", DiscordBat.FilePath);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неправильный ввод, допустимы значения 1-15");

                        break;
                    }
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
        }

    }

}