using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Events;

public class BaseUIScript : MonoBehaviour
{

    public static bool isPaused = false;

    [SerializeField]
    public Button BackButton;
    [SerializeField]
    public Button PauseButton;
    [SerializeField]
    public GameObject PauseDialog;
    [SerializeField]
    public Button Resume;
    [SerializeField]
    public Button Restart;
    [SerializeField]
    public Button MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        PauseDialog.SetActive(false);

        BackButton.onClick.AddListener(delegate {
            isPaused = true;
            PauseDialog.SetActive(true);
        });

        Resume.onClick.AddListener(delegate {
            isPaused = false;
            PauseDialog.SetActive(false);
        });

        Restart.onClick.AddListener(delegate {
            isPaused = false;
            SceneManager.LoadScene(VALUES.OddOneOut);
        });

        MainMenu.onClick.AddListener(delegate {
            isPaused = false;
            SceneManager.LoadScene(VALUES.Home);
        });

        PauseButton.onClick.AddListener(delegate { TogglePause(); });


    }

    private void TogglePause()
    {
        Debug.Log("Toggle Pause: " + isPaused);
        if (isPaused) resumeGame();
        else PauseGame();
    }

    private void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        PauseDialog.SetActive(true);

    }

    private void resumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        PauseDialog.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
