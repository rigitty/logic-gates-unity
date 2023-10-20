using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
    public GameObject go;
    private void OnMouseDown()
    {
        Instantiate(go,transform.position,Quaternion.identity);
    }
}
