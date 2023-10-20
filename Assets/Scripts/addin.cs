using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class addin : MonoBehaviour
{
    
    private string[] alphabet= { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P","Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };//26 tane
    public GameObject inputobj;
    private TextMeshPro inputobjtext;
    public int count = 0;
    private void OnMouseDown()
    {
        if (count < 26)
        {
            inputobjtext = inputobj.GetComponentInChildren<TextMeshPro>();
            inputobjtext.SetText(alphabet[count]);
            Instantiate(inputobj,transform.position, Quaternion.identity);         
            count++;
        }
    }
}
