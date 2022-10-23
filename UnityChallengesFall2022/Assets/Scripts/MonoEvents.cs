using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehavior : MonoBehaviour
{
    public UnityEvent updateEvent, collisionEvent, resetEvent;

    private void Update()
    {
        updateEvent.Invoke();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter()
    {
        collisionEvent.Invoke();
    }

    private void Reset()
    {
        resetEvent.Invoke();
    }
}
