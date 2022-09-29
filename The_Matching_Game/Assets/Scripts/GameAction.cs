using UnityEngine;
using UnityEngine.Events;

public class GameAction : ScriptableObject
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
