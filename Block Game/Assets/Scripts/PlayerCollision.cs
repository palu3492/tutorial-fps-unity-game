using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Material shader;
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    public PlayerMovement movementScript;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movementScript.enabled = false;
            explode();
        }
    }

    private void explode()
    {
        gameObject.SetActive(false);
        // loop 3 times to create 5x5x5 pieces in x,y,z coordinates
        int total = 0;
        for (int x = 0; x < cubesInRow; x++) {
            for (int y = 0; y < cubesInRow; y++) {
                for (int z = 0; z < cubesInRow; z++) {
                    createPiece(x, y, z);
                    total++;
                    Debug.Log(total);
                }
            }
        }
    }

    private void createPiece(int x, int y, int z)
    {
        // Create piece;
        var piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        piece.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z);
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
        
        // Add rigid body and set mass
        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize;
        piece.GetComponent<Rigidbody>().AddForce(0, 0, 1000);
        piece.GetComponent<Renderer>().material = shader;
    }
}