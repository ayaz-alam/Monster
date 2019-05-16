using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectionScreenButtonClick : MonoBehaviour
{

 
    public void OnMouseDown()
    {
        // load a new scene
        Debug.Log("Avatar Clicked");
        //SceneManager.LoadScene("Select Charactor");
    }
}