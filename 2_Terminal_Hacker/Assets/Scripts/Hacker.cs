using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int level; 
    string password;
    enum Screen { MainMenu, Password, Win}; // Define our own type
    //enum Level { Level1, Level2, Level3 }
    Screen currentScreen;
    //Level currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        var greetings = "Hey there Nexus";

        Terminal.ClearScreen();
        Terminal.WriteLine(greetings + "\n" +
            "I see you are interested in hacking \n" +
            "To begin, select one of the following \n" +
            "levels 1, 2 or 3 to hack into your \n" +
            "desired location \n" +
            "1 : AWS Database \n" +
            "2 : The School Library \n" +
            "3 : Nezuko's Fanbase");
        Terminal.WriteLine("Enter your choice:");

    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            HandlePassword(input);
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "aws";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "sutd";
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = "tanjirou";
            StartGame();
        }
        else if (input == "menu")
        {
            ShowMainMenu();
        }
        else
        {
            Terminal.WriteLine("Please enter a valid input");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("Welcome to level " + level);
        Terminal.WriteLine("Please enter your password guess: ");
    }

    void HandlePassword(string input)
    {
        if (input == password)
        {
            currentScreen = Screen.Win;
            Terminal.WriteLine("Congratulations, you just got the right password!");
            Terminal.WriteLine("To return to the main menu to try other levels, type 'menu'");
        }
        else
        {
            Terminal.WriteLine("The input was incorrect, please try again (:");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
