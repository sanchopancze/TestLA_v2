using System.Collections;
using UnityEngine;

public class switch_off : MonoBehaviour {

    

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ParticleSystem>().Stop();
    }
}
