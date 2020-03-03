using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obsticle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
