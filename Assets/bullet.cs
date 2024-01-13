using UnityEngine;
using UnityEngine.UIElements;

public class bullet : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.up*speed*Time.deltaTime);
        Destroy(gameObject,2);
        
    }
}