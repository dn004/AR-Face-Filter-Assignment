using UnityEngine;
using UnityEngine.SceneManagement;


public class transition : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}


