using UnityEngine;
using System;
public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movedirX;
    public float movedirY;
    public float movespeed=20;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 aim=Input.mousePosition;
        aim=Camera.main.ScreenToWorldPoint(aim);
        Vector2 dir=new Vector2(aim.x-transform.position.x, aim.y-transform.position.y);
        transform.up = dir;
        movedirX = Input.GetAxisRaw("Horizontal");
        movedirY = Input.GetAxisRaw("Vertical");
        if (movedirX!=0&& movedirY != 0)
        {
             rb.velocity= new Vector2(movedirX, movedirY)*movespeed/(float)Math.Sqrt(2);
        }
        else
        {
            rb.velocity = new Vector2(movedirX, movedirY ) * movespeed;
        }
    }
}
