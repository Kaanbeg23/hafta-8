using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject kapi;
    int sayac;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="goldcoin")
        {
            Destroy(other.gameObject);            
            sayac++;
        }        
        if (sayac==3)
        {
            Destroy(kapi);
        }
    }
}
