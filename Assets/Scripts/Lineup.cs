using UnityEngine;

public class Lineup : MonoBehaviour
{

    public GameObject Player;
    public GameObject Camera;
    public GameObject ExistingUI;
    public GameObject LineupUI;
    public GameObject Sprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LineupUI.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Player.SetActive(false);
        Camera.SetActive(true); 
        ExistingUI.SetActive(false);
        LineupUI.SetActive(true);
        Sprites.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


}
