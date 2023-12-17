using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    public GameObject batteryUI;
    public GameObject generatorUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            batteryUI.SetActive(true);
            generatorUI.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
