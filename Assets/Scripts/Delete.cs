using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Deletable"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Deletablein"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }
}
