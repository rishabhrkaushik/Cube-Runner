using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.name);
        // Debug.Log(collisionInfo.collider.tag);

        if(collisionInfo.collider.tag == "obstacle")
        {
            Debug.Log("You hit Obstacle");
        }
    }
}
