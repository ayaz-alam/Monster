using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField]
    public Image[] hearts;
    [SerializeField]
    public static int health;
    public Sprite heart_active;
    public Sprite heart_lost;

    private const int numberOfHearts = 3;


    // Start is called before the first frame update
    void Start()
    {
        health = numberOfHearts;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > numberOfHearts) health = numberOfHearts;
        for(int i = 0; i < numberOfHearts; i++) {
            if (i < health){
                hearts[i].sprite = heart_active;
            }
            else
            {
                hearts[i].sprite = heart_lost;
            }

        }
        
    }
}
