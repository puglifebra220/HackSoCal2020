using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFollow : MonoBehaviour
{
    public Transform camera;
    public Transform ball;

    Vector3 getPosition() {
        Vector3 newPos = camera.position/5+4*ball.position/5;
        newPos.y = ball.position.y-(float)0.3;
        return newPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = getPosition();
    }
}
