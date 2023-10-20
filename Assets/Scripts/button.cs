using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class button : MonoBehaviour
{
    public AudioClip click;
    public GameObject box;
    public bool turnon=false;
    public GameObject[] plugouts;
    public GameObject onoff;
    private void OnMouseDown()
    {
            if (!turnon)
            {
                Camera.main.GetComponent<AudioSource>().PlayOneShot(click);
                turnon = true;
                for(int i = 0; i <= 3; i++)
            {
                plugouts[i].GetComponent<isiton>().turnon();
            }
            onoff.SetActive(false);
            }
            else
            {
                Camera.main.GetComponent<AudioSource>().PlayOneShot(click);
                turnon = false;
            for (int i = 0; i <= 3; i++)
            {
                plugouts[i].GetComponent<isiton>().turnoff();
            }
            onoff.SetActive(true);
        }
       
    }
}
