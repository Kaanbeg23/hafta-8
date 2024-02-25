using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class topkontrol : MonoBehaviour
{
    private Rigidbody rb;
    public float hiz = 10f;
    public Text zaman, can;
    float zamansayaci = 10;
    float cansayaci = 10;
    bool durum = true;
    public GameObject CanvasObject;
    public GameObject sayaclarc;
    public GameObject kazancanvas;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (durum==true)
        {
            zamansayaci -= Time.deltaTime;
            zaman.text = (int)zamansayaci + "";
            CanvasObject.SetActive(false);
            sayaclarc.SetActive(true);
        }
        else
        {
            zamansayaci = 0;
        }
        if (zamansayaci==0)
        {
            durum = false;
            CanvasObject.SetActive(true);
            sayaclarc.SetActive(false);
        }
    }
    
    private void FixedUpdate()
    {       
        if (durum==true)
        {
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 kuvvet = new Vector3(-dikey, 0, yatay);
            rb.AddForce(kuvvet * hiz*2);            
        }
        else 
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }            
    }
    private void OnCollisionEnter(Collision col)
    {
        string objismi = col.gameObject.name;
        if (objismi.Equals("bitis"))
        {
            print("oyunu kazandýnýz");
            kazancanvas.SetActive(true);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        else if (objismi.Equals("duvar"))
        {
            cansayaci -= 1;
            can.text = cansayaci + "";
            if (cansayaci==0)
            {
                durum = false;
                CanvasObject.SetActive(true);
                sayaclarc.SetActive(true);                
            }
        }       
    }
}
