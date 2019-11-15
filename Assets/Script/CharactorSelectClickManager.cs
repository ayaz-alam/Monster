using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CharactorSelectClickManager : MonoBehaviour
{
    [SerializeField]
    public Button Angry;
    [SerializeField]
    public Button Amazed;
    [SerializeField]
    public Button Sad;
    [SerializeField]
    public Button Disgusted;
    [SerializeField]
    public Button Happy;
    [SerializeField]
    public Button Scared;

    // Start is called before the first frame update
    void Start()
    {
        Angry.onClick.AddListener(delegate { LoadSceneMode(0); });
        Sad.onClick.AddListener(delegate { LoadSceneMode(1); });
        Amazed.onClick.AddListener(delegate { LoadSceneMode(2); });
        Disgusted.onClick.AddListener(delegate { LoadSceneMode(3); });
        Happy.onClick.AddListener(delegate { LoadSceneMode(4); });
        Scared.onClick.AddListener(delegate { LoadSceneMode(5); });

    }
    private void LoadSceneMode(int levelNo)
    {
        switch (levelNo)
        {
            case 0: SceneManager.LoadScene("IntroOOO");
                break;
                //TODO add more games screen
            default: break; 
        }
    }



}
