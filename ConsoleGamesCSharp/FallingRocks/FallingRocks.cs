// Problem 12.** Falling Rocks
// Implement the "Falling Rocks" game in the text console.
// A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
// A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
// Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
// Ensure a constant game speed by Thread.Sleep(150).
// Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class FallingRocks
{
    public const int WindowHeight = 25;
    public const int WindowWidth = 45;

    static char[] rockSymbols = new char[] { '^', '@', '*', '&', '+', '-', '%', '$', '#', '!', '.', ';', '\u2665' };

    public struct GameObject
    {
        public int x;
        public int y;
        public string view;
        public int size;
        public int line;
        public ConsoleColor color;
    }

    static void Main()
    {
        string playerName = "NONAME";

        InitializeGameField();
        DisplayGameMenu();
        
        ConsoleKeyInfo inputKey = Console.ReadKey(true);
        switch (inputKey.Key)
        {
            case ConsoleKey.D1: PlayGame(playerName);
                                break;
            case ConsoleKey.D2: playerName = GetPlayerName();
                                PlayGame(playerName);
                                break;
            case ConsoleKey.D3: Console.WriteLine();
                                Environment.Exit(0); 
                                break;
            default: DrawInfoToConsole(20, 20, "OOOPS\n", ConsoleColor.Green);
                     Environment.Exit(0); 
                     break;
        }
    }

    private static void PlayGame(string playerName)
    {
        int dwarfLives = 3;
        int dwarfScore = 0;
        int linePassed = 0;
        int rocksOnLine = 0;
        int currentLine = 0;
        string topLine = new string('=', WindowWidth);
        Random generator = new Random();
        List<GameObject> rocks = new List<GameObject>();
       
        // Initialize dwarf
        GameObject dwarf = new GameObject();
        dwarf.x = WindowWidth / 2;
        dwarf.y = WindowHeight - 2;
        dwarf.view = "(0)";
        dwarf.size = 3;
        dwarf.color = ConsoleColor.White;
        
        while (true)
        {
            bool collision = false;
            int chanceToFall = generator.Next(0, 101);
            if (chanceToFall < 40)
            {
                currentLine++;
                rocksOnLine = generator.Next(1, 5);
                for (int i = 0; i < rocksOnLine; i++)
                {
                    GameObject rock = GenerateRock(generator);
                    rock.line = currentLine;
                    rocks.Add(rock);
                }
            }
  
            // Move dwarf
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if ((dwarf.x + dwarf.size)  <= WindowWidth - 1)
                    {
                        dwarf.x++;
                    }
                }
            }

            // Simulate falling rocks, detect collision and increase lives
            List<GameObject> nextRocks = new List<GameObject>();
            for (int i = 0; i < rocks.Count; i++)
            {
                GameObject previewRock = rocks[i];
                GameObject nextRock = new GameObject();
                nextRock.x = previewRock.x;
                nextRock.y = previewRock.y + 1;
                nextRock.size = previewRock.size;
                nextRock.line = previewRock.line;
                nextRock.view = previewRock.view;
                nextRock.color = previewRock.color;
              
                if (nextRock.y == dwarf.y)
                {
                    if (nextRock.view == "\u2665" && nextRock.x < dwarf.x + dwarf.size
                                                  && nextRock.x + nextRock.size > dwarf.x)
                    {
                        dwarfLives++;
                        nextRock.view = "LIVE";
                        nextRock.color = ConsoleColor.Red;
                    }
                    else if (nextRock.x < dwarf.x + dwarf.size && nextRock.x + nextRock.size > dwarf.x)
                    {
                        dwarfLives--;
                        collision = true;
                    }
                    else
                    {
                        dwarfScore += nextRock.size;
                        linePassed = nextRock.line;
                    }
                }

                if (nextRock.y < WindowHeight)
                {
                    nextRocks.Add(nextRock);
                }

            }

            rocks = nextRocks;
            Console.Clear();

            if (collision)
            {
                rocks.Clear();
                DrawInfoToConsole(dwarf.x, dwarf.y, "BOOM", ConsoleColor.Red);
                Console.Beep(700, 200);
                if (dwarfLives <= 0)
                {
                    DisplayGameOverScreen(dwarfScore, linePassed, playerName);
                    Console.ReadLine();
                    Main();
                }
            }
            else
            {
                DrawGameObjectToConsole(dwarf);
            }
            
            // Draw rokcs to console
            foreach (var rock in rocks)
            {
                DrawGameObjectToConsole(rock);   
            }

            // Draw info to console
            DrawInfoToConsole(5, 1, "Player: " + playerName, ConsoleColor.DarkYellow);
            DrawInfoToConsole(5, 2, "Lives: " + dwarfLives, ConsoleColor.DarkYellow);
            DrawInfoToConsole(15, 2, "Scores: " + dwarfScore, ConsoleColor.DarkYellow);
            DrawInfoToConsole(30, 2, "Line: " + linePassed, ConsoleColor.DarkYellow);
            DrawInfoToConsole(0, 3, topLine, ConsoleColor.Gray);

            // Slow game speed
            Thread.Sleep(150);
        }
    }

    private static GameObject GenerateRock(Random generator)
    {
        GameObject rock = new GameObject();
        rock.size = generator.Next(1, 4);
        rock.x = generator.Next(0, WindowWidth + 1) - rock.size;
        rock.y = 4;
        rock.color = (ConsoleColor)generator.Next((int)ConsoleColor.Blue, (int)ConsoleColor.Yellow);
        char symbol = rockSymbols[generator.Next(0, rockSymbols.Length)];
        if (symbol == '\u2665')
        {
            rock.size = 1;
            rock.color = ConsoleColor.White;
        }
        rock.view = new string(symbol, rock.size);
        if (rock.x < 0)
        {
            rock.x = 0;
        }

        return rock;
     }

    private static void DrawGameObjectToConsole(GameObject gameObject)
    {
        Console.SetCursorPosition(gameObject.x, gameObject.y);
        Console.ForegroundColor = gameObject.color;
        Console.Write(gameObject.view);
    }

    private static void DrawInfoToConsole(int x, int y, string textInfo, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(textInfo);
    }

    private static void InitializeGameField()
    {
        Console.Title = "Falling Rocks";
        Console.BufferHeight = Console.WindowHeight = WindowHeight;
        Console.BufferWidth = Console.WindowWidth = WindowWidth;
    }

    private static string GetPlayerName()
    {
        Console.Clear();
        DrawInfoToConsole(10, 5, "Enter your name: ", ConsoleColor.Green);
        string playerName = Console.ReadLine();

        return playerName;
    }

    private static void DisplayGameMenu()
    {
        Console.Clear();
        DrawInfoToConsole(15, 7, "FALLING ROCKS", ConsoleColor.DarkGreen);
        DrawInfoToConsole(10, 10, "1. Start game", ConsoleColor.Green);
        DrawInfoToConsole(10, 11, "2. Enter player name and start", ConsoleColor.Green);
        DrawInfoToConsole(10, 12, "3. Exit game", ConsoleColor.Green);
    }

    private static void DisplayGameOverScreen(int dwarfScore, int linePassed, string playerName)
    {
        Console.Clear();
        DrawInfoToConsole(17, 10, "GAME OVER", ConsoleColor.Red);
        Console.Beep(1000, 800);
        DrawInfoToConsole(14, 12, "Your scores: " + dwarfScore, ConsoleColor.DarkYellow);
        DrawInfoToConsole(14, 13, "Passed lines: " + linePassed, ConsoleColor.DarkYellow);
        DrawInfoToConsole(14, 14, "Coodbye " + playerName + "!", ConsoleColor.DarkYellow);
        DrawInfoToConsole(9, 15, "PRESS [ENTER] TO CONTINUE", ConsoleColor.Red);
    }
}