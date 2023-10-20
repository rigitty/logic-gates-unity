using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOT : MonoBehaviour
{
    public GameObject in1;
    public GameObject[] out1;
    public GameObject onoff;
    private void Update()
    {
        isitin in1c = in1.GetComponent<isitin>();
        if (in1c != null)
        {
            if (in1.GetComponent<isitin>().input == true)
            {
                for (int i = 0; i <= 3; i++)
                {
                    out1[i].GetComponent<isiton>().turnoff();
                }
                onoff.SetActive(true);
            }
            else
            {
                for (int i = 0; i <= 3; i++)
                {
                    out1[i].GetComponent<isiton>().turnon();
                }
                onoff.SetActive(false);
            }
        }
    }
}
