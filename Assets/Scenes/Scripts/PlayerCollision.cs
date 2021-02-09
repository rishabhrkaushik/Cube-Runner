using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.name);
        // Debug.Log(collisionInfo.collider.tag);

        if(collisionInfo.collider.tag == "obstacle")
        {
            Debug.Log("You hit Obstacle");
            // movement.enabled = false;
        }
    }
}
