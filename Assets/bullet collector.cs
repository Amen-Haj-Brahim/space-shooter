using UnityEngine;

public class bulletcollector : MonoBehaviour
{
    public playerstats stats;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "collectableBullet" && stats.bulletsnb<=20)
        {   
            stats.bulletsnb++;
            Destroy(collision.gameObject);
        }
        // test hihi
    }
}
