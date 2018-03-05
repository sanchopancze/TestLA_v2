using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sw_on : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ParticleSystem>().Play();
    }
}
