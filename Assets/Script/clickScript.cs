using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickScript : MonoBehaviour
{

    [SerializeField]
    Button Left;
    [SerializeField]
    Button Right;

    [SerializeField]
    private ScrollScript scrollScript;

    // Start is called before the first frame update
    void Start()
    {
        Left.onClick.AddListener(left);
        Right.onClick.AddListener(right);
        
    }
    private void left()
    {
        scrollScript.buttonUpIsPressed();
    }

    private void right()
    {
        scrollScript.buttonDownIsPressed();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
