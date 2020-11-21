using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject winscreen;
    
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            winscreen.SetActive(true);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.name == "PlayerCube")
        {
            winscreen.SetActive(true);
        }
        
    }
}
