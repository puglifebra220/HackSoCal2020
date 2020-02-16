using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour{
    
    public PlayerMovement movement; 
    public GameObject explosion;
    public GameObject winExplosion;
    private bool done = false;

    void Start() {
        movement = GetComponent<PlayerMovement>();
    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        Debug.Log("Collided with " + collisionInfo.collider.tag);

        if(collisionInfo.collider.tag == "Obstacle" && !done)
        {
            //movement.enabled = false;
            Debug.Log("Game Over");
            Debug.Log(GameObject.FindWithTag("DeathImage"));
            Debug.Log(GameObject.FindWithTag("DeathImage").GetComponent<Image>());
            GameObject[] death = GameObject.FindGameObjectsWithTag("DeathImage");
            // death[0].GetComponent<Image>().enabled = true;
            death[1].GetComponent<Text>().enabled = true;
            // GameObject.FindWithTag("DeathImage").GetComponent<Image>().enabled = true;
            Destroy(this.gameObject);
            
            Instantiate(explosion,transform.position, Quaternion.identity);
            done = true;
        }

        if (collisionInfo.collider.tag == "Win"&& !done) {
            Debug.Log("Win");
            GameObject.FindWithTag("WInImage").GetComponent<Text>().enabled = true;
            Instantiate(winExplosion, transform.position, Quaternion.identity);
            done = true;
        }
    }

}
