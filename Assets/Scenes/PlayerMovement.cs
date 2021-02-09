using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Movement Start");
        // rb.useGravity = false; // Turn off gravity
    }

    // Update is called once per frame
    void FixedUpdate() // use fixed update when using physics
    {
        rb.AddForce(0, 0, 500 * Time.deltaTime); // Time.deltaTime to compensate for frame rate
    }
}
