using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviourScript : MonoBehaviour
{
   public ID idObj;
   public UnityEvent matchEvent, noMatchEvent;
   
   private IEnumerator OnTriggerEnter(Collider other)
   {
      var tempObj = other.GetComponent<IDContainerBehaviour>();
      if (tempObj == null) 
         yield break;
      
      var otherID = tempObj.idObj;
      if (otherID == idObj)
      {
         matchEvent.Invoke();
         Debug.Log("Matched");
      }
      else
      {
        noMatchEvent.Invoke();
         yield return new WaitForSeconds(0.5f);
         noMatchEvent.Invoke();
         Debug.Log("No");
      }
   }
}
