using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu()
    {
        
        Terminal.ClearScreen();

        var greetings = "Hey there Nexus";
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

    void LevelOne()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to level one \n" +
            "The game is currently still in \n" +
            "development so there is \n" +
            "nothing much. Type 'menu' into \n" +
            "the console to head back to the main menu (: ");
    }

    void LevelTwo()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to level two \n" +
            "The game is currently still in \n" +
            "development so there is \n" +
            "nothing much. Type 'menu' into \n" +
            "the console to head back to the main menu (: ");
    }

    void LevelThree()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to level three \n" +
            "The game is currently still in \n" +
            "development so there is \n" +
            "nothing much. Type 'menu' into \n" +
            "the console to head back to the main menu (: ");
    }

    void OnUserInput(string input)
    {
        if (input == "1")
        {
            //Terminal.WriteLine("True");
            LevelOne();
        }
        else if (input == "2")
        {
            LevelTwo();
        }
        else if (input == "3")
        {
            LevelThree();
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

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
