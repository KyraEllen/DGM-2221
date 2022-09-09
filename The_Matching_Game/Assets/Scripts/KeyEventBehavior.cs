using UnityEngine;
using UnityEngine.Events;

public class AwakeEventBehavior : MonoBehaviour
{
    public UnityEvent awakeEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }
}
