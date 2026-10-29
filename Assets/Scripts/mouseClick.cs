using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class mouseClick : MonoBehaviour
{
    public string newSceneName;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(newSceneName);
    }
}