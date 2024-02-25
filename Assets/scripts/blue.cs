using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    public GameObject kapi;
    public AudioClip[] coin;
    public AudioSource audio;
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="bluecoin")
        {
            Destroy(other.gameObject);
            Destroy(kapi);
            audio.PlayOneShot(coin[Random.Range(0, coin.Length)]);
        }              
    }
}
