using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class DraggableBehaviour : MonoBehaviour
{ 
    private Camera cameraObj;
    public bool draggable;
    public UnityEngine.Vector3 position;
    public UnityEngine.Vector3 offset;

    public UnityEvent startDragEvent, endDragEvent;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition);//Debug.Log("drag*QUEEN*");
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }

}
