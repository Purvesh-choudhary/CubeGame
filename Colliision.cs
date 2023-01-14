using System;
using UnityEngine;

public class Colliision : MonoBehaviour
{
    public PlayerMovements movements;

    void OnCollisionEnter( Collision collisionInfo)
    {
        if (collisionInfo.collider.tag =="obstacle")
        {
            movements.enabled = false;
            FindObjectOfType<gamemanager>().EndGame();
        }
            
    }

}
