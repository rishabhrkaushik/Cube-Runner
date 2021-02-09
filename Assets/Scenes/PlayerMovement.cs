using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float zForce = 2000;
    public float xForce = 1000;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Movement Start");
        // rb.useGravity = false; // Turn off gravity

    }

    // Update is called once per frame
    void FixedUpdate() // use fixed update when using physics
    {
        rb.AddForce(0, 0, zForce * Time.deltaTime); // Time.deltaTime to compensate for frame rate
        if(Input.GetKey("d"))
        {
            rb.AddForce(xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
