using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParticleController : MonoBehaviour
{
       public ParticleSystem particle;

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        particle.Play();
        
        if (other.tag == this.name)
        {
            Debug.Log("enter");
            particle.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        particle.Stop();
        Debug.Log("out");
    }
}
