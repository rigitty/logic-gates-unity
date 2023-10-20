using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    public Material a;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            a.color = Color.green;
        }
    }
}
