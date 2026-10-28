using UnityEngine;
using UnityEngine.SceneManagement;



public class sceneManager : MonoBehaviour
{ 

    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneName);
    }

}
