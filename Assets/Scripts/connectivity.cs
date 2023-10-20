using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connectivity : MonoBehaviour
{
    private LineRenderer line;
    Vector3 offset;
    [SerializeField] private string destinationTag;
    private void Start()
    {
        line= GetComponent<LineRenderer>();
    }
    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
    }
    private void OnMouseDrag()
    {
        line.SetPosition(0,MouseWorldPosition()+offset);
        line.SetPosition(1, transform.position);
    }
    private void OnMouseUp()
    {
        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 rayDir = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;

        if(Physics.Raycast(rayOrigin,rayDir,out hitInfo)){
            if(hitInfo.transform.tag == destinationTag)
            {
                line.SetPosition(0,hitInfo.transform.position);
                transform.gameObject.GetComponent<Collider>().enabled = false;
            }
            else
            {
                line.SetPosition(0, transform.position);
            }
        }
    }
    private Vector3 MouseWorldPosition()
    {
        Vector3 mouseScreenPos=Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
