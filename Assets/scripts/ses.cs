using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public AudioSource source;
    public AudioClip coin;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "goldcoin")
        {
            source.PlayOneShot(coin);
        }
    }
}
