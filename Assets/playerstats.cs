using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class playerstats : MonoBehaviour
{
    //hp and inv------------------------------------------
    public gameover gameover;
    public int hp;
    public bool isinvisible;
    public float invisibleTimer=0;
    public float flickerTimer = 0;
    public SpriteRenderer triangle;
    public Text texthp;
    public Text textinv;
    public int rng;
    //triple---------------------------------------------
    float triplecd;
    float triplecounter;
    public shoot shooter;
    bool cantriple;
    public Text triple;
    public int bulletsnb=2;
    public GameObject collectableBullet;
    //methods-------------------------------------------
    void Start()
    {
        textinv.enabled= false;
    }
    void Update()
    {
        //--------mutli bullets ui-------------------------------------------------------------
        cantriple = shooter.cantriple;
        triplecounter = shooter.triplecounter;
        triplecd = shooter.triplecd;
        if(!cantriple) { triple.text = "Multi bullets : " + ((float)Math.Round((triplecd - triplecounter), 2)).ToString(); }
        if (cantriple)
        {
            triple.text = "Multi bullets : Ready";
        }
        //------hp ui------------------------------------------------------------------
        texthp.text = "HP : " +hp.ToString();
        if(hp <= 0)
        {
            SceneManager.LoadScene("game over");
        }
        if (isinvisible)
        {
            flicker();
            invisibleTimer += Time.deltaTime;
            textinv.enabled = true;
            textinv.text = "Invisible : " + ((float) Math.Round((1 - invisibleTimer), 2)).ToString();
            if (invisibleTimer >= 1f)
            {
                isinvisible = false;
                triangle.enabled = true;    
                invisibleTimer = 0;
                textinv.enabled= false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacle" && !isinvisible)
        {
            hp -= 10;
            isinvisible = true;
        }
    }
    void flicker()
    {
        flickerTimer += Time.deltaTime;
        if(flickerTimer >=0.05f) {
            triangle.enabled = !triangle.enabled;
            flickerTimer = 0;
        }
    }
}
