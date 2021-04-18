using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SocketPerform : MonoBehaviour
{
    public GameObject Tower;
    MeshRenderer mesh_tower;
    public Material right_mat;
    public Material wrong_mat;
    GameObject tower_parts;
    Socket socketscript;
    public GameObject socketlocate;

    // Start is called before the first frame update

    public void Start()
    {
        mesh_tower=Tower.GetComponent<MeshRenderer>();
        tower_parts = GameObject.FindGameObjectWithTag(Tower.name);
        socketscript = socketlocate.GetComponent<Socket>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tower.name)
        {
            mesh_tower.enabled=true;
            mesh_tower.material = right_mat;
        }
        else
        {
            mesh_tower.enabled = true;
            mesh_tower.material = wrong_mat;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        mesh_tower.enabled = false;
        
    }
    private void Update()
    {
        if (socketscript.isActive == true)
        {
            mesh_tower.enabled = false;
        }
    }
}
