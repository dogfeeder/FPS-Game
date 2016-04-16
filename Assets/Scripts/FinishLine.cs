using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour
{

    public GameObject winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            winText.SetActive(true);
        }
    }
}
