using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    public void PressedLeftClick()
    {
        Debug.Log("You Left Clicked " + this.name);
    }

    public void PressedMiddleClick()
    {
        Debug.Log("You Middle Clicked " + this.name);
    }

    public void PressedRightClick()
    {
        Debug.Log("You Right Clicked " + this.name);
    }

    public void PressedSubmit()
    {
        Debug.Log("You Pressed Submit " + this.name);
    }

    public void PressedCancel()
    {
        Debug.Log("You Pressed Cancel " + this.name);
    }
}
