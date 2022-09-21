using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent repeatEvent;
    
    public int counterNum = 3;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    private IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        Debug.Log("Start");
        yield return wfsObj;
        Debug.Log("Late Start");

        while (counterNum > 0)
        {
            yield return wfsObj;
            repeatEvent.Invoke();
        }
    }
}
