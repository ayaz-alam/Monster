using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameTwoUI : MonoBehaviour
{
    [SerializeField]
    public Button RightButton;
    [SerializeField]
    public Button WrongButon;
    [SerializeField]
    public Image Avatar;

    private Sprite[] happyArray;

    private Sprite[] sadArray;

    private bool happy = false;

    private bool shake = false;

    private Vector2 screenPos;

    public GameObject holder;

    // Start is called before the first frame update
    void Start(){
        screenPos = new Vector2();
        screenPos.x = holder.transform.position.x;
        screenPos.y = holder.transform.position.y;

        prepareArray();

        loadImage();

        RightButton.onClick.AddListener(delegate {
            checkHappy(true);
        });
        WrongButon.onClick.AddListener(delegate {
            checkHappy(false);
        });

    }

    private void loadImage()
    {
        bool isHappy = randomIsHappy();
        this.happy = isHappy;
        Sprite sprite = getImage();
        if (sprite != null)
        {
            Avatar.sprite = sprite;
        }
  
    }
    //Returns a random image
    private Sprite getImage()
    {
        if (happy)
            return happyArray[UnityEngine.Random.Range(0, 5)];
        else
            return sadArray[UnityEngine.Random.Range(0, 5)];
    }
    //Prepare the array
    private void prepareArray(){
        happyArray = new Sprite[5];
        sadArray = new Sprite[5];
        for (int i = 0; i < 5; i++){
            happyArray[i] = Resources.Load<Sprite>("Images/Avatars/happy_"+(i+1));
            sadArray[i] = Resources.Load<Sprite>("Images/Avatars/sad_" + (i + 1));
        }
    }

    private bool randomIsHappy()
    {
        return UnityEngine.Random.Range(0, 2)==0;
    }

    private void checkHappy(bool happy) {

       if (happy == isHappy())
        {

            loadImage();
        }
        else
        {
            shake = true;
            shake_time = 5;
            HealthScript.health--;

            if (HealthScript.health == 0)
            {
                gameOver();
                return;
            }
            loadImage();
        }
        

    }

  

    private void gameOver()
    {
        Debug.Log("Game over...");
    }

    private bool isHappy(){
        return happy;
    }

    int shake_time = 5;
    int speed = 5;
    int amount =  20;
    // Update is called once per frame
    void Update()
    {
        if (shake)
        {
            while (shake_time--==0) {
                Vector2 d = new Vector2();
                d.x = (screenPos.x + Mathf.Sin(Time.time * speed) * amount);
                d.y = (screenPos.y + Mathf.Sin(Time.time * speed) * amount);
                holder.transform.position = d;
            }
            if (shake_time == 0)
            {
                shake = false;
                holder.transform.position = screenPos;
            }
        }
      
            
            
             
       

    }
}
