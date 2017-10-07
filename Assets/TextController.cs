﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States { cell, mirror, sheets_0, lock_0, sheets_1, lock_1, freedom};
    private States myState;

	// Use this for initialization
	void Start () {

        myState = States.cell;
		
	}
	
	// Update is called once per frame
	void Update () {

        if(myState == States.cell)
        {
            stateCell();
        }else if(myState == States.sheets_0)
        {
            stateSheets0();
        }

    }

    void stateCell()
    {
        text.text = "You are in the prison cell and you want to escape. There " +
                "are some dirty sheets on the bed, a mirror on the wall, and the door " +
                "is locked from the outside. \n\n" +
                "Press S to View Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {

            myState = States.sheets_0;
           
        }
    }

    void stateSheets0()
    {
        text.text = "You can't believe you sleep in these things. Surely it's" +
        " time somebody changed them. The pleasures of prison life " +
        "I guess! \n\n" +
        "Press R to return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.cell;

        }
    }

            
}
