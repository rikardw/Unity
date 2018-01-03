using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcontroller : MonoBehaviour
{
    public Text text;
    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1,
                        corridor_0 }
    private States myState;

    void Start()
    {
        myState = States.cell;

    }
    void Update()
    {
        print(myState);
        if (myState == States.cell)
        {
            cell();
        }
        else if (myState == States.sheets_0)
        {
            sheets_0();
        }
        else if (myState == States.sheets_1)
        {
            sheets_1();
        }
        else if (myState == States.lock_0)
        {
            lock_0();
        }
        else if (myState == States.lock_1)
        {
            mirror();
        }
        else if (myState == States.mirror)
        {
            mirror();
        }
        else if (myState == States.cell_mirror)
        {
            cell_mirror();
        }
        else if (myState == States.corridor_0)
        {
            corridor_0();
        }
    }
    void cell()
    {
        {
            text.text = "You are in a prison cell and you want to escape. " +
                "There are some dirty sheets on the bed and a mirror on the wall. " +
                "The door is locked from outside.\n\n" +
                "Press S to view Sheets, M to look at the Mirror and L to view the Lock.";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
    }
    void cell_mirror()
    {
        {
            text.text = "You are still your prison cell and you still want to escape.\n " +
                "No reason to not try the keycard. None whatsoever\n\n" +
                "Press S to view Sheets or L to open the Lock.";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.corridor_0;
        }
    }
    void sheets_0()
    {
        text.text = "Just a bunch of old smelly cyber-sheets.\n" +               
            "This is a cyber-punk prison by the way. \n \n" +            
            "Press R to Return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void sheets_1()
    {
        text.text = "Still the same old cyber-sheets.\n" +
            "You feel dumb. \n \n" +
            "Press R to Return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    void lock_0()
    {
        text.text = "You see a door with a lock. It's locked.\n" +              
            "If you want to get out you will probaly have to go through the door. \n" +               
            "Too bad it's locked, so you cant. \n\n" +                       
            "You should try to open it somehow though. \n\n" +               
            "Press R to Return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void lock_1()
    {
        text.text = "You open the lock\n\n" +
            "The door opens, yay" +
            "Press E to Exit";
        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.corridor_0;
        }
    }
    void mirror()
    {
        text.text = "Hey theres a keycard hanging on that mirror.\n" +
            "You take the key. \n\n" +
            "Press R to Return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    void corridor_0()
    {
        text.text = "You open the door with the keycard.\n\n" +
            "You step outside your cell, you are free, coolios. \n\n(You win the game btw)";
    }
}