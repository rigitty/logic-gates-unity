using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isiton : MonoBehaviour
{
    public bool to;
    public void turnon()
    {
        to = true;
}
    public void turnoff()
    {
        to = false;
    }
    public bool getto()
    {
        return to;
    }
}
