using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineCollision : MonoBehaviour
{
    bool collided = false;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "PlayerCube" && !collided)
        {
            AddRigidBodyToBlocks();
        }
    }
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.name == "PlayerCube" && !collided)
        {
            Debug.Log("COLLIDER");
            AddRigidBodyToBlocks();
        }
    }

    private void AddRigidBodyToBlocks()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("FinishLineBlocks");
        foreach(GameObject block in blocks)
        {
            block.AddComponent<Rigidbody>();
            block.AddComponent<BoxCollider>();
        }
    }
}
