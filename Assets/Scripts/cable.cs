using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cable : MonoBehaviour
{
    public GameObject plugbehind;
    public GameObject plugfront;
    private LineRenderer line;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        line.SetPosition(0, plugbehind.transform.position);
        line.SetPosition(1, plugfront.transform.position);
    }
}
