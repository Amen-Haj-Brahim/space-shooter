using UnityEngine;

public class destroyObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject collectableBullet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject); 
        }
    }
}
