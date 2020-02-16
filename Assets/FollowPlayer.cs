using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // Update is called once per frame
    void Update()
    {       
        if (player == null) return;

        if (transform.position.z > 860) {
            transform.eulerAngles = new Vector3(
                30,
                transform.eulerAngles.y,
                transform.eulerAngles.z
            );
            transform.position = player.position + new Vector3(0, 5, -5);
        } else {
            transform.position = player.position + new Vector3(0, 1, -5);
        }
    }
}
