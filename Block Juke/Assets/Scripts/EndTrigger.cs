using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManger;
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.name == "PlayerCube")
        {
            gameManger.CompleteLevel();
        }
    }
}
