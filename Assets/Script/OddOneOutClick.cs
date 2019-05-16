using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class OddOneOutClick : MonoBehaviour, IPointerDownHandler
{
    PlayerStats preferences;
    public int selectedPostion;
    private void Start()
    {
        preferences = new PlayerStats();
    }
    private int i = 0;
    public void OnPointerDown(PointerEventData eventData)
    {
        string name = gameObject.name;
        selectedPostion = int.Parse(name);
        preferences.saveSelPos(selectedPostion);
    }
}
