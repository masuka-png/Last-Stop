using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CollectEvidence : MonoBehaviour, IInteractable
{

    static int evidence = 0;
    public Text txt;

    void start()
    {
        txt.text = " a" + evidence;
    }

    public void Interact()
    {
        Destroy(this.gameObject);
        evidence += 1;
        if (evidence == 5)
        {
            SceneManager.LoadScene("InterrogateSelector");
        }
        else
        {
            Debug.Log("NUH UH");
        }
    }

    void update()
    {
        txt.text = " " + evidence;
    }
}
