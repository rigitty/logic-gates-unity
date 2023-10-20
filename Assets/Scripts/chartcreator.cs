using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class chartcreator : MonoBehaviour
{
    private bool ischartvisible;
    public GameObject chart;
    int count = 0;
    public GameObject duplicater;
    private string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };//26 tane
    public GameObject out1;
    public GameObject box;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            count = duplicater.GetComponent<addin>().count;
            if (!ischartvisible)
            {
                chart.SetActive(true);
                for(int i = 0; i < count;)
                {
                    Instantiate(box,out1.transform.position,Quaternion.identity);
                }
                ischartvisible = true;
            }
            else
            {
                chart.SetActive(false);
                ischartvisible = false;
            }
        }
    }
}
