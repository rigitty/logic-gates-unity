using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class plugoutdplicater : MonoBehaviour
{
    Vector3 mousePosition;
    public GameObject plugout;
    private int count = 0;
    private LineRenderer line;
    public GameObject pos;
    private LineRenderer hold;

    public GameObject lineobject;

    private GameObject temp;

    private GameObject[] obj1= new GameObject[4];
    private GameObject[] obj2=new GameObject[4];
    private LineRenderer[] lr1= new LineRenderer[4];
    public GameObject button;
    public Quaternion offset;
    private void Start()
    {
        lineobject = GameObject.FindGameObjectWithTag("lr1");
        plugout = GameObject.FindGameObjectWithTag("pos1");
        line = GetComponent<LineRenderer>();
    }
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        if (count < 4)
        {
            temp = Instantiate(plugout, transform.position, Quaternion.identity*offset) ;
            temp.transform.SetParent(pos.transform);
            mousePosition = Input.mousePosition - GetMousePos();

            obj1[count] = temp;

            temp = Instantiate(lineobject, transform.position, Quaternion.identity*offset) ;
            temp.transform.SetParent(transform);
            hold = temp.GetComponent<LineRenderer>();

            lr1[count] = hold;
            obj2[count] = temp;
            count++;
        }
    }
    private void OnMouseDrag()
    {
        if (CompareTag("plugout"))
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        }

    }
    private void Update()
    {
        for(int i = 0; i < count; i++)
        {
            lr1[i].SetPosition(0, obj1[i].transform.position);
            lr1[i].SetPosition(1, obj2[i].transform.position);
        }
    }
}
