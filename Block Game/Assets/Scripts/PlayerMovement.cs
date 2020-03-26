using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        // rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    // Unity prefers FixedUpdate to Update when working with physics?
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce  * Time.deltaTime); // Move cube forward
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
    }
}