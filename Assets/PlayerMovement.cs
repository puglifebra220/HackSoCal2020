
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb" 
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private float maxVelocity = 16f;
    private float maxVelocityWhenInSpeedZone = 25f;
    private float newForwardForce = 10000;
    

    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    // We marked this as "Fixed"Update because we 
    //are using it to mess with physics 
    void FixedUpdate()
    {
        // Add a forward force
        if (rb.velocity.magnitude <= maxVelocity) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        }
       
   
    if (Input.GetKey("d"))
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
    }
   
    if (Input.GetKey("a"))
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }

    void OnTriggerEnter(Collider collider) {
        Debug.Log("Trigger");
        if (collider.gameObject.tag == "SpeedUp") {
            maxVelocity = maxVelocityWhenInSpeedZone;
            forwardForce = newForwardForce;
        }
    }

    void OnTriggerExit(Collider collider) {
        Debug.Log("Trigger");
        if (collider.gameObject.tag == "SpeedUp") {
            maxVelocity = 16f;
            forwardForce = 2000;
        }
    }
}
