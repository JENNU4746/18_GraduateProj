using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMgr : MonoBehaviour {

    private bool isDialogueActive = true;
    public GameObject DialogueWindow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isDialogueActive == false)
            {
                isDialogueActive = true;
            }
            else
            {
                isDialogueActive = false;
            }
        }
        if (isDialogueActive==false)
        {
            DialogueWindow.SetActive(false);
        }
        if (isDialogueActive == true)
        {
            DialogueWindow.SetActive(true);
        }
    }
}
