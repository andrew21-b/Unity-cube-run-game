using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl5PlayerCollision : MonoBehaviour
{
    public NewPlayerMovementlvl5 movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
