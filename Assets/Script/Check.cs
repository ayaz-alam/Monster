using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerStats stats = new PlayerStats();
        stats.Load();
        Debug.Log("Selected Mood is: "+stats.mood);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
