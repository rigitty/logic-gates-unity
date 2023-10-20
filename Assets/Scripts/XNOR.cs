using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XNOR : MonoBehaviour
{
    public GameObject in1, in2;
    public GameObject[] out1;
    public GameObject onoff;
    private void Update()
    {
        isitin in1c = in1.GetComponent<isitin>();
        isitin in2c = in2.GetComponent<isitin>();
        if (in1c != null && in2c != null)
        {
            if (in1.GetComponent<isitin>().input == true && in2.GetComponent<isitin>().input == false)
            {
                for (int i = 0; i <= 3; i++)
                {
                    out1[i].GetComponent<isiton>().turnoff();
                }
                onoff.SetActive(true);
            }
            else if (in1.GetComponent<isitin>().input == false && in2.GetComponent<isitin>().input == true)
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
