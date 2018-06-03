using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

    public Text str;
    string stringToDisplay;
    string realString;
    float timeGone;
    int count;

	// Use this for initialization
	void Start () {
        timeGone = 0; count = 0;
        realString = "Hello!";
	}
	
	// Update is called once per frame
	void Update () {
        while(count<realString.Length)
        {
            if (timeGone > 5)
            {
                stringToDisplay += realString[count];
                Debug.Log(stringToDisplay);
                str.text = stringToDisplay;
                count++;
                timeGone = 0;
            }
            timeGone += Time.deltaTime;
        }
	}
}
