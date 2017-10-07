using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States { cell, cellMirror, mirror, sheets_0, lock_0, sheets_1, lock_1, freedom};
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
        else if (myState == States.lock_0)
        {
            stateLock_0();
        }
        else if (myState == States.mirror)
        {
            stateMirror();
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
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
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

    void stateMirror()
    {
        text.text = "You inspect the mirror and find a small hole behind it. " +
        "You look in the hole and find a thin rock that can be used as a lock pick! Eureka! \n\n" +
        "Press T to take the lock pick or R to return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.cell;

        }else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cellMirror;
        }
    }

    void stateLock_0()
    {
        text.text = "You tried the lock and as you expected, it's too tough " +
        "to break. Bummer... \n\n" +
        "Press R to return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.cell;

        }
    }


}
