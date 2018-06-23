using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{

    public Text[] str;
    string[] stringToDisplay;
    string[] realString;
    private static int count;

    // Use this for initialization
    void Start()
    {
        count = 0;

        stringToDisplay = new string[2];
        realString = new string[2];

        realString[0] = "Hello!";
        realString[1] = "Bye!";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (count >= 2)
            {
                Debug.Log("J");
                DialogueMgr.offTrigger = true;
                count = 0;
            }
            stringToDisplay[count] = realString[count];
            str[count].text = stringToDisplay[count];
            str[count].gameObject.SetActive(true);
            Debug.Log(count);
            count++;
        }

    }
}
