using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    [SerializeField]
    public Button Retry;
    [SerializeField]
    public Button Home;
    // Start is called before the first frame update
    void Start()
    {
        Retry.onClick.AddListener(delegate { LoadSceneMode("OddOneOut"); });
        Home.onClick.AddListener(delegate { LoadSceneMode("Select Charactor"); });
        
    }
    private void LoadSceneMode(string name)
    {
        SceneManager.LoadScene(name);
    }



}
