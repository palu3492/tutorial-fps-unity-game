using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.transform.name);
        if (other.transform.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
