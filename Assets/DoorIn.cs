using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorIn : MonoBehaviour
{
    public GameObject doorOut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        GameObject player = collisionInfo.gameObject;
        player.transform.position = doorOut.transform.position;

        //Reset velocity???
    }
}
