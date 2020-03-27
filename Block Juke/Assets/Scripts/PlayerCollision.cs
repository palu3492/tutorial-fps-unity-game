using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Material shader;
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;
    public int collisionForce = 1000;
    public float pieceMass = 50;
    public Camera mainCamera;

    public PlayerMovement movementScript;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movementScript.enabled = false;
            explode();
            // rotateCamera();
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void rotateCamera()
    {
        mainCamera.GetComponent<Animator>().enabled = true;
    }

    void explode()
    {
        gameObject.SetActive(false);
        // loop 3 times to create 5x5x5 pieces in x,y,z coordinates
        //createPiece(0, 0, 0);
        for (int x = 0; x < cubesInRow; x++) {
            for (int y = 0; y < cubesInRow; y++) {
                for (int z = 0; z < cubesInRow; z++) {
                    createPiece(x, y, z);
                }
            }
        }
    }

    private void createPiece(int x, int y, int z)
    {
        // Create piece;
        var piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // position of back bottom left
        piece.transform.position = transform.position - new Vector3(0.4f, 0.4f, 0.4f) + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z);
        float cubeSizeTemp = cubeSize - 0.02f;
        piece.transform.localScale = new Vector3(cubeSizeTemp, cubeSizeTemp, cubeSizeTemp);
        
        // Add rigid body and set mass
        piece.AddComponent<Rigidbody>();
        // piece.GetComponent<Rigidbody>().useGravity = false;
        piece.GetComponent<Rigidbody>().mass = pieceMass;
        piece.GetComponent<Rigidbody>().AddForce(0, 0, collisionForce * Time.deltaTime, ForceMode.VelocityChange);
        piece.GetComponent<Renderer>().material = shader;
    }
}