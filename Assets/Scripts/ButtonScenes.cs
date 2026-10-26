using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonScene : MonoBehaviour
{
    public string sceneName;
    
    public void SwapSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}