using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausemenu;
    private bool ispaused;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!ispaused)
            {
                pausemenu.SetActive(true);
                ispaused = true;
            }
            else
            {
                pausemenu.SetActive(false);
                ispaused = false;
            }
        }
    }
}
