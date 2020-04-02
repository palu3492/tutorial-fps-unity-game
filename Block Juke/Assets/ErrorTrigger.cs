using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTrigger : MonoBehaviour
{
    public GameManager gameManger;
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.name == "PlayerCube")
        {
            gameManger.Crash();
        }
    }
}
