using UnityEngine;
using UnityEngine.SceneManagement;

public class RayCastScript : MonoBehaviour
{
    RaycastHit hit;
    Ray ray;
    PlayerStats preferences;
    private void Start()
    {
        preferences = new PlayerStats();
    }
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
            preferences.mood = hit.collider.gameObject.name.ToString();
            preferences.Save();
            SceneManager.LoadScene("OddOneOut");
            
        }
    }
}