using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        transform.position += new Vector3(0, 0, 2) * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
