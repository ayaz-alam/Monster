using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BaseScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject guy;
    public GameObject parent;
    public Sprite angry;
    public int angryPos;
    public Sprite happy;
    public int numberOfIconsPerScreen;
    private OddOneOutClick clickScript;
    private PlayerStats player;
    public GameObject dialog;
    public TMPro.TextMeshProUGUI dialogText;


    void Start()
    {
        dialog.SetActive(false);
        RectTransform r = (RectTransform)guy.transform;
        float w = r.rect.width;
        player = new PlayerStats();
        player.saveSelPos(-1);

        Vector2[] positionArray = LevelConstants.getRandomVectors(numberOfIconsPerScreen,w);
        int oddOne =Random.Range(0,numberOfIconsPerScreen);
        angryPos = oddOne;

        for (int i = 0; i < numberOfIconsPerScreen; i++)
        {
            GameObject clone = Instantiate(guy, positionArray[i], Quaternion.identity);
            clone.name = "" + i;
            RectTransform rt = (RectTransform)clone.transform;
            float width = rt.rect.width;
            if (i == oddOne) clone.GetComponent<Image>().sprite = angry;
            clone.SetActive(true);
            clone.transform.SetParent(parent.transform);
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        int selPos = player.getSelPos();
        if (selPos!= -1)
        {
            player.saveSelPos(-1);
            if (selPos == angryPos)
            {
                parent.SetActive(false);
                Debug.Log("Hurray!!! you won");
                SceneManager.LoadScene("Won");
                
            }
            else
            {
                parent.SetActive(false);
                dialog.SetActive(true);
                dialogText.SetText("Try again");
                Debug.Log("You lost!! Try again");
            }

        }

        
    }
}
