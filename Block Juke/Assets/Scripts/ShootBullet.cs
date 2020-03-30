using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    public GameObject bullet;
    public GameObject bullets;

    public float bulletSpeed;
    
    private int frames = 0;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("space") && frames > 20)
        {
            GameObject clone = Instantiate(bullet, bullets.transform, true);
            clone.SetActive(true);
            frames = 0;
        }
        frames++;
    }
}
