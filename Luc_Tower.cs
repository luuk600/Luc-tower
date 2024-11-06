using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Luc_Tower
{
    internal class Luc_Tower
    {
        enum Levels { Level1, Level2, Level3, Level4, Level5, Level6 };
        static void Main(string[] args)
        {
            int deathcounter = 0;
            int CheckpointLevel = 1;
            Levels CurrentLevel;
            Console.OutputEncoding = Encoding.UTF8;
            Random RNG = new Random();

            #region Level 1 Refs
            //the code that the player puts in
            int PadNum1 = 0;
            int PadNum2 = 0;
            int PadNum3 = 0;

            //The correct code for the padlock
            int PadNum1Sol = 0;
            int PadNum2Sol = 0;
            int PadNum3Sol = 0;

            PadNum1Sol = RNG.Next(0, 10);
            PadNum2Sol = RNG.Next(0, 10);
            PadNum3Sol = RNG.Next(0, 10);

            int Sol1Bed = RNG.Next(0, 10);
            int Sol3Bed = RNG.Next(0, 10);
            #endregion
            //Level1();
            //Level2();
            //Level3();
            //Level4();
            //Level5();
            //Level6();
            GameIntro();


            #region Game Intro

            void GameIntro()
            {
                Console.WriteLine("?????: Wakey wakey...."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("ZzZzZz.."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("?????: Wake up..."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("ZzZz..Hmhhmh..."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("?????: HEY WAKE UP!");
                Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃⠀⠉⠉⠟⡿⣿⣿⣿⣿" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠾⠛⠂⢹⠀⠀⠀⢡⠀⠀⠀⠀⠀⠙⠛⠿⢿");
                Console.WriteLine();

                Console.WriteLine("You wake up terified and see a man looking at you thru the cell window"); Console.ReadKey(); Console.Clear();

                Console.WriteLine("?????: Did you sleep well? I sertainly hope not! WHAHAHA");
                Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃⠀⠉⠉⠟⡿⣿⣿⣿⣿" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠾⠛⠂⢹⠀⠀⠀⢡⠀⠀⠀⠀⠀⠙⠛⠿⢿"); Console.ReadKey(); Console.Clear();

                bool NameRevealed = false;

                if (NameRevealed)
                {
                    Console.WriteLine("Luc The Evil Doctor: I hope you are ready for some experiments... and if not, who cares!!");
                }
                else
                {
                    Console.WriteLine("?????: I hope you are ready for some experiments... and if not, who cares!!");
                }
                Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿" +
                              "\r\n⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃⠀⠉⠉⠟⡿⣿⣿⣿⣿" +
                              "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠾⠛⠂⢹⠀⠀⠀⢡⠀⠀⠀⠀⠀⠙⠛⠿⢿");
                Console.WriteLine();

                AskLuc();
                void AskLuc()
                {
                    Console.WriteLine("1. Where am I?");
                    Console.WriteLine("2. Who Are you??");
                    Console.WriteLine("3. Say nothing");
                    ConsoleKeyInfo LucQeustion = Console.ReadKey(); Console.Clear();

                    switch (LucQeustion.KeyChar)
                    {
                        case '1':
                            if (NameRevealed)
                            {
                                Console.WriteLine("Luc The Evil Doctor: You are in my Tower of Doom! MUHUHAHA");
                            }
                            else
                            {
                                Console.WriteLine("?????:You are in my Tower of Doom! MUHUHAHA");
                            }

                            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃⠀⠉⠉⠟⡿⣿⣿⣿⣿" +
                             "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠾⠛⠂⢹⠀⠀⠀⢡⠀⠀⠀⠀⠀⠙⠛⠿⢿");
                            Console.WriteLine();
                            AskLuc();
                            break;
                        case '2':
                            if (NameRevealed)
                            {
                                Console.WriteLine("Luc The Evil Doctor: Do you have altzheimers?");
                            }
                            else
                            {
                                Console.WriteLine("?????: You can call me Luc, The Evil Doctor!");
                            }

                            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃⠀⠉⠉⠟⡿⣿⣿⣿⣿" +
                             "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠾⠛⠂⢹⠀⠀⠀⢡⠀⠀⠀⠀⠀⠙⠛⠿⢿");
                            Console.WriteLine();
                            NameRevealed = true;

                            AskLuc();
                            break;
                        case '3':
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿" +
                             "\r\n⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃⠀⠉⠉⠟⡿⣿⣿⣿⣿" +
                             "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠾⠛⠂⢹⠀⠀⠀⢡⠀⠀⠀⠀⠀⠙⠛⠿⢿");
                            Console.WriteLine();
                            AskLuc();
                            break;
                    }
                }

                if (NameRevealed)
                {
                    Console.WriteLine("Luc The Evil Doctor: Anyways... See you in a bit, Toodaloo! MWHUHAHAHA");
                }
                else
                {
                    Console.WriteLine("?????: Anyways... See you in a bit, Toodaloo! MWHUHAHAHA");
                }

                Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿" +
                    "\r\n⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃⠀⠉⠉⠟⡿⣿⣿⣿⣿" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢷⠾⠛⠂⢹⠀⠀⠀⢡⠀⠀⠀⠀⠀⠙⠛⠿⢿"); Console.ReadKey(); Console.Clear();

                Console.WriteLine("Oh no... Where have I found myself in?"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Best to find my way out of here, this does not look good..."); Console.ReadKey(); Console.Clear();
                Level1();
            }

            #endregion

            #region Level 1

            //Levels
            void Level1()
            {

                CurrentLevel = Levels.Level1;

                Console.WriteLine("      \\                  #########                  /" +
                              "\r\n       \\                  #######                  /" +
                              "\r\n        \\                                         /" +
                              "\r\n         \\                                       /" +
                              "\r\n          \\                                     /" +
                              "\r\n           \\                                   /" +
                              "\r\n            \\_________________________________/" +
                              "\r\n            |                                 |" +
                              "\r\n            |                                 |" +
                              "\r\n            |                                 |" +
                              "\r\n            |            _________            |" +
                              "\r\n            |           |         |           |" +
                              "\r\n            |           |   ___   |           |" +
                              "\r\n            |           I  |___|  |           |" +
                              "\r\n            |           |        _|           |" +
                              "\r\n            |           |       |#|           |  ;," +
                              "\r\n    H*/   ` |           |         |      _____|    .,`" +
                              "\r\n    */     )|           I         |     \\_____\\     ;'" +
                              "\r\n    /___.,';|           |         |     \\\\     \\     .\"`" +
                              "\r\n    |     ; |___________|_________|______\\\\     \\      ;:" +
                              "\r\n    | ._,'  /                             \\\\     \\      ." +
                              "\r\n    |,'    /                               \\\\     \\" +
                              "\r\n    ||    /                                 \\\\_____\\" +
                              "\r\n    ||   /                                   \\_____|" +
                              "\r\n    ||  /              ___________                \\" +
                              "\r\n    || /              / =====o    |                \\" +
                              "\r\n    ||/              /  |   /-\\   |                 \\" +
                              "\r\n    //              /   |         |                  \\" +
                              "\r\n   //              /    |   ____  |______             \\" +
                              "\r\n  //              /    (O) |    | |      \\             \\" +
                              "\r\n //              /         |____| |  0    \\             \\" +
                              "\r\n//              /          o----  |________\\             \\" +
                              "\r\n/              /                  |     |  |              \\" +
                              "\r\n              /                   |        |               \\" +
                              "\r\n             /                    |        |                " +
                              "\r\n            /                     |        |");
                //Console.Clear(); Death();
                Console.WriteLine("What should I do?");
                Console.WriteLine();
                Console.WriteLine("1. Go to the door");
                Console.WriteLine("2. Inspect bed");
                Console.WriteLine("3. Inspect table");
                Console.WriteLine("4. Inspect sink");

                ConsoleKeyInfo ActivityKey = Console.ReadKey(); Console.Clear();
                switch (ActivityKey.KeyChar)
                {
                    case '1':
                        Door();

                        void Door()
                        {
                            Console.WriteLine("There is a padlock with a 3 letter code.");
                            Console.WriteLine(" ◜⁻⁻⁻⁻⁻◝" +
                                          "\r\n |     | " +
                                          "\r\n⌈⁻⁻⁻⁻⁻⁻⁻⌉" +
                                         $"\r\n|{PadNum1}  {PadNum2}  {PadNum3}|" +
                                          "\r\n⌊_______⌋" +
                                          "\r\n ▲  ▲  ▲" +
                                          "\r\n Y  U  I" +
                                          "\r\n H  J  K" +
                                          "\r\n ▼  ▼  ▼");
                            ///Console.WriteLine("Nmr1: [" + PadNum1Sol + "]Nmr2: [" + PadNum2Sol + "]Nmr3: [" + PadNum3Sol + "]");
                            Console.WriteLine();

                            Console.WriteLine("Press Enter to try the code");
                            Console.WriteLine("Press Backspace to return to the room");

                            ConsoleKeyInfo PadlockKeyCode = Console.ReadKey();
                            switch (PadlockKeyCode.Key)
                            {
                                ///Num1 Padlock
                                case ConsoleKey.Y:
                                    if (PadNum1 == 9)
                                    {
                                        PadNum1 = 0;
                                    }
                                    else
                                    {
                                        PadNum1++;
                                    }
                                    Console.Clear(); Door();
                                    break;
                                case ConsoleKey.H:
                                    if (PadNum1 == 0)
                                    {
                                        PadNum1 = 9;
                                    }
                                    else
                                    {
                                        PadNum1--;
                                    }
                                    Console.Clear(); Door();
                                    break;

                                ///Num2 Padlock
                                case ConsoleKey.U:
                                    if (PadNum2 == 9)
                                    {
                                        PadNum2 = 0;
                                    }
                                    else
                                    {
                                        PadNum2++;
                                    }
                                    Console.Clear(); Door();
                                    break;
                                case ConsoleKey.J:
                                    if (PadNum2 == 0)
                                    {
                                        PadNum2 = 9;
                                    }
                                    else
                                    {
                                        PadNum2--;
                                    }
                                    Console.Clear(); Door();
                                    break;

                                ///Num3 Padlock
                                case ConsoleKey.I:
                                    if (PadNum3 == 9)
                                    {
                                        PadNum3 = 0;
                                    }
                                    else
                                    {
                                        PadNum3++;
                                    }
                                    Console.Clear(); Door();
                                    break;
                                case ConsoleKey.K:
                                    if (PadNum3 == 0)
                                    {
                                        PadNum3 = 9;
                                    }
                                    else
                                    {
                                        PadNum3--;
                                    }
                                    Console.Clear(); Door();
                                    break;

                                ///Confirm Code
                                case ConsoleKey.Enter:
                                    Console.WriteLine();
                                    Console.WriteLine("You try the current code and..."); Thread.Sleep(1000);
                                    if (PadNum1Sol == PadNum1 && PadNum2Sol == PadNum2 && PadNum3Sol == PadNum3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Click! It worked!"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You press the door handle down and you stumble upon a staircase leading down.."); Console.ReadKey(); Console.Clear();
                                        CheckpointLevel++;
                                        Level2();
                                    }
                                    else
                                    {
                                        switch (RNG.Next(1, 5))
                                        {
                                            case 1:
                                                Console.WriteLine("It wont budge");
                                                break;
                                            case 2:
                                                Console.WriteLine("Dang.... nope");
                                                break;
                                            case 3:
                                                Console.WriteLine("That does not seem to be correct");
                                                break;
                                            case 4:
                                                Console.WriteLine("That's not it..");
                                                break;
                                        }

                                        Thread.Sleep(1000); Console.Clear(); Door();
                                    }
                                    break;
                                case ConsoleKey.Backspace:
                                    Console.Clear(); Level1();
                                    break;
                                default:
                                    Console.Clear(); Door();
                                    break;
                            }
                        }
                        break;
                    case '2':
                        Bed();

                        void Bed()
                        {
                            Console.WriteLine("A small bed is infront of you");
                            Console.WriteLine();

                            Console.WriteLine(
                                    "     _   ()" +
                                "\r\n() .'_`'.||" +
                                "\r\n||/.| ||\\ |" +
                                "\r\n| /|| || ||         _   ()" +
                                "\r\n|| || || ||    () .'_`'.||" +
                                "\r\n|| || || ||    ||/.| ||\\ |" +
                                "\r\n|| || |I-'`-._ | /|| || ||" +
                                "\r\n||_I'`_.-||-._`'| || || ||" +
                                "\r\n|._ <'_  ||   `|| || || ||" +
                                "\r\n|| `-._`-'|    || || |I-'|" +
                                "\r\n()     `-._`-._||_I'`_.-||" +
                                "\r\n           `-._` _.-'   ()" +
                                "\r\n               ||" +
                                "\r\n               ()" +
                                "\r\n");
                            Console.WriteLine("Press Space to further inspect bed");
                            Console.WriteLine("Press Backspace to return to the room");

                            ConsoleKeyInfo BedButton = Console.ReadKey();
                            switch (BedButton.Key)
                            {
                                case ConsoleKey.Spacebar:
                                    Console.Clear(); BedInspect();

                                    void BedInspect()
                                    {
                                        Console.WriteLine("What do we have here?");
                                        Console.WriteLine("" +
                                                      "\r\n⌈￣￣￣￣￣￣￣￣￣￣￣￣￣￣|￣￣￣￣￣￣￣￣￣⌉" +
                                                      "\r\n| ⌈￣￣￣⌉                   \\                  |" +
                                                      "\r\n| |      |                    \\                 |" +
                                                      "\r\n| |      |                    |                 |" +
                                                      "\r\n| |      |                    \\                 |" +
                                                      "\r\n| |      |                     \\                |" +
                                                      "\r\n| |      |                      \\               |" +
                                                      "\r\n| |      |                       |              |" +
                                                      "\r\n| ⌊______⌋                       |              |" +
                                                      "\r\n⌊________________________________|______________⌋");
                                        Console.WriteLine("Type the item you want to inspect,");
                                        Console.WriteLine("& exit to leave");
                                        Console.Write(": ");
                                        string InspectName = Console.ReadLine();

                                        switch (InspectName.ToLower())
                                        {
                                            case "pillow":
                                                Console.WriteLine("You found a note with some text on it");
                                                Console.WriteLine(
                                                        "I have keys but no locks," +
                                                    "\r\nI have space but no room," +
                                                    "\r\nYou can enter but can’t go outside." +
                                                    "\r\nWhat am I?" +
                                                    "\r\n" +
                                                   $"\r\n{Sol1Bed} book" +
                                                   $"\r\n{PadNum3Sol} keyboard" +
                                                   $"\r\n{Sol3Bed} house?");

                                                Console.ReadKey(); Console.Clear(); BedInspect();
                                                break;
                                            case "blanket":
                                                Console.WriteLine("Why are there white spots all over it.."); Console.ReadKey(); Console.Clear();
                                                Console.WriteLine("It's probably nothing"); Console.ReadKey(); Console.Clear();
                                                Console.WriteLine("And wy is it sticky?!?!!?"); Console.ReadKey(); Console.Clear(); BedInspect();
                                                break;
                                            case "exit":
                                                Console.Clear(); Level1();
                                                break;
                                            default:
                                                Console.Clear(); BedInspect();
                                                break;
                                        }
                                    }
                                    break;
                                case ConsoleKey.Backspace:
                                    Console.Clear(); Level1();
                                    break;

                                default:
                                    Console.Clear(); Bed();
                                    break;
                            }
                        }

                        break;
                    case '3':
                        Table();

                        void Table()
                        {
                            Console.WriteLine("A table with a cold goopy substance, juck!" +
                   "\r\n                           ⌈⁻⁻⁻⁻⁻⁻⁻⁻⌉" +
                   "\r\n                           |Routine |" +
                   "\r\n        ________           |1 Wash  |" +
                   "\r\n  |\\   / ,( ⁔ ● \\          |2 Eat   |" +
                   "\r\n  ||  / )‿ ● (   \\         |3 Sleep |" +
                  $"\r\n  |⌋  | ⁔ {PadNum2Sol} ⁔ )●( |        ⌊________⌋" +
                   "\r\n  |   | ⁔)‿ ● (⁔) |                  " +
                   "\r\n  |   | ‿(●⁔) ,(  |                  " +
                   "\r\n  |   \\  )⁔ ● ⁔( /                  " +
                   "\r\n  |    \\________/                    " +
                   "\r\n                                     ");

                            Console.WriteLine("Press Backspace to return to the room");

                            ConsoleKeyInfo TableButton = Console.ReadKey();
                            if (TableButton.Key == ConsoleKey.Backspace)
                            {
                                Console.Clear(); Level1();
                            }
                            else Console.Clear(); Table();
                        }
                        break;
                    case '4':
                        Sink();

                        void Sink()
                        {
                            Console.WriteLine("You see a sink that is controlled by a motion censor");
                            Console.WriteLine(
                                    "       |  |" +
                                "\r\n       ⌊__⌋" +
                                "\r\n       |  |" +
                                "\r\n       |  |" +
                                "\r\n ______|  |______" +
                                "\r\n|\\               \\" +
                                "\r\n| \\               \\" +
                                "\r\n|  \\_______________\\" +
                                "\r\n|  |               |");
                            Console.WriteLine("Press space to get water");
                            Console.WriteLine("Press backspace to return to the room");

                            ConsoleKeyInfo TableButton = Console.ReadKey();
                            switch (TableButton.Key)
                            {
                                case ConsoleKey.Spacebar:
                                    Console.Clear(); Drups();
                                    break;
                                case ConsoleKey.Backspace:
                                    Console.Clear(); Level1();
                                    break;
                                default:
                                    Console.Clear(); Sink();
                                    break;
                            }

                            void Drups()
                            {
                                /// Water Animation
                                for (int i = 0; PadNum1Sol > i; i++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(
                                   "     ^     " +
                               "\r\n    / \\    " +
                               "\r\n   (   )   " +
                               "\r\n    ◟‿◞    " +
                               "\r\n           " +
                               "\r\n           " +
                               "\r\n           " +
                               "\r\n           " +
                               "\r\n           ");
                                    Thread.Sleep(100); Console.Clear();

                                    Console.WriteLine(
                                  "           " +
                              "\r\n           " +
                              "\r\n     ^     " +
                              "\r\n    / \\    " +
                              "\r\n   (   )   " +
                              "\r\n    ◟‿◞    " +
                              "\r\n           " +
                              "\r\n           " +
                              "\r\n           ");
                                    Thread.Sleep(100); Console.Clear();

                                    Console.WriteLine(
                              "           " +
                          "\r\n           " +
                          "\r\n           " +
                          "\r\n           " +
                          "\r\n           " +
                          "\r\n     ^     " +
                          "\r\n    / \\    " +
                          "\r\n   (   )   " +
                          "\r\n    ◟‿◞    ");
                                    Thread.Sleep(100); Console.Clear();

                                    Console.WriteLine(
                            "           " +
                        "\r\n           " +
                        "\r\n           " +
                        "\r\n           " +
                        "\r\n           " +
                        "\r\n           " +
                        "\r\n           " +
                        "\r\n     ^     " +
                        "\r\n \\ \\/ \\/ / ");
                                    Thread.Sleep(100); Console.Clear();

                                    Console.WriteLine(
                               "           " +
                           "\r\n           " +
                           "\r\n           " +
                           "\r\n           " +
                           "\r\n           " +
                           "\r\n           " +
                           "\r\n           " +
                           "\r\n           " +
                           "\r\n  _______  ");
                                    Thread.Sleep(100); Console.Clear();
                                }

                                Console.ResetColor();
                                Console.WriteLine("Well the water is great here..."); Console.ReadKey(); Console.Clear(); Sink();
                            }
                        }
                        break;
                    default:
                        Console.Clear(); Level1();
                        break;
                }

            }

            #endregion

            #region Level 2

            void Level2()
            {

                CurrentLevel = Levels.Level2;
                int SeberusAwnserCycle = 0;
                int PlayerAwnserCycle = 0;
                Console.WriteLine("You follow the stairs down to find a door at the bottom"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("But oh no! It is locked!"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("After you press the handle down, it does not open"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Stupid door! Open!"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Open!!!!"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("You punch in frustration the door and hear a metal bar at the top of the door"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("You tild your head upwards and see that the lock was still on the door.."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Sigh..."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("You take the lock off, and open the door"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("                ..       .:.                                               " +
                    "\r\n               :*.      .==.                                               " +
                    "\r\n              .+#      .:*+.                                               " +
                    "\r\n             :#@*#..   :%##:.                                              " +
                    "\r\n        ..-###%%%**#%%@%#@%-.                              ....            " +
                    "\r\n     .:=*%*#*#%%==-%@%%++@#=.                              .--. ..         " +
                    "\r\n    .+*@##*@#**%%@%#@%#@@+*%.                            ..=#-.:*.         " +
                    "\r\n     -%*%@@@##*#**%@@@@@@%%-.                   ......-+**#@@#***.         " +
                    "\r\n     .+*##*#=-+*##%@@@@@@@@-.              ....---#@@@@%*#%#*#@*.          " +
                    "\r\n      -#-.%+-@@%*=%@@@@@@@@%-            ..:+@@@@@@#@@##%#*#@@*.           " +
                    "\r\n ...  .+-.+::*@@%:@@@@@@#%@@@+-..    .::.-@@@@@@@@@-@%*#@*@@@@@@:.         " +
                    "\r\n :=-:-%@@@#+@@%#**%@@@@@*@@@@@*=:.....=#@@@@@@@@@@@@@*@@@##%%##@@=.        " +
                    "\r\n  .:+***..:*@@**#+#@@@@@@#%@@@@@+-==+#@@@@@@@@@@@@@@@+#@@*@@#+*%%#..       " +
                    "\r\n      :%*###%****%@@@@@##@@@@@@@@@*@@@@@@@@@@@@@@@=%@=@@@@#@@@%@%%#=.      " +
                    "\r\n      .**=-==@@@@@@%*%@@@%%@@@@@@*:**@@@@@@@@@@@@%#@@=@@@@%##%#@#%#%+.     " +
                    "\r\n      .-@@@#@#*@@@@@@@@@@+*@@@@@@@%:#+%@@@@@@@@@@#%@@%%@##*@%*#+@*#*@%:.   " +
                    "\r\n      ..*=.-@*-%@@@@@@@@@=*@@@@@@@@%-*@=@@@@@@@@@@@@@@@#*@%#@@%@*%%+%@-.   " +
                    "\r\n       .:. .%:+@@@@@@@@@%+@@@@@@-.@@=+@:%#:=%@@@@@@@@@@%-#+*%*#@**%=.      " +
                    "\r\n           .:*@@@@@@@@@@%+@@@@*+=#%@@@@@@@#-:-%@@@@@-*.-%*=*#+#@-..        " +
                    "\r\n           :+@@@@+@@@@@@@@@@@*=-#@:-@@@@@@@@@-:%@@@++: .:@@*@#*#@#.        " +
                    "\r\n           -+@@@@%+@@@@@@@@@@:+#@@:@+%@@@@@@@#+:==*##-. .+@@@%+.%#.        " +
                    "\r\n           :=*@@@@%*@@@@@@@@*#+@@@-@#%*#@@@@@@@#-*##@=   .:=-.:%=.         " +
                    "\r\n           :=#*@@@@@@@@@@@@=#+@@@@=@#*@+#%@%%*%@%+=%@#.      .*:.          " +
                    "\r\n           .==+#@@@@@@@@@@@-::@@@@%@@%#@@@@@@@=@@@#*@+.       ...          " +
                    "\r\n            .-:-%@@@@@@@@@%#*@@@@@+@%#@@-@@%@@@*@@%%*=.                    " +
                    "\r\n            .:+*=%@@@@@@@@+#:@@@@@=-+%@@@#+%@=@@@%@*%+.                    " +
                    "\r\n             ..--**@@@@@@*-=:@@@@@@=@@@%@:++*+%*###=+:                     " +
                    "\r\n                :=*+%@@*=++-=%@@@@@+@@@*%@%####@#%#@%+.                    " +
                    "\r\n                .-===*:+--:==:@@@@@#@@@@%*%%*#*+*#*=#=.                    " +
                    "\r\n                  .-===-. ..***@@@*@@@@@@%%%@@*@@@@@#%.                    " +
                    "\r\n                  ... ..   ..#**@@@+@@@@@#**@@####%#%#.                    " +
                    "\r\n                             .*:*@@%*@@@@%*=%@@*+++=#=.                    " +
                    "\r\n                             .:*++@@%*%+@@#=#%-**#*%*                      " +
                    "\r\n                              .:=#=*+**#@@**#@%@###@.                      " +
                    "\r\n                               .:-+*+::.+%@#=%=%@%*:.                      " +
                    "\r\n                                .+-*==. ..:##+@#@@+%.                      " +
                    "\r\n                                 .-%=.    .:+@*%#%@*.                      " +
                    "\r\n                                 .+*+.     .-@@@@#%@=                      " +
                    "\r\n                                  ...        .:=-:#@:                      " +
                    "\r\n                                            ..-*#*:.                       " +
                    "\r\n                                            .+..                           ");
                Console.WriteLine("After the door opens, you see a hallway with at the end of it a giant 3 headed dog"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("IT"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("WANT'S"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("TO"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("PLAY"); Console.ReadKey(); Console.Clear();
                RockPaperScissors();
                void RockPaperScissors()
                {
                    SeberusAwnserCycle = RNG.Next(1, 4);
                    Console.WriteLine("Rock Paper Scissors!"); Thread.Sleep(1000);
                    Console.WriteLine("What do you choose?" +
                        "\r\n1. Rock" +
                        "\r\n2. Paper" +
                        "\r\n3. Scissors");
                    Console.Write(": ");
                    ConsoleKeyInfo X = Console.ReadKey();
                    switch (X.KeyChar)
                    {
                        case '1':
                            PlayerAwnserCycle = 1;
                            break;
                        case '2':
                            PlayerAwnserCycle = 2;
                            break;
                        case '3':
                            PlayerAwnserCycle = 3;
                            break;
                        default:
                            Console.Clear(); RockPaperScissors();
                            break;
                    }
                    Console.WriteLine();

                    switch (SeberusAwnserCycle)
                    {
                        case 1:
                            Console.WriteLine("The 3 headed dog choose: Rock");
                            break;
                        case 2:
                            Console.WriteLine("The 3 headed dog choose: Paper");
                            break;
                        case 3:
                            Console.WriteLine("The 3 headed dog choose: Scissors");
                            break;
                    }
                    if (PlayerAwnserCycle == 1 && SeberusAwnserCycle == 3 || PlayerAwnserCycle == 2 && SeberusAwnserCycle == 1 || PlayerAwnserCycle == 3 && SeberusAwnserCycle == 2)
                    {
                        Console.WriteLine("You have won!"); Console.ReadKey(); Console.Clear();
                        Console.WriteLine("The dog makes room for you"); Console.ReadKey(); Console.Clear();
                        Console.WriteLine("You move past the dog and take the next staircase down"); Console.ReadKey(); Console.Clear();
                        CheckpointLevel++;
                        Level3();
                    }
                    else
                    {
                        Console.WriteLine("You have lost!"); Console.ReadKey(); Console.Clear();
                        Console.WriteLine("That is a farewell to you.."); Console.ReadKey(); Console.Clear();
                        Console.WriteLine("You hear the shackels of the dogs chains coming loose"); Console.ReadKey(); Console.Clear();
                        Console.WriteLine("And the enormous beast is charging towards you"); Console.ReadKey(); Console.Clear();
                        Console.WriteLine("CHOMP! CHOMP!"); Console.ReadKey(); Console.Clear();
                        Death();
                    }
                }
            }



            #endregion

            #region Level 3

            void Level3()
            {   //solve the coding problems
                CurrentLevel = Levels.Level3;
                CheckpointLevel = 3;
                bool incapable = false;
                Console.WriteLine("You look around the room the first thing you see is....", 20); Console.ReadKey(); Console.Clear();
                Console.WriteLine("A computer in the corner of your room");
                Console.WriteLine("" +

                    "\r\n+******########################*******-.........:=++*******+:" +
                    "\r\n#####################################%+........=++**********=" +
                    "\r\n###*-:-#=::==+###########++*#########%=......++++***********=" +
                    "\r\n#####=:##*:+############*--=-::-=-=*#%=...:=+*+++***********=" +
                    "\r\n###+:.:+..:=##########################=...=++++*************=" +
                    "\r\n#########***************##############=...=*+++***********##+" +
                    "\r\n########****************##############=...=++++*******######+" +
                    "\r\n#######*****************##############=...=++++++**#########+" +
                    "\r\n##*****++++++++***++++++*+******+++**#=...=*+++++*##########+" +
                    "\r\n##*+====-=---+****+++++++++==+*=--=++*=...=++++++*##########*" +
                    "\r\n#++==------==*+==+=--=+++=---==---=++*=...=++++++*##########*" +
                    "\r\n#++++++++***********+++++++++++++++++*=...=+++****#%%%%#%###*" +
                    "\r\n#%%%%%%%%%%%%%%%%@@%@%%%%%%%%%%%%%%%##=...=******#%%%%%%%%%%#" +
                    "\r\n................:@@@@+....................=****++*%%%%%%%%%%#" +
                    "\r\n................:@@@@*....................+####**#%%%%%%%%%%#" +
                    "\r\n...........-#####%%%%#####+...............+#*##*+#%%%%%%%%%%%" +
                    "\r\n.:-------------------------------:........+#+****#%%%%%%%%%%%" +
                    "\r\n:%%%%%%%%%%%%%%%%@@%%%%%%%%%%%%@%%+*%%%#==*++++*%#%%%%%%%%%%%" +
                    "\r\n+%%%%%%%%%%%%%%%%%%%%%@%%%%%%%%%%@##%%%#-....-*#%*++++++#@%#=" +
            "\r\n+###%%%%%######%%%%%%%%%%%%%%%%%%%*--==:.....---=---:::......"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Would you like to look around or go to the computer?");
                Level3FirstQ();
                void Level3FirstQ()
                {
                    Console.WriteLine(
                    "\r\n+******########################*******-.........:=++*******+:" +
                    "\r\n#####################################%+........=++**********=" +
                    "\r\n###*-:-#=::==+###########++*#########%=......++++***********=" +
                    "\r\n#####=:##*:+############*--=-::-=-=*#%=...:=+*+++***********=" +
                    "\r\n###+:.:+..:=##########################=...=++++*************=" +
                    "\r\n#########***************##############=...=*+++***********##+" +
                    "\r\n########****************##############=...=++++*******######+" +
                    "\r\n#######*****************##############=...=++++++**#########+" +
                    "\r\n##*****++++++++***++++++*+******+++**#=...=*+++++*##########+" +
                    "\r\n##*+====-=---+****+++++++++==+*=--=++*=...=++++++*##########*" +
                    "\r\n#++==------==*+==+=--=+++=---==---=++*=...=++++++*##########*" +
                    "\r\n#++++++++***********+++++++++++++++++*=...=+++****#%%%%#%###*" +
                    "\r\n#%%%%%%%%%%%%%%%%@@%@%%%%%%%%%%%%%%%##=...=******#%%%%%%%%%%#" +
                    "\r\n................:@@@@+....................=****++*%%%%%%%%%%#" +
                    "\r\n................:@@@@*....................+####**#%%%%%%%%%%#" +
                    "\r\n...........-#####%%%%#####+...............+#*##*+#%%%%%%%%%%%" +
                    "\r\n.:-------------------------------:........+#+****#%%%%%%%%%%%" +
                    "\r\n:%%%%%%%%%%%%%%%%@@%%%%%%%%%%%%@%%+*%%%#==*++++*%#%%%%%%%%%%%" +
                    "\r\n+%%%%%%%%%%%%%%%%%%%%%@%%%%%%%%%%@##%%%#-....-*#%*++++++#@%#=" +
                    "\r\n+###%%%%%######%%%%%%%%%%%%%%%%%%%*--==:.....---=---:::......"); Console.ReadKey(); Console.Clear();

                    Console.WriteLine("Press: 1 to look around press: 2 to have a look at the computer");
                    Console.WriteLine("" +
                        "\r\n+******########################*******-.........:=++*******+:" +
                        "\r\n#####################################%+........=++**********=" +
                        "\r\n###*-:-#=::==+###########++*#########%=......++++***********=" +
                        "\r\n#####=:##*:+############*--=-::-=-=*#%=...:=+*+++***********=" +
                        "\r\n###+:.:+..:=##########################=...=++++*************=" +
                        "\r\n#########***************##############=...=*+++***********##+" +
                        "\r\n########****************##############=...=++++*******######+" +
                        "\r\n#######*****************##############=...=++++++**#########+" +
                        "\r\n##*****++++++++***++++++*+******+++**#=...=*+++++*##########+" +
                        "\r\n##*+====-=---+****+++++++++==+*=--=++*=...=++++++*##########*" +
                        "\r\n#++==------==*+==+=--=+++=---==---=++*=...=++++++*##########*" +
                        "\r\n#++++++++***********+++++++++++++++++*=...=+++****#%%%%#%###*" +
                        "\r\n#%%%%%%%%%%%%%%%%@@%@%%%%%%%%%%%%%%%##=...=******#%%%%%%%%%%#" +
                        "\r\n................:@@@@+....................=****++*%%%%%%%%%%#" +
                        "\r\n................:@@@@*....................+####**#%%%%%%%%%%#" +
                        "\r\n...........-#####%%%%#####+...............+#*##*+#%%%%%%%%%%%" +
                        "\r\n.:-------------------------------:........+#+****#%%%%%%%%%%%" +
                        "\r\n:%%%%%%%%%%%%%%%%@@%%%%%%%%%%%%@%%+*%%%#==*++++*%#%%%%%%%%%%%" +
                        "\r\n+%%%%%%%%%%%%%%%%%%%%%@%%%%%%%%%%@##%%%#-....-*#%*++++++#@%#=" +
                        "\r\n+###%%%%%######%%%%%%%%%%%%%%%%%%%*--==:.....---=---:::......");
                    ConsoleKeyInfo lookorpc = Console.ReadKey(); Console.Clear();
                    switch (lookorpc.KeyChar)
                    {
                        case '1':
                            Console.WriteLine("You look around"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("You see a door that is locked with no key hole"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("Do you want to try and break through the door"); Console.ReadKey(); Console.Clear();
                            Level3SecondQ();
                            break;
                        case '2':
                            pcLevel3();
                            break;
                        case 's':
                            Console.WriteLine("good choice"); Console.ReadKey(); Console.Clear();
                            CheckpointLevel++;
                            Level4();
                            break;
                        default:
                            if (incapable == true)
                            {
                                Console.WriteLine("can you please press the right key?");
                                Console.WriteLine("Or do you have parkinson?"); Console.ReadKey(); Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("That is not an option!"); Console.ReadKey(); Console.Clear();
                                incapable = true;
                                Level3FirstQ();
                            }
                            incapable = true;
                            Level3FirstQ();
                            break;
                    }
                }
                void Level3SecondQ()
                {
                    Console.WriteLine("Press: y to try to break the door press: n to go back to the computer");
                    ConsoleKeyInfo breakorpc = Console.ReadKey(); Console.Clear();
                    switch (breakorpc.KeyChar)
                    {
                        case 'y':
                            Console.WriteLine("You try to smash the door open"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("It doesnt work"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("Wait...."); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("You hear a voice over an intercom"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("Fill in the password on the computer!!"); Console.ReadKey(); Console.Clear();
                            Level3SecondQ();
                            break;
                        case 'n':
                            pcLevel3();
                            break;
                        case 'e':
                            Console.WriteLine("good choice"); Console.ReadKey(); Console.Clear();
                            CheckpointLevel++;
                            Level4();
                            break;
                        default:
                            Level3SecondQ();
                            break;
                    }
                }
                void pcLevel3()
                {
                    Console.WriteLine("You are walking towards the computer"); Console.ReadKey(); Console.Clear();
                    Console.WriteLine("Suddenly it turns on....."); Console.ReadKey(); Console.Clear();
                    Console.WriteLine("You look at the screen"); Console.ReadKey(); Console.Clear();
                    Console.WriteLine("It says:");
                    Print("what word comes in IT before the words: code, word or phrase?", 50); Console.WriteLine();

                    string Q1 = Console.ReadLine();
                    if (Q1.ToLower() == "pass")
                    {
                        Print("Correct", 50); Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Print("Incorrect", 50); Console.ReadKey(); Console.Clear();
                        Print("You will start over", 50); Console.ReadKey(); Console.Clear();
                        pcLevel3();
                    }
                    Print("What is the easiest programming language?", 50); Console.WriteLine();
                    string Q2 = Console.ReadLine();
                    if (Q2.ToLower() == "html")
                    {
                        Print("Correct", 50); Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Print("Incorrect", 50); Console.ReadKey(); Console.Clear();
                        Print("You will start over", 50); Console.ReadKey(); Console.Clear();
                        pcLevel3();
                    }
                    Print("What is the first word of this abbreviation HTTPS?", 50); Console.WriteLine();
                    string Q3 = Console.ReadLine();
                    if (Q3.ToLower() == "hypertext")
                    {
                        Print("Correct", 50); Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Print("Incorrect", 50); Console.ReadKey(); Console.Clear();
                        Print("You will start over", 50); Console.ReadKey(); Console.Clear();
                        pcLevel3();
                    }
                    Print("from now on lasers will shoot you if you give the wrong awnsers 2 questions left", 50); Console.ReadKey(); Console.Clear();
                    Print("What does the abbreviation LAN stand for. (3 Words)?", 50); Console.WriteLine();
                    string Q4 = Console.ReadLine();
                    if (Q4.ToLower() == "local area network")
                    {
                        Print("Correct", 50); Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Print("Incorrect", 50); Console.ReadKey(); Console.Clear();
                        Print("You will be shot by lasers in ", 50); Console.Clear();
                        Print("3 2 1", 400); Console.Clear();
                        Death();
                    }
                    Print("What does the abbreviation PDF stand for. (3 Words)?", 50); Console.WriteLine();
                    string Q5 = Console.ReadLine();
                    if (Q5.ToLower() == "portable document format")
                    {
                        Print("Correct", 50); Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Print("Incorrect", 50); Console.ReadKey(); Console.Clear();
                        Print("You will be shot by lasers in ", 50); Console.Clear();
                        Print("3 2 1", 400); Console.Clear();
                        Death();
                    }
                    Print("The door will open soon congrats for knowing all this information you could be a student of mine", 50); Console.ReadKey(); Console.Clear();
                    CheckpointLevel++;
                    Level4();
                }
            }

            #endregion

            #region Level 4

            void Level4()
            {   // speelkamer
                CurrentLevel = Levels.Level4;
                bool kidisdistracted = false;
                bool haveagun = false;
                bool kidisdead = false;
                bool gotkeyfromkid = false;
                Console.WriteLine("You walk through the door"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("up the stairs"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("The first things you see"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Are children's toys?"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("And?????"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("GUNS!!?????"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Suddenly you see kid around 5 years old");
                Console.WriteLine(
                        " O " +
                    "\r\n---|￣" +
                    "\r\n | " +
                    "\r\n/-\\\r\n"); Console.ReadKey(); Console.Clear();
                talkToKid();
                void talkToKid()
                {
                    Console.WriteLine("Do you want to walk over to the kid and talk to him"); Console.ReadKey();
                    Console.WriteLine("Y for Yes and N for No");
                    ConsoleKeyInfo TalkingtoKid = Console.ReadKey(); Console.Clear();
                    switch (TalkingtoKid.KeyChar)
                    {
                        case 'y':
                            Console.WriteLine("You walk towards the kid"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("And just when you are close enough"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("The kid puts a Gun against your leg and shoots you"); Console.ReadKey(); Console.Clear();
                            Console.WriteLine("Then the kid takes a flame thrower and lights you on fire"); Console.ReadKey(); Console.Clear();
                            Death();
                            break;
                        case 'n':
                            Console.WriteLine("You do nothing?"); Console.ReadKey(); Console.Clear();
                            youdonothing();
                            void youdonothing()
                            {

                                Console.WriteLine("you now have a few options to get out of the room."); Console.ReadKey();
                                Console.WriteLine("type 1 to try and pick up a gun");
                                Console.WriteLine("type 2 to try and distract the kid with the toys");
                                Console.WriteLine("type 3 to try to kill the kid");
                                Console.WriteLine("type 4 to throw toys at the kid");
                                Console.WriteLine("type 5 to give the kid a hug");
                                Console.WriteLine("type 6 to try and open the door");
                                Console.WriteLine("type 7 to scream at the kid");
                                Console.WriteLine("type 8 to put on a clown mask and scare the kid");
                                Console.WriteLine("type 9 to look for a key");
                                Console.WriteLine("type 0 to break you own neck");
                                ConsoleKeyInfo doingnothing = Console.ReadKey(); Console.Clear();
                                switch (doingnothing.KeyChar)
                                {
                                    case '1':
                                        if (haveagun == true)
                                        {
                                            Console.WriteLine("You already have a gun you cannot get another one"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        if (kidisdistracted == true)
                                        {
                                            haveagun = true;
                                            Console.WriteLine("beacause the kid is distracted you could grab the gun"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You now have a gun"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        else
                                        {
                                            Console.WriteLine("The kid saw you reaching for the gun and shot you"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }
                                        break;
                                    case '2':

                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("The kid is DEAD you cant distract it anymore"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        if (kidisdistracted == true)
                                        {
                                            Console.WriteLine("The kid is already distracted you cannot distract it twice"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        else
                                        {
                                            Console.WriteLine("You play around with some toys"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("The kid comes and plays with the toys and is now distracted"); Console.ReadKey(); Console.Clear();
                                            kidisdistracted = true;
                                            youdonothing();
                                        }
                                        break;
                                    case '3':
                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("The kid cannot die more?? its already dead"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        if (haveagun == true)
                                        {
                                            Console.WriteLine("You aim towards the kid"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("The kid tries to aim his gun towards you"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("But you already fired"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("And you now have succesfully killed luc's kid"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You see all the blood going around in the room"); Console.ReadKey(); Console.Clear();
                                            kidisdead = true;
                                            youdonothing();
                                        }
                                        else
                                        {
                                            Console.WriteLine("You walk towards the kid"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("Your head has been cut off"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }
                                        break;
                                    case '4':
                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("This does absolutly nothing but is funny"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        else
                                        {
                                            Console.WriteLine("The kid doesn't really like it and shoots"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("A rocket towards your head"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You will not survive"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }

                                        break;
                                    case '5':
                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("you want to hug a dead child that is weird"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You need to have yourself checked out"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("please go to a doctor"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }
                                        else
                                        {
                                            Console.WriteLine("You walk towards the kid"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("He shakes his head"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("lets hug you say"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("When you get close enough the kid puts a grenade in your mouth"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }
                                        break;
                                    case '6':
                                        if (gotkeyfromkid == true)
                                        {
                                            Console.WriteLine("You can go to the next level through the door"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("Congratulations"); Console.ReadKey(); Console.Clear();
                                            CheckpointLevel++;
                                            Level5();
                                        }
                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("You need to get a Key to open an door"); Console.ReadKey(); Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("The door is locked and you don't have the key"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You cannot get though"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("The kid throws shurikens to kill you"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }
                                        break;
                                    case '7':
                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("This does absolutly nothing but is funny"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        else
                                        {
                                            Console.WriteLine("You scream"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("The kid goes wild"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("And presses a red button"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("he fired a nuke towards the tower you will die"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("the nuke goes off and kills you"); Console.ReadKey(); Console.Clear();
                                            Environment.Exit(0);
                                        }
                                        break;
                                    case '8':
                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("The kid is dead"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("Even your ugly face can't change that"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        else
                                        {
                                            Console.WriteLine("You look around for a clown mask"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You find out there is no clown mask"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("Then you saw a mirror and knew that your face would suffice"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You try to scare the kid"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("It Doesn't work"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("If the kid isn't scared of your face you know the kid ain't scared for anything"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("Then the kid takes a chain saw and cuts you into pieces"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }
                                        break;
                                    case '9':
                                        if (gotkeyfromkid == true)
                                        {
                                            Console.WriteLine("You already got the key"); Console.ReadKey(); Console.Clear();
                                            youdonothing();
                                        }
                                        if (kidisdead == true)
                                        {
                                            Console.WriteLine("You search the whole room for the key"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You can't find it anywhere"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("Until you realise"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("Maybe the kid Has the Key"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You walk over to the kid"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You search the kid"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You found the key"); Console.ReadKey(); Console.Clear();
                                            gotkeyfromkid = true;
                                            youdonothing();
                                        }
                                        else
                                        {
                                            Console.WriteLine("You search the whole room for the key"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You can't find it anywhere"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("You make 1 wrong move and the kid stabs you"); Console.ReadKey(); Console.Clear();
                                            Death();
                                        }
                                        break;
                                    case '0':
                                        Console.WriteLine("You're done with ur life and break your own neck"); Console.ReadKey(); Console.Clear();
                                        Death();
                                        break;
                                    default:
                                        youdonothing();
                                        break;
                                }
                            }
                            break;
                        case 'm':
                            CheckpointLevel++;
                            Level5();
                            break;
                        default:
                            talkToKid();
                            break;
                    }
                }

            }

            #endregion

            #region Level 5
            //You are in a classroom and you have to defuse the bomb that is in the middle of it

            void Level5()
            {
                ConsoleKeyInfo key;
                int watchedBomb = 0;
                bool haveScissors = false;
                int rightWire = RNG.Next(1, 4);
                CurrentLevel = Levels.Level5;

                Console.Clear();
                Console.WriteLine("You walk into the room and look around."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("        __________________________\r\n       |         Chalkboard         |\r\n       |----------------------------|\r\n       |                            |\r\n       |                            |\r\n       |    _______      _______     |\r\n       |   |       |    |       |    |\r\n       |   | Table |    | Table |    |\r\n       |   |_______|    |_______|    |\r\n       |    /     \\      /     \\     |\r\n       |   /Chair  \\    /Chair  \\    |\r\n       |  /_______  \\  /_______  \\   |\r\n       |                            |\r\n       |    _______      _______     |\r\n       |   |       |    |       |    |\r\n       |   | Table |    | Table |    |\r\n       |   |_______|    |_______|    |\r\n       |    /     \\      /     \\     |\r\n       |   /Chair  \\    /Chair  \\    |\r\n       |  /_______  \\  /_______  \\   |\r\n       |                            |\r\n       |      Plant       Plant      |\r\n       |      (^^^)       (^^^)      |\r\n       |                            |\r\n       |---------- Lamp -------------|\r\n       |_____________________________|\r\n");
                Console.WriteLine("It looks like a class room, because you see allot of chairs with tables facing towards a wall with a chalkboard."); Console.ReadKey(); Console.Clear();
                Console.WriteLine("You also see a door with a key hole."); Console.WriteLine("      ______\r\n   ,-' ;  ! `-.\r\n  / :  !  :  . \\\r\n |_ ;   __:  ;  |\r\n )| .  :)(.  !  |\r\n |\"    (##)  _  |\r\n |  :  ;`'  (_) (\r\n |  :  :  .     |\r\n )_ !  ,  ;  ;  |\r\n || .  .  :  :  |\r\n |\" .  |  :  .  |\r\n |mt-2_;----.___|");
                Console.ReadKey(); Console.Clear();
                Console.WriteLine("In the middle of the room is also a weird device. It looks like a bomb...");
                Console.WriteLine("" +
                    "    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                  ▒▒                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░      ░░                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░      ░░                                      ░░░░░░░░░░░░░░░░░░░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                      ░░  ░░░░                                          ░░░░░░░░░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░░░░░░░░░░░                                        ░░                                                      ░░░░░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░░░░░                                              ░░          ░░                                              ░░░░░░" +
                    "\r\n░░░░░░░░░░░░░░                                                ▒▒              ░░                                                  " +
                    "\r\n░░░░░░░░                                                    ░░      ░░░░▒▒░░  ▓▓    ▓▓                                            " +
                    "\r\n░░░░░░                                                      ░░    ░░        ▒▒        ▒▒                                          " +
                    "\r\n                                                          ▓▓    ▒▒      ░░    ▒▒▒▒                                                " +
                    "\r\n                                                            ░░░░      ▒▒        ▓▓      ▒▒                                        " +
                    "\r\n                                            ░░░░          ▒▒        ▒▒      ░░░░        ▒▒                                        " +
                    "\r\n                        ▒▒░░░░▒▒▒▒░░▒▒  ▒▒░░░░░░░░      ▒▒      ░░░░    ▒▒░░      ▒▒    ▒▒                                        " +
                    "\r\n                ░░▒▒▒▒░░  ░░▒▒░░    ░░  ▒▒░░░░  ▒▒            ▒▒    ░░░░  ▒▒      ░░    ░░                                        " +
                    "\r\n          ░░  ▒▒░░  ▓▓    ░░░░░░  ░░  ░░▒▒  ░░▒▒░░░░░░▒▒      ▒▒  ▒▒    ░░            ░░                                          " +
                    "\r\n          ░░▒▒▒▒▒▒░░░░  ░░  ░░                    ▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓██▓▓▒▒▒▒▒▒░░                                      " +
                    "\r\n        ▒▒░░▒▒▒▒                                  ▓▓▓▓██████████▓▓▓▓▓▓▓▓▒▒▒▒▓▓██████████▓▓░░                                      " +
                    "\r\n      ▒▒  ░░▒▒        ░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▓▓░░▓▓▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░      " +
                    "\r\n    ░░  ▒▒▒▒    ░░░░░░░░░░░░░░░░░░░░░░▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▒▒▒▒▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░    " +
                    "\r\n      ▓▓▒▒      ░░▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░    " +
                    "\r\n  ░░▒▒▒▒░░      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒▒▓▓████▓▓▓▓▒▒▒▒▒▒▒▒░░░░▒▒░░░░▒▒  ░░▒▒▒▒▒▒▒▒▒▒████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    " +
                    "\r\n░░░░▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒  ░░▒▒░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    " +
                    "\r\n    ░░▒▒        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▒▒▓▓▓▓██▓▓██▓▓▒▒▒▒░░▒▒▒▒  ░░▒▒░░▒▒▒▒░░▒▒▓▓▓▓▓▓▓▓██████████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒    " +
                    "\r\n░░▒▒▒▒░░░░      ▒▒░░▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓██████▓▓▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▓▓████████████████▓▓▓▓▓▓██████▓▓    " +
                    "\r\n            ████░░░░░░░░░░░░░░░░░░░░░░████████░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░████████▓▓░░░░░░░░░░░░░░░░░░░░  " +
                    "\r\n            ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▓▓████▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒░░░░░░░░▒▒▒▒░░▒▒  " +
                    "\r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  " +
                    "\r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██▒▒▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓████▓▓▒▒░░░░██▒▒██▒▒▒▒▓▓▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  " +
                    "\r\n              ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓██▓▓▒▒▒▒▓▓▒▒██▓▓▓▓████▓▓██▓▓██████▓▓▓▓██████▓▓██▓▓▒▒▒▒▓▓██▓▓██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  " +
                    "\r\n                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓▒▒████▓▓████████▓▓▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒  " +
                    "\r\n                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓░░▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓██████▓▓▓▓▒▒▒▒░░░░" +
                    "\r\n        ░░  ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░  " +
                    "\r\n              ░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒    " +
                    "\r\n                ░░░░▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░  " +
                    "\r\n                ░░░░░░░░░░░░░░▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░" +
                    "\r\n                                              ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░                        " +
                    "\r\n");
                Console.ReadKey(); Console.Clear();
                SelectBombName();

                void SelectBombName()
                {
                    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                  ▒▒                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░      ░░                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░      ░░                                      ░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                      ░░  ░░░░                                          ░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░                                        ░░                                                      ░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░                                              ░░          ░░                                              ░░░░░░\r\n░░░░░░░░░░░░░░                                                ▒▒              ░░                                                  \r\n░░░░░░░░                                                    ░░      ░░░░▒▒░░  ▓▓    ▓▓                                            \r\n░░░░░░                                                      ░░    ░░        ▒▒        ▒▒                                          \r\n                                                          ▓▓    ▒▒      ░░    ▒▒▒▒                                                \r\n                                                            ░░░░      ▒▒        ▓▓      ▒▒                                        \r\n                                            ░░░░          ▒▒        ▒▒      ░░░░        ▒▒                                        \r\n                        ▒▒░░░░▒▒▒▒░░▒▒  ▒▒░░░░░░░░      ▒▒      ░░░░    ▒▒░░      ▒▒    ▒▒                                        \r\n                ░░▒▒▒▒░░  ░░▒▒░░    ░░  ▒▒░░░░  ▒▒            ▒▒    ░░░░  ▒▒      ░░    ░░                                        \r\n          ░░  ▒▒░░  ▓▓    ░░░░░░  ░░  ░░▒▒  ░░▒▒░░░░░░▒▒      ▒▒  ▒▒    ░░            ░░                                          \r\n          ░░▒▒▒▒▒▒░░░░  ░░  ░░                    ▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓██▓▓▒▒▒▒▒▒░░                                      \r\n        ▒▒░░▒▒▒▒                                  ▓▓▓▓██████████▓▓▓▓▓▓▓▓▒▒▒▒▓▓██████████▓▓░░                                      \r\n      ▒▒  ░░▒▒        ░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▓▓░░▓▓▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░      \r\n    ░░  ▒▒▒▒    ░░░░░░░░░░░░░░░░░░░░░░▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▒▒▒▒▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░    \r\n      ▓▓▒▒      ░░▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░    \r\n  ░░▒▒▒▒░░      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒▒▓▓████▓▓▓▓▒▒▒▒▒▒▒▒░░░░▒▒░░░░▒▒  ░░▒▒▒▒▒▒▒▒▒▒████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░░░▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒  ░░▒▒░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n    ░░▒▒        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▒▒▓▓▓▓██▓▓██▓▓▒▒▒▒░░▒▒▒▒  ░░▒▒░░▒▒▒▒░░▒▒▓▓▓▓▓▓▓▓██████████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░▒▒▒▒░░░░      ▒▒░░▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓██████▓▓▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▓▓████████████████▓▓▓▓▓▓██████▓▓    \r\n            ████░░░░░░░░░░░░░░░░░░░░░░████████░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░████████▓▓░░░░░░░░░░░░░░░░░░░░  \r\n            ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▓▓████▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒░░░░░░░░▒▒▒▒░░▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██▒▒▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓████▓▓▒▒░░░░██▒▒██▒▒▒▒▓▓▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓██▓▓▒▒▒▒▓▓▒▒██▓▓▓▓████▓▓██▓▓██████▓▓▓▓██████▓▓██▓▓▒▒▒▒▓▓██▓▓██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓▒▒████▓▓████████▓▓▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒  \r\n                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓░░▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓██████▓▓▓▓▒▒▒▒░░░░\r\n        ░░  ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░  \r\n              ░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒    \r\n                ░░░░▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░  \r\n                ░░░░░░░░░░░░░░▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░\r\n                                              ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░                        \r\n");
                    Console.WriteLine("Do you want to give it a name?");
                    Console.WriteLine("Press Y to give it a name or N to just look at the device."); key = Console.ReadKey(); Console.Clear();
                    string bombName = "Bomb";
                    switch (key.KeyChar)
                    {
                        case 'y':
                            Console.Clear();
                            Console.Write("What is the name of the bomb: "); bombName = Console.ReadLine(); Console.Clear();
                            if (bombName.ToLower() == "cidra" || bombName.ToLower() == "osama bin laden") { Console.WriteLine("The bomb explodes"); Console.ReadKey(); Console.Clear(); Death(); }
                            else
                            {
                                Console.WriteLine("The bomb name is now: " + bombName); Console.ReadKey(); Console.Clear(); DefuseBomb();
                            }
                            break;
                        case 'n':
                            Console.Clear();
                            Console.WriteLine("You walk towards the bomb and look at it"); Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                  ▒▒                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░      ░░                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░      ░░                                      ░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                      ░░  ░░░░                                          ░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░                                        ░░                                                      ░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░                                              ░░          ░░                                              ░░░░░░\r\n░░░░░░░░░░░░░░                                                ▒▒              ░░                                                  \r\n░░░░░░░░                                                    ░░      ░░░░▒▒░░  ▓▓    ▓▓                                            \r\n░░░░░░                                                      ░░    ░░        ▒▒        ▒▒                                          \r\n                                                          ▓▓    ▒▒      ░░    ▒▒▒▒                                                \r\n                                                            ░░░░      ▒▒        ▓▓      ▒▒                                        \r\n                                            ░░░░          ▒▒        ▒▒      ░░░░        ▒▒                                        \r\n                        ▒▒░░░░▒▒▒▒░░▒▒  ▒▒░░░░░░░░      ▒▒      ░░░░    ▒▒░░      ▒▒    ▒▒                                        \r\n                ░░▒▒▒▒░░  ░░▒▒░░    ░░  ▒▒░░░░  ▒▒            ▒▒    ░░░░  ▒▒      ░░    ░░                                        \r\n          ░░  ▒▒░░  ▓▓    ░░░░░░  ░░  ░░▒▒  ░░▒▒░░░░░░▒▒      ▒▒  ▒▒    ░░            ░░                                          \r\n          ░░▒▒▒▒▒▒░░░░  ░░  ░░                    ▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓██▓▓▒▒▒▒▒▒░░                                      \r\n        ▒▒░░▒▒▒▒                                  ▓▓▓▓██████████▓▓▓▓▓▓▓▓▒▒▒▒▓▓██████████▓▓░░                                      \r\n      ▒▒  ░░▒▒        ░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▓▓░░▓▓▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░      \r\n    ░░  ▒▒▒▒    ░░░░░░░░░░░░░░░░░░░░░░▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▒▒▒▒▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░    \r\n      ▓▓▒▒      ░░▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░    \r\n  ░░▒▒▒▒░░      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒▒▓▓████▓▓▓▓▒▒▒▒▒▒▒▒░░░░▒▒░░░░▒▒  ░░▒▒▒▒▒▒▒▒▒▒████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░░░▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒  ░░▒▒░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n    ░░▒▒        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▒▒▓▓▓▓██▓▓██▓▓▒▒▒▒░░▒▒▒▒  ░░▒▒░░▒▒▒▒░░▒▒▓▓▓▓▓▓▓▓██████████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░▒▒▒▒░░░░      ▒▒░░▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓██████▓▓▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▓▓████████████████▓▓▓▓▓▓██████▓▓    \r\n            ████░░░░░░░░░░░░░░░░░░░░░░████████░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░████████▓▓░░░░░░░░░░░░░░░░░░░░  \r\n            ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▓▓████▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒░░░░░░░░▒▒▒▒░░▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██▒▒▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓████▓▓▒▒░░░░██▒▒██▒▒▒▒▓▓▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓██▓▓▒▒▒▒▓▓▒▒██▓▓▓▓████▓▓██▓▓██████▓▓▓▓██████▓▓██▓▓▒▒▒▒▓▓██▓▓██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓▒▒████▓▓████████▓▓▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒  \r\n                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓░░▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓██████▓▓▓▓▒▒▒▒░░░░\r\n        ░░  ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░  \r\n              ░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒    \r\n                ░░░░▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░  \r\n                ░░░░░░░░░░░░░░▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░\r\n                                              ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░                        \r\n");
                            Console.ReadKey(); Console.Clear();
                            Console.WriteLine("While you are looking at the bomb you see that it has a timer on it"); Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                  ▒▒                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░      ░░                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░      ░░                                      ░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                      ░░  ░░░░                                          ░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░                                        ░░                                                      ░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░                                              ░░          ░░                                              ░░░░░░\r\n░░░░░░░░░░░░░░                                                ▒▒              ░░                                                  \r\n░░░░░░░░                                                    ░░      ░░░░▒▒░░  ▓▓    ▓▓                                            \r\n░░░░░░                                                      ░░    ░░        ▒▒        ▒▒                                          \r\n                                                          ▓▓    ▒▒      ░░    ▒▒▒▒                                                \r\n                                                            ░░░░      ▒▒        ▓▓      ▒▒                                        \r\n                                            ░░░░          ▒▒        ▒▒      ░░░░        ▒▒                                        \r\n                        ▒▒░░░░▒▒▒▒░░▒▒  ▒▒░░░░░░░░      ▒▒      ░░░░    ▒▒░░      ▒▒    ▒▒                                        \r\n                ░░▒▒▒▒░░  ░░▒▒░░    ░░  ▒▒░░░░  ▒▒            ▒▒    ░░░░  ▒▒      ░░    ░░                                        \r\n          ░░  ▒▒░░  ▓▓    ░░░░░░  ░░  ░░▒▒  ░░▒▒░░░░░░▒▒      ▒▒  ▒▒    ░░            ░░                                          \r\n          ░░▒▒▒▒▒▒░░░░  ░░  ░░                    ▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓██▓▓▒▒▒▒▒▒░░                                      \r\n        ▒▒░░▒▒▒▒                                  ▓▓▓▓██████████▓▓▓▓▓▓▓▓▒▒▒▒▓▓██████████▓▓░░                                      \r\n      ▒▒  ░░▒▒        ░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▓▓░░▓▓▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░      \r\n    ░░  ▒▒▒▒    ░░░░░░░░░░░░░░░░░░░░░░▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▒▒▒▒▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░    \r\n      ▓▓▒▒      ░░▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░    \r\n  ░░▒▒▒▒░░      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒▒▓▓████▓▓▓▓▒▒▒▒▒▒▒▒░░░░▒▒░░░░▒▒  ░░▒▒▒▒▒▒▒▒▒▒████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░░░▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒  ░░▒▒░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n    ░░▒▒        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▒▒▓▓▓▓██▓▓██▓▓▒▒▒▒░░▒▒▒▒  ░░▒▒░░▒▒▒▒░░▒▒▓▓▓▓▓▓▓▓██████████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░▒▒▒▒░░░░      ▒▒░░▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓██████▓▓▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▓▓████████████████▓▓▓▓▓▓██████▓▓    \r\n            ████░░░░░░░░░░░░░░░░░░░░░░████████░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░████████▓▓░░░░░░░░░░░░░░░░░░░░  \r\n            ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▓▓████▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒░░░░░░░░▒▒▒▒░░▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██▒▒▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓████▓▓▒▒░░░░██▒▒██▒▒▒▒▓▓▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓██▓▓▒▒▒▒▓▓▒▒██▓▓▓▓████▓▓██▓▓██████▓▓▓▓██████▓▓██▓▓▒▒▒▒▓▓██▓▓██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓▒▒████▓▓████████▓▓▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒  \r\n                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓░░▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓██████▓▓▓▓▒▒▒▒░░░░\r\n        ░░  ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░  \r\n              ░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒    \r\n                ░░░░▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░  \r\n                ░░░░░░░░░░░░░░▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░\r\n                                              ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░                        \r\n");
                            Console.ReadKey(); Console.Clear();
                            Console.WriteLine("The timer is slowly ticking down so you have to act quick!"); Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                  ▒▒                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░      ░░                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░      ░░                                      ░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                      ░░  ░░░░                                          ░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░                                        ░░                                                      ░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░                                              ░░          ░░                                              ░░░░░░\r\n░░░░░░░░░░░░░░                                                ▒▒              ░░                                                  \r\n░░░░░░░░                                                    ░░      ░░░░▒▒░░  ▓▓    ▓▓                                            \r\n░░░░░░                                                      ░░    ░░        ▒▒        ▒▒                                          \r\n                                                          ▓▓    ▒▒      ░░    ▒▒▒▒                                                \r\n                                                            ░░░░      ▒▒        ▓▓      ▒▒                                        \r\n                                            ░░░░          ▒▒        ▒▒      ░░░░        ▒▒                                        \r\n                        ▒▒░░░░▒▒▒▒░░▒▒  ▒▒░░░░░░░░      ▒▒      ░░░░    ▒▒░░      ▒▒    ▒▒                                        \r\n                ░░▒▒▒▒░░  ░░▒▒░░    ░░  ▒▒░░░░  ▒▒            ▒▒    ░░░░  ▒▒      ░░    ░░                                        \r\n          ░░  ▒▒░░  ▓▓    ░░░░░░  ░░  ░░▒▒  ░░▒▒░░░░░░▒▒      ▒▒  ▒▒    ░░            ░░                                          \r\n          ░░▒▒▒▒▒▒░░░░  ░░  ░░                    ▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓██▓▓▒▒▒▒▒▒░░                                      \r\n        ▒▒░░▒▒▒▒                                  ▓▓▓▓██████████▓▓▓▓▓▓▓▓▒▒▒▒▓▓██████████▓▓░░                                      \r\n      ▒▒  ░░▒▒        ░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▓▓░░▓▓▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░      \r\n    ░░  ▒▒▒▒    ░░░░░░░░░░░░░░░░░░░░░░▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▒▒▒▒▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░    \r\n      ▓▓▒▒      ░░▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░    \r\n  ░░▒▒▒▒░░      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒▒▓▓████▓▓▓▓▒▒▒▒▒▒▒▒░░░░▒▒░░░░▒▒  ░░▒▒▒▒▒▒▒▒▒▒████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░░░▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒  ░░▒▒░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n    ░░▒▒        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▒▒▓▓▓▓██▓▓██▓▓▒▒▒▒░░▒▒▒▒  ░░▒▒░░▒▒▒▒░░▒▒▓▓▓▓▓▓▓▓██████████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░▒▒▒▒░░░░      ▒▒░░▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓██████▓▓▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▓▓████████████████▓▓▓▓▓▓██████▓▓    \r\n            ████░░░░░░░░░░░░░░░░░░░░░░████████░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░████████▓▓░░░░░░░░░░░░░░░░░░░░  \r\n            ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▓▓████▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒░░░░░░░░▒▒▒▒░░▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██▒▒▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓████▓▓▒▒░░░░██▒▒██▒▒▒▒▓▓▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓██▓▓▒▒▒▒▓▓▒▒██▓▓▓▓████▓▓██▓▓██████▓▓▓▓██████▓▓██▓▓▒▒▒▒▓▓██▓▓██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓▒▒████▓▓████████▓▓▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒  \r\n                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓░░▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓██████▓▓▓▓▒▒▒▒░░░░\r\n        ░░  ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░  \r\n              ░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒    \r\n                ░░░░▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░  \r\n                ░░░░░░░░░░░░░░▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░\r\n                                              ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░                        \r\n");
                            Console.ReadKey(); Console.Clear();
                            DefuseBomb();

                            void DefuseBomb()
                            {
                                Console.WriteLine("What is your next move?");
                                Console.WriteLine("Type 1 to look at the bomb");
                                Console.WriteLine("Type 2 to throw the bomb out of the window");
                                Console.WriteLine("Type 3 to hide in the corner of the room");
                                Console.WriteLine("Type 4 to cut one of the wires");
                                Console.WriteLine("Type 5 to look around"); key = Console.ReadKey(); Console.Clear();
                                switch (key.KeyChar)
                                {
                                    case '1':
                                        watchedBomb++;
                                        if (watchedBomb >= 10)
                                        {
                                            Console.WriteLine("The bomb explodes because you ran out of time and you die"); Console.ReadKey(); Console.Clear(); Death();
                                        }
                                        else
                                        {
                                            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                  ▒▒                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░      ░░                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░      ░░                                      ░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                      ░░  ░░░░                                          ░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░                                        ░░                                                      ░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░                                              ░░          ░░                                              ░░░░░░\r\n░░░░░░░░░░░░░░                                                ▒▒              ░░                                                  \r\n░░░░░░░░                                                    ░░      ░░░░▒▒░░  ▓▓    ▓▓                                            \r\n░░░░░░                                                      ░░    ░░        ▒▒        ▒▒                                          \r\n                                                          ▓▓    ▒▒      ░░    ▒▒▒▒                                                \r\n                                                            ░░░░      ▒▒        ▓▓      ▒▒                                        \r\n                                            ░░░░          ▒▒        ▒▒      ░░░░        ▒▒                                        \r\n                        ▒▒░░░░▒▒▒▒░░▒▒  ▒▒░░░░░░░░      ▒▒      ░░░░    ▒▒░░      ▒▒    ▒▒                                        \r\n                ░░▒▒▒▒░░  ░░▒▒░░    ░░  ▒▒░░░░  ▒▒            ▒▒    ░░░░  ▒▒      ░░    ░░                                        \r\n          ░░  ▒▒░░  ▓▓    ░░░░░░  ░░  ░░▒▒  ░░▒▒░░░░░░▒▒      ▒▒  ▒▒    ░░            ░░                                          \r\n          ░░▒▒▒▒▒▒░░░░  ░░  ░░                    ▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓██▓▓▒▒▒▒▒▒░░                                      \r\n        ▒▒░░▒▒▒▒                                  ▓▓▓▓██████████▓▓▓▓▓▓▓▓▒▒▒▒▓▓██████████▓▓░░                                      \r\n      ▒▒  ░░▒▒        ░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▓▓░░▓▓▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░      \r\n    ░░  ▒▒▒▒    ░░░░░░░░░░░░░░░░░░░░░░▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▒▒▒▒▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░    \r\n      ▓▓▒▒      ░░▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░    \r\n  ░░▒▒▒▒░░      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒▒▓▓████▓▓▓▓▒▒▒▒▒▒▒▒░░░░▒▒░░░░▒▒  ░░▒▒▒▒▒▒▒▒▒▒████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░░░▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒  ░░▒▒░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n    ░░▒▒        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▒▒▓▓▓▓██▓▓██▓▓▒▒▒▒░░▒▒▒▒  ░░▒▒░░▒▒▒▒░░▒▒▓▓▓▓▓▓▓▓██████████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒    \r\n░░▒▒▒▒░░░░      ▒▒░░▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▓▓████████▓▓▓▓▒▒▓▓▓▓██████▓▓▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒▒▒░░░░▒▒▓▓▓▓▓▓████████████████▓▓▓▓▓▓██████▓▓    \r\n            ████░░░░░░░░░░░░░░░░░░░░░░████████░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░████████▓▓░░░░░░░░░░░░░░░░░░░░  \r\n            ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▓▓████▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒░░░░░░░░▒▒▒▒░░▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██▒▒▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓████▓▓▒▒░░░░██▒▒██▒▒▒▒▓▓▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n              ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓██▓▓▒▒▒▒▓▓▒▒██▓▓▓▓████▓▓██▓▓██████▓▓▓▓██████▓▓██▓▓▒▒▒▒▓▓██▓▓██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \r\n                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓▒▒████▓▓████████▓▓▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒  \r\n                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████▓▓▓▓░░▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓██████▓▓▓▓▒▒▒▒░░░░\r\n        ░░  ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░  \r\n              ░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒    \r\n                ░░░░▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░  \r\n                ░░░░░░░░░░░░░░▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░\r\n                                              ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░                        \r\n");
                                            Console.ReadKey(); Console.Clear(); DefuseBomb();
                                        }
                                        break;
                                    case '2':
                                        Console.WriteLine("You try to pickup to bomb, but its stuck to the ground"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("While trying to pickup the bomb you accidentally break a wire"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("The bomb explodes and you die"); Console.ReadKey(); Console.Clear(); Death();
                                        break;
                                    case '3':
                                        Console.WriteLine("You run to a corner of the room and sit in it"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("The bomb explodes and you die"); Console.ReadKey(); Console.Clear(); Death();
                                        break;
                                    case '4':
                                        if (haveScissors)
                                        {
                                            Console.WriteLine("You see 3 wires that you can cut with the scissors"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("A red wire, A blue wire and a green wire"); Console.ReadKey(); Console.Clear();
                                            CutTheWire();
                                            void CutTheWire()
                                            {
                                                Console.WriteLine("Which wire do you want to cut?");
                                                Console.WriteLine("Type 1 to cut the red wire");
                                                Console.WriteLine("Type 2 to cut the blue wire");
                                                Console.WriteLine("Type 3 to cut the green wire"); key = Console.ReadKey(); Console.Clear();
                                                switch (key.KeyChar)
                                                {
                                                    case '1':
                                                        if (rightWire == 1) { }
                                                        else { Console.WriteLine("That was not the right wire"); }
                                                        if (rightWire == 1) { WasRightWire(); }
                                                        else { Console.WriteLine("That was not the right wire. The bomb explodes and you die"); Console.ReadKey(); Console.Clear(); Death(); }
                                                        break;
                                                    case '2':
                                                        if (rightWire == 2) { WasRightWire(); }
                                                        else { Console.WriteLine("That was not the right wire. The bomb explodes and you die"); Console.ReadKey(); Console.Clear(); Death(); }
                                                        break;
                                                    case '3':
                                                        if (rightWire == 3) { WasRightWire(); }
                                                        else { Console.WriteLine("That was not the right wire. The bomb explodes and you die"); Console.ReadKey(); Console.Clear(); Death(); }
                                                        break;
                                                    default:
                                                        Console.Clear(); CutTheWire();
                                                        break;
                                                }

                                                void WasRightWire()
                                                {
                                                    Console.WriteLine("You have cut the right wire the bomb is now turned off"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You open the bomb to look inside it"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You see a key and pick it up"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You walk with the key to the door"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You open the door and walk down the stairs that is behind the door"); Console.ReadKey(); Console.Clear();
                                                    CheckpointLevel++;
                                                    Level6();
                                                }
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("You dont have anything to cut the wire with"); Console.ReadKey(); Console.Clear(); DefuseBomb();
                                        }
                                        break;
                                    case '5':
                                        Console.WriteLine("You look around in the room"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You see some plants, a lamp, some chairs with tables and chalkboard"); Console.ReadKey(); Console.Clear();
                                        LookingAroundRoom5();
                                        void LookingAroundRoom5()
                                        {
                                            Console.WriteLine("        __________________________\r\n       |         Chalkboard         |\r\n       |----------------------------|\r\n       |                            |\r\n       |                            |\r\n       |    _______      _______     |\r\n       |   |       |    |       |    |\r\n       |   | Table |    | Table |    |\r\n       |   |_______|    |_______|    |\r\n       |    /     \\      /     \\     |\r\n       |   /Chair  \\    /Chair  \\    |\r\n       |  /_______  \\  /_______  \\   |\r\n       |                            |\r\n       |    _______      _______     |\r\n       |   |       |    |       |    |\r\n       |   | Table |    | Table |    |\r\n       |   |_______|    |_______|    |\r\n       |    /     \\      /     \\     |\r\n       |   /Chair  \\    /Chair  \\    |\r\n       |  /_______  \\  /_______  \\   |\r\n       |                            |\r\n       |      Plant       Plant      |\r\n       |      (^^^)       (^^^)      |\r\n       |                            |\r\n       |---------- Lamp -------------|\r\n       |_____________________________|\r\n");
                                            Console.WriteLine("Where do you want to look?");
                                            Console.WriteLine("Type 1 to look at the plants");
                                            Console.WriteLine("Type 2 to look at the lamp");
                                            Console.WriteLine("Type 3 to look at the chairs and tables");
                                            Console.WriteLine("Type 4 to look at the chalkboard");
                                            Console.WriteLine("Type 5 to go back to the bomb"); key = Console.ReadKey(); Console.Clear();
                                            switch (key.KeyChar)
                                            {
                                                case '1':
                                                    Console.WriteLine("You search between the plants and find a pair of scissors!"); Console.ReadKey(); Console.Clear(); haveScissors = true; LookingAroundRoom5();
                                                    break;
                                                case '2':
                                                    Console.WriteLine("You look at the lamp"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("Out of nowhere the lamp suddenly starts to shine very brightly"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("Because of the fell light you are now blind"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("Now you are blind you walk around really confused"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You walk against the bomb and it explodes. You died"); Console.ReadKey(); Console.Clear(); Death();
                                                    break;
                                                case '3':
                                                    Console.WriteLine("You look at the tables and chairs"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You tell the total of chairs and tables"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("There are 15 chairs and 17 tables in the room"); Console.ReadKey(); Console.Clear(); LookingAroundRoom5();
                                                    break;
                                                case '4':
                                                    Console.WriteLine("On the chalkboard is written something it says:");
                                                    Console.WriteLine();
                                                    if (rightWire == 1)
                                                    {
                                                        Console.WriteLine("A sunset bleeds into the sky,");
                                                        Console.WriteLine("Like fire dancing on the horizon's edge,");
                                                        Console.WriteLine("Warmth burns in every falling leaf."); Console.ReadKey(); Console.Clear(); LookingAroundRoom5();
                                                    }
                                                    else if (rightWire == 2)
                                                    {
                                                        Console.WriteLine("The ocean whispers secrets deep,");
                                                        Console.WriteLine("A cool breath beneath the endless sky,");
                                                        Console.WriteLine("Calm ripples where the heavens sleep."); Console.ReadKey(); Console.Clear(); LookingAroundRoom5();
                                                    }
                                                    else if (rightWire == 3)
                                                    {
                                                        Console.WriteLine("A forest hums with life untamed,");
                                                        Console.WriteLine("Earth’s fingers stretch toward sunlit heights,");
                                                        Console.WriteLine("In every leaf, a world reclaimed."); Console.ReadKey(); Console.Clear(); LookingAroundRoom5();
                                                    }
                                                    break;
                                                case '5':
                                                    Console.WriteLine("You go back to the bomb"); Console.ReadKey(); Console.Clear(); DefuseBomb();
                                                    break;
                                                default:
                                                    Console.Clear(); LookingAroundRoom5();
                                                    break;
                                            }
                                        }
                                        break;
                                    case '6':
                                        Console.WriteLine("There are only 5 options not 6"); Console.ReadKey(); Console.Clear(); DefuseBomb();
                                        break;
                                    default:
                                        Console.Clear(); DefuseBomb();
                                        break;
                                }
                            }

                            break;
                        default:
                            Console.Clear(); SelectBombName();
                            break;
                    }

                }
            }

            #endregion

            #region Level 6
            // There is a animal resevour where you have to collect certain things so you can go outside and after that you have completed the game

            void Level6()
            {
                CheckpointLevel = 6;
                ConsoleKeyInfo key;
                bool hasKeyFloor6 = false; // Correct key
                bool hasWrongKeyFloor6 = false; // Wrong key
                int timesPutInCode = 0;
                int cowNumber = RNG.Next(10, 100);
                int dogNumber = RNG.Next(10, 100);
                int parrotNumber = RNG.Next(10, 100);
                string finalCode = cowNumber.ToString() + dogNumber.ToString() + parrotNumber.ToString(); // This is the code you need for the safe where you get the key to the final door
                CurrentLevel = Levels.Level6;

                Console.WriteLine("You walk down the stairs and come in a new room"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("Before you even enter the room you smell the awful smell of animal shit"); Console.ReadKey(); Console.Clear(); // There is alot of animal shit in the room
                Console.WriteLine("After that you step into the room"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("You look around the room and see all sorts of different animals"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("There are 3 cows, a cat, Barry, 4 parrots, 2 dogs and a platypus"); Console.ReadKey(); Console.Clear(); // All animals in the room
                Console.WriteLine("The animals are in separate cages of each other"); Console.ReadKey(); Console.Clear();
                Console.WriteLine("You also see a table and a door"); Console.ReadKey(); Console.Clear(); // Other things in the room
                Level6Area();
                void Level6Area()
                {
                    Console.WriteLine("What do you want to do now?");
                    Console.WriteLine("Type 1 to look at the door"); // The final and last door of the game you need a key for it
                    Console.WriteLine("Type 2 to look at the table"); // Go to the table where you can get a clue and the key
                    Console.WriteLine("Type 3 to look at the animals"); key = Console.ReadKey(); Console.Clear(); // Look at all the animals. Some have clues other not
                    switch (key.KeyChar)
                    {
                        case '1':
                            if (hasKeyFloor6)
                            {
                                // The end of the game message
                                Console.WriteLine("You put the key in the door and the door opens"); Console.ReadKey(); Console.Clear();
                                Console.WriteLine("You can finaly see the outside again!"); Console.ReadKey(); Console.Clear();
                                Console.WriteLine("You walk outside, but then..."); Console.ReadKey(); Console.Clear();
                                Console.WriteLine(); Console.ReadKey(); Console.Clear();
                                Console.WriteLine("The end, for now...");
                                Console.WriteLine();
                                Console.WriteLine("Thank you for playing the game");
                                Console.WriteLine("Made by Lucas Lemmens, Nick van Eck and Sem Delisse"); Console.ReadKey(); Environment.Exit(0);
                            }
                            else if (hasWrongKeyFloor6)
                            {
                                Console.WriteLine("You put the key in the door"); Console.ReadKey(); Console.Clear();
                                Console.WriteLine("But it doesn't fit"); Console.ReadKey(); Console.Clear();
                                Console.WriteLine("So you have put your hand in cows shit for nothing"); Console.ReadKey(); Console.Clear(); Level6Area();
                            }
                            else { Console.WriteLine("You look at the door but you cant open it because its locked"); Console.ReadKey(); Console.Clear(); Level6Area(); }
                            break;
                        case '2':
                            Console.WriteLine("On the table are the following items:");
                            Console.WriteLine("A candle");
                            Console.WriteLine("A piece of paper");
                            Console.WriteLine("3 silver coins");
                            Console.WriteLine("A little safe"); Console.ReadKey(); Console.Clear();
                            TableLevel6();

                            void TableLevel6()
                            {
                                Console.WriteLine("What do you want to do next?");
                                Console.WriteLine("Type 1 to pickup the candle"); // You get a hint
                                Console.WriteLine("Type 2 to pickup the piece of paper"); // Death
                                Console.WriteLine("Type 3 to pickup the 3 silver coins"); // Nothing
                                Console.WriteLine("Type 4 to look at the safe"); // You have to put a 5 digit code in to get a key for the door to the outside
                                Console.WriteLine("Type 5 to go back to the middle of the room"); key = Console.ReadKey(); Console.Clear();
                                switch (key.KeyChar)
                                {
                                    case '1':
                                        Console.WriteLine("You pickup the candle and look at it");
                                        Console.WriteLine("There is something written on the bottom of it!");
                                        Console.WriteLine("It says:");
                                        Console.WriteLine("3C, 2D, 4P are all..."); Console.ReadKey(); Console.Clear(); TableLevel6(); // 3 Cows, 2 dogs and 4 parrots. You have to something with all 3 animals in this order.
                                        break;
                                    case '2': // You die
                                        Console.WriteLine("You pickup the paper but cut yourself"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("Now you have a papercut"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("Because of the papercut you are bleeding allot"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You panic and run around the room not knowing what to do"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("And then you hit your head to a cage and die"); Console.ReadKey(); Console.Clear(); Death();
                                        break;
                                    case '3': // Nothing really happens
                                        Console.WriteLine("You try to grap the first coin"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("But its glued to the table"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You try the other 2 but also they are glued to the table"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("So you give up"); Console.ReadKey(); Console.Clear(); TableLevel6();
                                        break;
                                    case '4': // A safe where you have to put a 5 digit code in to get a key
                                        SafeLevel6();
                                        void SafeLevel6()
                                        {
                                            Console.WriteLine("You go to the save and take a look at it"); Console.ReadKey(); Console.Clear();
                                            Console.WriteLine("It looks like you need a 5 digit code to unlock it"); Console.ReadKey(); Console.Clear();
                                            SafeWhatToDo();

                                            void SafeWhatToDo()
                                            {
                                                Console.WriteLine("What do you want to do now?");
                                                Console.WriteLine("Type 1 to enter in a code");
                                                Console.WriteLine("Type 2 to pickup the safe and throw it on the ground");
                                                Console.WriteLine("Type 3 to go back to the other things on the table"); key = Console.ReadKey(); Console.Clear();
                                                switch (key.KeyChar)
                                                {
                                                    case '1':
                                                        Console.WriteLine("You go up to the safe and put in the code"); Console.ReadKey(); Console.Clear();
                                                        Console.Write("Type in code: "); string codeLevel6 = Console.ReadLine(); Console.Clear();
                                                        if (timesPutInCode >= 5)
                                                        {
                                                            Console.WriteLine("You have put in the wrong code to many times"); Console.ReadLine(); Console.Clear();
                                                            Console.WriteLine("Because of that you fail"); Console.ReadLine(); Console.Clear();
                                                            Console.WriteLine("You're so devastated that you die"); Console.ReadLine(); Console.Clear(); Death();
                                                        }
                                                        else
                                                        {
                                                            if (codeLevel6 == finalCode)
                                                            {
                                                                hasKeyFloor6 = true;
                                                                Console.WriteLine("Code correct"); Console.ReadLine(); Console.Clear();
                                                                Console.WriteLine("The safe is now open"); Console.ReadLine(); Console.Clear();
                                                                Console.WriteLine("You look inside and see a key"); Console.ReadLine(); Console.Clear();
                                                                Console.WriteLine("You pickup the key and go back to the middle of the room"); Console.ReadLine(); Console.Clear(); Level6Area();
                                                            }
                                                            else
                                                            {
                                                                timesPutInCode++;
                                                                Console.WriteLine("WRONG CODE"); Console.ReadLine(); Console.Clear();
                                                                Console.WriteLine("Try again later..."); Console.ReadLine(); Console.Clear(); SafeLevel6();
                                                            }
                                                        }
                                                        break;
                                                    case '2':
                                                        Console.WriteLine("You pickup the safe"); Console.ReadKey(); Console.Clear();
                                                        Console.WriteLine("Then you smash it to the ground as hard as you can"); Console.ReadKey(); Console.Clear();
                                                        Console.WriteLine("The safe hits the ground!"); Console.ReadKey(); Console.Clear();
                                                        Console.WriteLine("But its still completly intact"); Console.ReadKey(); Console.Clear();
                                                        Console.WriteLine("You pickup the safe and put it back on the table"); Console.ReadKey(); Console.Clear(); SafeLevel6();
                                                        break;
                                                    case '3':
                                                        TableLevel6();
                                                        break;
                                                    default:
                                                        SafeWhatToDo();
                                                        break;
                                                }
                                            }
                                        }

                                        break;
                                    case '5':
                                        Level6Area();
                                        break;
                                    default:
                                        TableLevel6();
                                        break;
                                }
                            }
                            break;
                        case '3':
                            AnimalsLevel6();
                            void AnimalsLevel6() // There are 3 cows, 1 cat, Barry, 4 parrots, 2 dogs and 1 platypus
                            {
                                Console.Clear();
                                Console.WriteLine("Which animal do you want to see?");
                                Console.WriteLine("Type 1 to look at the cows"); // The first part of the code you need is here
                                Console.WriteLine("Type 2 to look at the cat"); // Nothing really important for the game here
                                Console.WriteLine("Type 3 to look at Barry"); // BARRY!!!
                                Console.WriteLine("Type 4 to look at the parrots"); // The third an final part of the code you need is here
                                Console.WriteLine("Type 5 to look at the dogs"); // The second part of the code you need is here
                                Console.WriteLine("Type 6 to look at the platypus"); // Where is Perry the platypus?
                                Console.WriteLine("Type 7 to go back to the middle of the room"); key = Console.ReadKey(); Console.Clear();
                                switch (key.KeyChar)
                                {

                                    case '1': // Cows
                                        Console.WriteLine("You come into the cage of the cows and look around"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You see that the cows are eating there food so you go to them to look."); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("When you are there you see a key laying on the ground"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("But one of the cows drops a big piece of shit that falls right on the key"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You look around and also see a chair and a empty bucket"); Console.ReadKey(); Console.Clear();
                                        CowsCage();
                                        void CowsCage()
                                        {
                                            Console.WriteLine("What do you want to do?");
                                            Console.WriteLine("Type 1 to stick your hand in the cows shit and take the key"); // You will get a fake key
                                            Console.WriteLine("Type 2 to sit on the chair"); // Nothing happens
                                            Console.WriteLine("Type 3 to kick the bucket"); // You will get a part of the code
                                            Console.WriteLine("Type 4 to go back"); key = Console.ReadKey(); Console.Clear();
                                            switch (key.KeyChar)
                                            {
                                                case '1':
                                                    Console.WriteLine("You put your hand in the shit");
                                                    Console.WriteLine("It feels...");
                                                    Console.WriteLine("Warm...");
                                                    Console.WriteLine("After some time you finally feel the key");
                                                    Console.WriteLine("You take the key out of the shit");
                                                    Console.WriteLine("You now have a key!");
                                                    hasWrongKeyFloor6 = true;
                                                    break;
                                                case '2':
                                                    Console.WriteLine("You go to the chair and sit on it"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You take a little rest after what you have done this day"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("After some time you stand up again"); Console.ReadKey(); Console.Clear(); CowsCage();
                                                    break;
                                                case '3':
                                                    Console.WriteLine("You go to the bucket and kick it as hard as you can to let your aggression out"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("The bucket flies through the cage and lands by your feet again"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You look at the bucket and see on the bottom a number..."); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("The number is: " + cowNumber); Console.ReadKey(); Console.Clear(); CowsCage();
                                                    break;
                                                case '4':
                                                    AnimalsLevel6();
                                                    break;
                                                default:
                                                    CowsCage();
                                                    break;
                                            }
                                        }
                                        break;

                                    case '2': // Cats
                                        Console.WriteLine("You walk up to the cats cage"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You try to open the door but the door is closed"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You look into the cage and see the cats just chilling"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You decide to just leave them alone and walk back"); Console.ReadKey(); Console.Clear(); AnimalsLevel6();
                                        break;

                                    case '3': // Barry
                                        Console.WriteLine("BARRYYYY!!!!");
                                        Console.WriteLine("For everyone that doesn't know Barry");
                                        Console.WriteLine("Barry is a beautiful animal drawn by our teacher Mark!");
                                        Console.WriteLine("Anyway");
                                        Console.WriteLine("For the rest there is nothing here");
                                        Console.WriteLine("Good Luck!"); Console.ReadKey(); Console.Clear(); AnimalsLevel6();
                                        break;

                                    case '4': // Parrots
                                        Console.WriteLine("You walk into the parrots cage"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("While you walk into the cage one of the parrots screams"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("Parrot 1: INTRUDER, INTRUDER, INTRUDER"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("You still step into the cage and the then the second one says something");
                                        Console.WriteLine("Parrot 2: Did you know that the cigarette lighter was invented before the match."); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("After that the third parrot says:");
                                        Console.WriteLine(parrotNumber); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("After that the last parrot says:");
                                        Console.WriteLine("Can you please leave?"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("So after that you leave the parrots cage"); Console.ReadKey(); Console.Clear(); AnimalsLevel6();
                                        break;

                                    case '5': // Dogs
                                        Console.WriteLine("You walk in the dog cage"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("The dogs are sleeping at the moment"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("In the room you see some left over dog food"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("Some bones"); Console.ReadKey(); Console.Clear();
                                        Console.WriteLine("There are also dog toys"); Console.ReadKey(); Console.Clear();
                                        DogCage();

                                        void DogCage()
                                        {
                                            Console.WriteLine("You are in the middle of the dog cage");
                                            Console.WriteLine("What do you want to do now");
                                            Console.WriteLine("Type 1 to look at the dogs"); // You will find a part of the code you need
                                            Console.WriteLine("Type 2 to look at the dog food"); // You will die
                                            Console.WriteLine("Type 3 to look at the bones"); // There is a fake clue here
                                            Console.WriteLine("Type 4 to look at the dog toys"); // You will die
                                            Console.WriteLine("Type 5 to go back to the middle of the room"); key = Console.ReadKey(); Console.Clear();
                                            switch (key.KeyChar)
                                            {
                                                case '1':
                                                    Console.WriteLine("You look at the dogs and see a number in the dog collar");
                                                    Console.WriteLine("The number is: " + dogNumber); Console.ReadKey(); Console.Clear(); DogCage();
                                                    break;
                                                case '2':
                                                    Console.WriteLine("You walk to the dog food"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You suddenly get the urges to eat the dog food"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("So you take some of the food and put it in your mouth"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You are feeling a little bit unwell"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You die because of the dog food"); Console.ReadKey(); Console.Clear(); Death();
                                                    break;
                                                case '3':
                                                    Console.WriteLine("You walk to the bones"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You count how many bones there are and you come to the conclusion"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("That there are 5 bones lying on the ground"); Console.ReadKey(); Console.Clear(); DogCage();
                                                    break;
                                                case '4':
                                                    Console.WriteLine("You walk to the dog toys and pick one up"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("You give it a little squeeze and it makes an loud annoying sound"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("The dogs wake up and are looking angry"); Console.ReadKey(); Console.Clear();
                                                    Console.WriteLine("The dogs attack you because of the sound"); Console.ReadKey(); Console.Clear(); Death();
                                                    break;
                                                case '5':
                                                    Level6Area();
                                                    break;
                                                default:
                                                    DogCage();
                                                    break;
                                            }
                                        }
                                        break;

                                    case '6': // Platypus
                                        Console.WriteLine("Hey, where is Perry?"); Console.ReadKey(); Console.Clear(); AnimalsLevel6();
                                        break;

                                    case '7': // Main area
                                        Level6Area();
                                        break;
                                    default:
                                        AnimalsLevel6();
                                        break;
                                }
                            }
                            break;
                        default:
                            Level6Area();
                            break;

                    }
                }
            }

            #endregion

            #region Death

            void Death()
            {


                Console.WriteLine("███████████████████████████" +
                              "\r\n███████▀▀▀░░░░░░░▀▀▀███████" +
                              "\r\n████▀░░░░░░░░░░░░░░░░░▀████" +
                              "\r\n███│░░░░░░░░░░░░░░░░░░░│███" +
                              "\r\n██▌│░░░░░░░░░░░░░░░░░░░│▐██" +
                              "\r\n██░└┐░░░░░░░░░░░░░░░░░┌┘░██" +
                              "\r\n██░░└┐░░░░░░░░░░░░░░░┌┘░░██" +
                              "\r\n██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██" +
                              "\r\n██▌░│██████▌░░░▐██████│░▐██" +
                              "\r\n███░│▐███▀▀░░▄░░▀▀███▌│░███" +
                              "\r\n██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██" +
                              "\r\n██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██" +
                              "\r\n████▄─┘██▌░░░░░░░▐██└─▄████" +
                              "\r\n█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████" +
                              "\r\n████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████" +
                              "\r\n█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████" +
                              "\r\n███████▄░░░░░░░░░░░▄███████" +
                              "\r\n██████████▄▄▄▄▄▄▄██████████" +
                              "\r\n███████████████████████████");
                deathcounter++;
                Console.WriteLine("You have died in " + CurrentLevel + " amount of deaths = " + deathcounter);

                Console.WriteLine("Press: y to try again. Press: n to leave");
                ConsoleKeyInfo StartOver = Console.ReadKey(); Console.Clear();
                switch (StartOver.KeyChar)
                {
                    case 'y':
                        switch (CheckpointLevel)
                        {
                            case 1:
                                Level1();
                                break;
                            case 2:
                                Level2();
                                break;
                            case 3:
                                Level3();
                                break;
                            case 4:
                                Level4();
                                break;
                            case 5:
                                Level5();
                                break;
                            case 6:
                                Level6();
                                break;
                        }

                        break;
                    case 'n':
                        Environment.Exit(0);
                        break;
                    default:
                        Death();
                        break;
                }
            }

            #endregion

            Console.ReadLine();
        }
        public static void Print(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
}