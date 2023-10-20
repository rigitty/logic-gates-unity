using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public void Play_btn()
    {
        SceneManager.LoadScene("ingame");
    }
    public void exitbtn()
    {
        Application.Quit();
    }
}
