using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody rigidbody;
    public AudioManager audioManager;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rigidbody.velocity.magnitude > maxSpeed)
        {
            rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //jika menabarak tembok
        if (collision.gameObject.tag == "Wall")
        {
            //jika tabrakan bola ke tembok kuat, suara besar
            if (Math.Abs(collision.impulse.z) >= maxSpeed/1.5f || Math.Abs(collision.impulse.x) >= maxSpeed / 1.5f)
            {
                audioManager.PlayHighSound(collision.transform.position);
            }
            //jika tabrakan bola ke tembok sedang, suara sedang
            else if (Math.Abs(collision.impulse.z) <= maxSpeed/1.5 && Math.Abs(collision.impulse.z) >= maxSpeed/4 || Math.Abs(collision.impulse.x) <= maxSpeed / 1.5 && Math.Abs(collision.impulse.x) >= maxSpeed / 4)
            {
                audioManager.PlayMidSound(collision.transform.position);
            }
            //jika tabrakan bola ke tembok kecil, suara kecil
            else if (Math.Abs(collision.impulse.z) <= maxSpeed/4 && Math.Abs(collision.impulse.z) >= 1.2f || Math.Abs(collision.impulse.x) <= maxSpeed / 4 && Math.Abs(collision.impulse.x) >= 1.2f)
            {
                audioManager.PlayLowSound(collision.transform.position);
            }
            else //jika tabrakan bola ke tembok sangat kecil atau hanya bersentuan tidak ada suara
            {
                //No Sound
            }
            //Debug.Log(collision.impulse);
        }
        
    }
}
