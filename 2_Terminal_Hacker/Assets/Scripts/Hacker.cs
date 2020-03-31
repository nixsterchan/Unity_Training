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
        string hello = "Hey there Nexus";
        Terminal.ClearScreen();

        Terminal.WriteLine(hello + "\n" +
            "I see you are interested in hacking \n" +
            "To begin, select one of the following \n" +
            "letters A, B or C to hack into your \n" +
            "desired location \n" +
            "A : AWS Database \n" +
            "B : The School Library \n" +
            "C : Nezuko's Fanbase");
        Terminal.WriteLine("Enter your choice:");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
