using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseText : MonoBehaviour
{
    public GameObject chaseText;
    public GameObject otherText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            chaseText.SetActive(true);
            otherText.SetActive(false);
            //Destroy(this.gameObject);
        }
    }
}
