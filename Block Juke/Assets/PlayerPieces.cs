using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPieces : MonoBehaviour
{
    public Material piecesMaterial;
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;
    public float pieceMass = 50;
    public GameObject playerCube;
    
    public void Explode()
    {

        for (int x = 0; x < cubesInRow; x++) {
            for (int y = 0; y < cubesInRow; y++) {
                for (int z = 0; z < cubesInRow; z++) {
                    CreatePiece(x, y, z);
                }
            }
        }
        
        transform.position = playerCube.transform.position;
        transform.rotation = playerCube.transform.rotation;
    }

    private void CreatePiece(int x, int y, int z)
    {
        // Create piece;
        var piece = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        // Set piece parent to pieces object
        piece.transform.parent = transform;

        // position of back bottom left
        piece.transform.localPosition = new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - new Vector3(0.4f, 0.4f, 0.4f);
        float cubeSizeTemp = cubeSize - 0.02f;
        piece.transform.localScale = new Vector3(cubeSizeTemp, cubeSizeTemp, cubeSizeTemp);
        
        // Add rigid body and set mass
        piece.AddComponent<Rigidbody>();
        // piece.GetComponent<Rigidbody>().useGravity = false;
        piece.GetComponent<Rigidbody>().mass = pieceMass;
        
        Vector3 pieceVelocity = new Vector3(0, 0, 1200 * Time.deltaTime);
        if (z < 2)
        {
            pieceVelocity.x = -300 * Time.deltaTime;
        } else if (z > 2)
        {
            pieceVelocity.x = 300 * Time.deltaTime;
        }
        
        piece.GetComponent<Rigidbody>().velocity = pieceVelocity;
        // float xVeloctiy = (Random.value - 0.5f) * 1000;
        // float yVeloctiy = (Random.value - 0.5f) * 1000;
        // piece.GetComponent<Rigidbody>().AddForce(xVeloctiy * Time.deltaTime, yVeloctiy * Time.deltaTime, collisionForce * Time.deltaTime);

        piece.GetComponent<Renderer>().material = piecesMaterial;
        
    }
}
