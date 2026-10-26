using UnityEngine;

public class sectionTrigger : MonoBehaviour
{
    public GameObject road;
    public GameObject sphere;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(road, new Vector3(0, 0, -141), Quaternion.identity);
        }
    }
}
