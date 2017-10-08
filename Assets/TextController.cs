using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;
    private States myState;


    private enum States { cell, cellMirror, mirror, sheets_0, lock_0, sheets_1, lock_1, freedom,
    corridor_0, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, stairs_2, corridor_2,
    corridor_3, courtyard};
    

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
        else if (myState == States.cellMirror)
        {
            stateCellMirror();
        }
        else if (myState == States.sheets_1)
        {
            stateSheets_1();
        }
        else if (myState == States.lock_1)
        {
            stateLock_1();
        }
        else if (myState == States.stairs_0)
        {
            stateStairs_0();
        }
        else if (myState == States.floor)
        {
            stateFloor();
        }
        else if (myState == States.closet_door)
        {
            stateCloset_Door();
        }
        else if (myState == States.stairs_1)
        {
            stateStairs_1();
        }
        else if (myState == States.stairs_2)
        {
            stateStairs_2();
        }
        else if (myState == States.corridor_2)
        {
            stateCorridor_2();
        }
        else if (myState == States.corridor_3)
        {
            stateCorridor_3();
        }
        else if (myState == States.courtyard)
        {
            stateCourtyard();
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

    void stateCellMirror()
    {
        text.text = "You now have a lockpick. If only you knew " +
        "what to do with it. Hm... \n\n" +
        "Press S to View Sheets or L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {

            myState = States.sheets_1;

        }else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void stateSheets_1()
    {
        text.text = "You still haven't washed your dirty sheets. You decide that " +
        " there are more important matters at hand.. " +
        " \n\n" +
        "Press R to return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.cellMirror;

        }
    }

    void stateLock_1()
    {
        text.text = "You use the lockpick you found on the lock. After a few seconds of trial and error, " +
        " the lock clicked! The door swung open slowly!" +
        " \n\n" +
        "Press O to gain freedom or press R to return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.cellMirror;

        }else if (Input.GetKeyDown(KeyCode.O))
        {

            myState = States.freedom;

        }
    }

    void stateStairs_0()
    {

    }

    void stateFloor()
    {

    }

    void stateCloset_Door()
    {

    }

    void stateStairs_1()
    {

    }

    void stateStairs_2()
    {

    }

    void stateCorridor_2()
    {

    }

    void stateCorridor_3()
    {

    }

    void stateCourtyard()
    {

    }


}
