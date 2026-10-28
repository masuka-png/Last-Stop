using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public bool triggerOnce = false;
    bool used;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player") || (triggerOnce && used)) return;
        used = true;
        onEnter.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) onExit.Invoke();
    }
}