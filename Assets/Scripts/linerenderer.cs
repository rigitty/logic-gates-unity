using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linerenderer : MonoBehaviour
{
    public GameObject[] plugouts;
    public GameObject plugin;
    public LineRenderer[] line;
    public LineRenderer[] greenline;

    private void Update()
    {
        for(int i=0; i <= 3; i++)
        {
            if (plugouts[i].GetComponent<isiton>().getto() == false)
            {
                line[i].SetPosition(0, plugin.transform.position);
                line[i].SetPosition(1, plugouts[i].transform.position);
                greenline[i].SetPosition(0, plugin.transform.position);
                greenline[i].SetPosition(1, plugin.transform.position);
            }
            else 
            {
                line[i].SetPosition(0, plugin.transform.position);
                line[i].SetPosition(1, plugin.transform.position);
                greenline[i].SetPosition(0, plugin.transform.position);
                greenline[i].SetPosition(1, plugouts[i].transform.position);
            }
        }
    }
}
