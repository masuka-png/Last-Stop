using UnityEngine;
using UnityEngine.SceneManagement;



public class sceneManager : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Inside");
    }

}
