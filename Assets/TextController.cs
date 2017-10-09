using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;
    private States myState;

    
    private enum States { cell, cellMirror, mirror, sheets_0, lock_0, sheets_1, lock_1,
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
        }else if (myState == States.corridor_0)
        {
            stateCorridor_0();
        }
        else if (myState == States.corridor_1)
        {
            stateCorridor_1();
        }
        else if (myState == States.in_closet)
        {
            stateIn_Closet();
        }

    }

    void stateCell()
    {
        text.text = "You are in a prison cell and you want to escape. There " +
                "are some dirty sheets on the bed, a mirror on the wall, and the door " +
                "is locked from the outside. \n\n" +
                "Press S to View Sheets, M to view Mirror or L to view Lock";

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
        "Press O to exit your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.cellMirror;

        }else if (Input.GetKeyDown(KeyCode.O))
        {

            myState = States.corridor_0;

        }
    }

    void stateStairs_0()
    {
        text.text = "You tip toe up the stairs and hear the guards' voices.  You try not to fall " +
        "as you quickly tip toe back down the stairs. " +
        " \n\n" +
        "Press R to return to your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.corridor_0;

        }
    }

    void stateFloor()
    {
        text.text = "You inspect the floor and find a hairpin! " +
        "This could be useful. \n\n" +
        "Press H to pocket the hairpin or R to return to your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.corridor_0;

        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.corridor_1;
        }
    }

    void stateCloset_Door()
    {
        text.text = "You try turning the doorknob on the closet door. " +
        "Darn it!  It's locked! Oh well..." +
        " \n\n" +
        "Press R to return to your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.corridor_0;

        }
    }

    void stateStairs_1()
    {
        text.text = "As you get closer to the stairs, you begin to hear the guards voices. " +
        "They sound closer than last time. Are they coming this way?" +
        " \n\n" +
        "Press R to return your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.corridor_1;

        }

    }

    void stateStairs_2()
    {
        text.text = "Yikes! The guards are literally right around the corner! You've got to figure something out fast! " +
        " \n\n" +
        "Press R to return to your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.corridor_2;

        }
    }

    void stateCorridor_2()
    {
        text.text = "You've unlocked the closet using the hairpin and found the cleaner's clothes. What " +
        "will you do now?" +
        " \n\n" +
        "Press B to go back to the closet or S to inspect the stairs.";

        if (Input.GetKeyDown(KeyCode.B))
        {

            myState = States.in_closet;

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {

            myState = States.stairs_2;

        }
    }

    void stateCorridor_3()
    {
        text.text = "You are now dressed as the cleaner." +
        
        " \n\n" +
        "Press U to undress and return to the closet or S to inspect the stairs.";

        if (Input.GetKeyDown(KeyCode.U))
        {

            myState = States.in_closet;

        } else if (Input.GetKeyDown(KeyCode.S))
        {

            myState = States.courtyard;

        }
    }

    void stateCourtyard()
    {
        text.text = "Dressed as the cleaner, you walk past the guards. " +
        "You open the front door to the courtyard and....YOU'RE FREE!" +
        " \n\n" +
        "Thank you for playing! " +
        "Press P if you would like to play again.";

        if (Input.GetKeyDown(KeyCode.P))
        {

            myState = States.cell;

        }
    }

    void stateCorridor_0()
    {
        text.text = "You're free! Sort of....Now you need to escape the rest of the prison." +
        " \n\n" +
        "Press S to inspect the stairs, F to inspect the floor or C to inspect the closet door.";

        if (Input.GetKeyDown(KeyCode.S))
        {

            myState = States.stairs_0;

        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.closet_door;
        }
    }

    void stateCorridor_1()
    {
        text.text = "You now have a hairpin, but it feels like you're back at square one! Hm..." +
        " The guards may find you at this rate..." +
        " \n\n" +
        "Press S to inspect the stairs or P to inspect the closet.";

        if (Input.GetKeyDown(KeyCode.S))
        {

            myState = States.stairs_1;

        }
        if (Input.GetKeyDown(KeyCode.P))
        {

            myState = States.in_closet;

        }
    }

    void stateIn_Closet()
    {
        text.text = "You try the hairpin on the locked closet door. " +
        "It unlocked! Now, what's in this closet? " +
        "There appears to be some clothes here.. GASP! It's the cleaner's clothes! " +
        "These could be useful. " +
        " \n\n" +
        "Press R to return to your cell or D to dress up as a cleaner.";

        if (Input.GetKeyDown(KeyCode.R))
        {

            myState = States.corridor_2;

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.corridor_3;
        }

    }
}
