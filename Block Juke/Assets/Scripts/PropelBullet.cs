using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelBullet : MonoBehaviour
{
    private float start;
    public float bulletSpeed;
    // Update is called once per frame
    private void Start()
    {
        start = Time.time;
        GetComponent<Rigidbody>().AddForce(0, 0, bulletSpeed * Time.deltaTime, ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        if (GetComponent<Rigidbody>().position.y < -1f || Time.time - start > 2)
        {
            Debug.Log("Destory");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        Destroy(gameObject);
    }
}
