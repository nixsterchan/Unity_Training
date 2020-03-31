﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Game configuration data
    string[] level1Passwords = { "dbs", "instances", "elastics", "ips" };
    string[] level2Passwords = { "books", "toilet", "tables", "chairs" };
    string[] level3Passwords = { "tanjirou", "zenitsu", "inosuke", "giyuu" };


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
        bool isValidLevel = (input == "1" || input == "2" || input == "3");
        if (isValidLevel)
        {
            level = int.Parse(input);
            AskForPassword();
        }
        else
        {
            Terminal.WriteLine("Please enter a valid input!");
        }

        
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to level " + level);
        SetRandomPassword();
        Terminal.WriteLine("Enter your guess: " + password.Anagram());
    }

    void SetRandomPassword()
    {
        var random = new System.Random();
        switch (level)
        {
            case 1:
                password = level1Passwords[random.Next(level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[random.Next(level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[random.Next(level3Passwords.Length)];
                break;
            default:
                Debug.Log("Invalid Level reached");
                break;
        }
    }

    void HandlePassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("The input was incorrect, please try again (:");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Congratulations, you just got the right password!");
                Terminal.WriteLine("To return to the main menu to try other levels, type 'menu'");
                break;
            case 2:
                Terminal.WriteLine("Congratulations!");
                Terminal.WriteLine("Here have a book");
                Terminal.WriteLine(@"
    _______
   /      //
  /      //
 /_____ //
(______(/
                ");
                Terminal.WriteLine("To return to the main menu to try other levels, type 'menu'");
                break;
            case 3:
                Terminal.WriteLine("Congratulations, you just got the right password!");
                Terminal.WriteLine("To return to the main menu to try other levels, type 'menu'");    
                break;
            default:
                Debug.Log("Invalid Level reached");
                break;
             
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
