using UnityEngine;

public class MatchBehaviourScript : MonoBehaviour
{
   public ID idObj;
   private void OnTriggerEnter(Collider other)
   {
      var tempObj = other.GetComponent<IDContainerBehaviour>();
      if (tempObj != null) 
         return;
      
      var otherID = tempObj.idObj;
      if (otherID == idObj)
     {
        Debug.Log("Matched");
     }
     else
     {
         Debug.Log("No Match");
     }
   }
}
