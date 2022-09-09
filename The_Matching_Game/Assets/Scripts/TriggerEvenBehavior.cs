using UnityEngine;
using UnityEngine.Events;

public class TriggerEvenBehavior : MonoBehaviour
{
   public UnityEvent triggerEnterEvent;

   private void OnTriggerEnter(Collider other)
   {
    triggerEnterEvent.Invoke();
   }
}
