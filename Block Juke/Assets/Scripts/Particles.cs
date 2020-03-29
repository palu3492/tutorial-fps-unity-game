using UnityEngine;

public class Particles : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        Quaternion playerRotation = player.transform.localRotation;
        playerRotation.x = 0 - playerRotation.x;
        playerRotation.y = 0 - playerRotation.y;
        playerRotation.z = 0 - playerRotation.z;
        transform.localRotation = playerRotation;
    }
}
