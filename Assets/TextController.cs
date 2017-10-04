using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {

        text.text = "Hello, World";
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown("space")) {
            text.text = "Space Key Pressed";
        }
    }
}
