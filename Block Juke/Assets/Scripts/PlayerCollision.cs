using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   
    public Camera mainCamera;
    public PlayerPieces pieces;
    bool _collided = false;

    public PlayerMovement movementScript;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle") && !_collided)
        {
            _collided = true;

            pieces.Explode();
            
            gameObject.SetActive(false);
            
            // rotateCamera();
            
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void rotateCamera()
    {
        mainCamera.GetComponent<Animator>().enabled = true;
    }
}