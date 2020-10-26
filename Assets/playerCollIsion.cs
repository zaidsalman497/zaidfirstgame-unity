using UnityEngine;

public class PlayerCollIsion : MonoBehaviour
{

    public PlayerMovement2 movement;
    public GameManager3 GameManagers;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
