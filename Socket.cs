using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket : MonoBehaviour
{
    XRSocketInteractor socket;
    public bool isActive;
    GameObject col_Tower;
    SocketPerform socketperform;

    public void OnTriggerEnter(Collider other)
    {
        col_Tower = other.gameObject;
        if (other.tag == this.name)
        {
            socket.socketActive = true;
            isActive = true;
        }
        else
        {
            StartCoroutine(CountTime());
            socket.socketActive = false;
        }
    }
   
    // Start is called before the first frame update
    void Start()
    {
        socket = this.GetComponent<XRSocketInteractor>();
    }
    IEnumerator CountTime()
    {
        yield return new WaitForSeconds(3f);
        
    }
    // Update is called once per frame
    private void Update()
    {
        if (isActive == true)
        {
            StartCoroutine(CountTime());
            col_Tower.layer = 2;       
            col_Tower.GetComponent<OVRGrabbable>().enabled = false;
        }
    }
}
