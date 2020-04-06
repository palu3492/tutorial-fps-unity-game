using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManger;
    public PlayerMovement PlayerMovement;
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.name == "PlayerCube")
        {
            PlayerMovement.enabled = false;
            gameManger.CompleteLevel();
        }
    }
}
