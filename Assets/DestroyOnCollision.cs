using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit Something!");
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject); 
        }
    }

}
