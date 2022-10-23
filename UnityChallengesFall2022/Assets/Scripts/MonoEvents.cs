using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent updateEvent, collisionEvent, triggerEvent;

    private void Update()
    {
        updateEvent.Invoke();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter()
    {
        collisionEvent.Invoke();
    }

    private void OnTriggerEnter()
    {
        triggerEvent.Invoke();
    }
}
