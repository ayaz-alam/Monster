using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class DialogButtons : MonoBehaviour, IPointerDownHandler
{
   
    public void OnPointerDown(PointerEventData eventData)
    {
        string name = gameObject.name;

        if (name.Equals("Home"))
            SceneManager.LoadScene("Select Charactor");
        else if (name.Equals("Retry"))
            SceneManager.LoadScene("OddOneOut");
        else if (name.Equals("Setting"))
            SceneManager.LoadScene("Options");
        else if (name.Equals("About"))
            SceneManager.LoadScene("About");
        else if (name.Equals("BackToOption"))
            SceneManager.LoadScene("Options");
        else if(name.Equals("StartOOO"))
            SceneManager.LoadScene("LevelPick");
        else if (name.Equals("BackToSelect"))
            SceneManager.LoadScene("Select Charactor");
        else if (name.Equals("Profile"))
            SceneManager.LoadScene("Profile");
        else if (name.Equals("SignUp"))
            SceneManager.LoadScene("Select Charactor");
        else if(name.Equals("L1"))
            SceneManager.LoadScene("OddOneOut");
        else if (name.Equals("WinNext"))
            SceneManager.LoadScene("LevelPick");


    }

}
