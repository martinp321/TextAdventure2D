using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TextController : MonoBehaviour
{
    public Text commands;
    private Text text;
    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, lock_1, freedom };
    private States myState;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();

        myState = States.cell;

        text.text = "Welcome";
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);

        switch (myState)
        {
            case States.cell:
                state_cell();
                break;

            case States.mirror:
                break;

            case States.sheets_0:
                state_sheets_0();
                break;

            case States.lock_0:
                break;

            case States.cell_mirror:
                break;

            case States.lock_1:
                break;

            case States.freedom:
                break;

        }


    }

    void state_cell()
    {
        text.text = "You have come into a dark cell.\n\n";
        commands.text = "(S)heets";

        if (Input.GetKeyDown(KeyCode.S))
            myState = States.sheets_0;
    }

    void state_sheets_0()
    {
        text.text = "Why are there so many sheets?\n\n";
        commands.text = "(C)ell";

        if (Input.GetKeyDown(KeyCode.C))
            myState = States.cell;
    }
}

