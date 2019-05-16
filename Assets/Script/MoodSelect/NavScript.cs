using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class NavScript : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private ScrollScript scrollScript;
    [SerializeField]
    private bool isDownButton;

    public void OnPointerDown(PointerEventData eventData)
    {

        Debug.Log("Clicked" + gameObject.name);
        if (isDownButton)
        {
            scrollScript.buttonDownIsPressed();
        }
        else
        {
            scrollScript.buttonUpIsPressed();
        }
    }
}
