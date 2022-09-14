using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DraggableBehaviour : MonoBehaviour
{ 
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToViewportPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);//Debug.Log("drag*QUEEN*");
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }

}
