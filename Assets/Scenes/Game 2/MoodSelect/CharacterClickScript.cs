using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterClickScript: MonoBehaviour, IPointerDownHandler
{
    PlayerStats preferences;
    private void Start()
    {
        preferences = new PlayerStats();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Came here");
        preferences.mood = gameObject.name;
        preferences.Save();
        SceneManager.LoadScene("IntroOOO");
        Debug.Log("Charactor : " + gameObject.name);
    }
}
