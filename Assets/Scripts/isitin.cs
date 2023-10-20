using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isitin : MonoBehaviour
{
    public bool input=false;
    public AudioClip sound;
    public GameObject onoff;
    private void OnTriggerEnter(Collider other)
    {
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<isiton>() != null)
        {
            if (other.GetComponent<isiton>().to == true)
            {
                input = true;
                onoff.SetActive(false);
            }
            else
            {
                input = false;
                onoff.SetActive(true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        input = false;
        onoff.SetActive(true);
    }
}
