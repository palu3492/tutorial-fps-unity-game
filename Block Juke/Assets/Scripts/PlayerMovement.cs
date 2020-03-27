using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 10f;

    // Start is called before the first frame update

    // Update is called once per frame
    // Unity prefers FixedUpdate to Update when working with physics?
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce  * Time.deltaTime); // Move cube forward
        
        // Add drag to sideways movement
        Vector3 velocity = rb.velocity;
        velocity.x *= 0.85f;
        rb.velocity = velocity;
        
        // Checking for input should be done in Update()
        // Move cube side to side
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("space") && rb.position.y <= 1.1f)
        {
            rb.AddForce(0, upwardForce, 0);
        }
        
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}