using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ScrollScript : MonoBehaviour
{
    private ScrollRect scrollRect;
    private bool mouseDown, buttonDown, buttonUp;
    private float scrollAmount = 1.0f;

    void Start(){
        scrollRect = GetComponent<ScrollRect>();
    }

    private void Update()
    {

        if (mouseDown)
        {
            Debug.Log("Mouse Down"+buttonDown);
            if (buttonDown)
            {
                scrollDown();
            }
            else if (buttonUp)
            {
                scrollUp();
            }
        }
    }

    private void scrollDown()
    {
        scrollRect.horizontalNormalizedPosition += scrollAmount;
        mouseDown = false;
        buttonDown = false;
    }

    public void buttonDownIsPressed()
    {
        mouseDown = true;
        buttonDown = true;
    }
    public void buttonUpIsPressed()
    {
        mouseDown = true;
        buttonUp = true;
    }

    private void scrollUp()
    {
        scrollRect.horizontalNormalizedPosition -= scrollAmount;
        mouseDown = false;
        buttonUp = false;
    }
}
