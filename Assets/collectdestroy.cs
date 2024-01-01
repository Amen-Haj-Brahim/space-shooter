using UnityEngine;
public class collectdestroy : MonoBehaviour
{
    public GameObject collectableBullet;
    void Update()
    {
        Destroy(gameObject,3);
    }
}
