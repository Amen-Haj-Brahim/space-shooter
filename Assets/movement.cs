using UnityEngine;
using System;
using Unity.VisualScripting;
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
        Vector3 mousePos=Input.mousePosition;
        mousePos=Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 dir=new Vector2(mousePos.x-transform.position.x, mousePos.y-transform.position.y);
        transform.up = dir;
        movedirX = Input.GetAxisRaw("Horizontal");
        movedirY = Input.GetAxisRaw("Vertical");
        rb.velocity=new Vector2(movedirX, movedirY).normalized*movespeed;
    }
}
