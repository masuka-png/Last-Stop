using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class mouseClick : MonoBehaviour, IPointerClickHandler
{
    public string sceneName;

    public void OnPointerClick(PointerEventData eventdata)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("YO");
    }
}
