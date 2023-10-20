using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public GameObject pausemenu;
    public GameObject game;
    public void restartgame()
    {
        pausemenu.SetActive(false);
        SceneManager.LoadScene("ingame");
    }
}
