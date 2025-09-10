using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public GameObject uiBackground;
    public bool switchOn = true;

    public bool TurnSwitch()
    {
        if (switchOn)
        {
            //uiBackground.enabled = true;
            uiBackground.SetActive(true);
            return true;
        }
        else
        {
            //uiBackground.enabled = false;
            uiBackground.SetActive(false);
            return false;
        }
    }
}
