using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject kapi;
    int sayac;
    public AudioClip[] coin;
    public AudioSource audio;
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="goldcoin")
        {
            Destroy(other.gameObject);            
            sayac++;
            audio.PlayOneShot(coin[Random.Range(0, coin.Length)]);
        }       
        if (sayac==3)
        {
            Destroy(kapi);
        }
    }
}
