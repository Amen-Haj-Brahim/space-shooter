using UnityEngine;
public class rockmove : MonoBehaviour
{
    public float speed;
    Vector3 playerpos;
    Rigidbody2D rb;
    Vector3 dir;
    public playerstats playerstats;
    public GameObject collectableBullet;
    bool inv;
    void Start()
    {
        playerstats = FindObjectOfType<playerstats>();
        playerpos = FindObjectOfType<playerstats>().transform.position;
        rb = GetComponent<Rigidbody2D>();
        dir=(playerpos-transform.position).normalized;
    }
    void Update()
    {
        inv = playerstats.isinvisible;
        //transform.position = Vector2.MoveTowards(transform.position,playerpos,speed*Time.deltaTime);
        transform.position += dir * speed * Time.deltaTime;
        //transform.Translate(playerpos*speed*Time.deltaTime);
        //rb.AddRelativeForce(playerpos*Time.deltaTime*speed,ForceMode2D.Impulse);
        Destroy(gameObject,5);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player" && !inv)
        {
            int rng = UnityEngine.Random.Range(0, 2);
            if (rng == 0)
            {
                print(rng);
                playerstats.bulletsnb++;
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "bullet" || (collision.gameObject.tag=="player" && !playerstats.isinvisible))
        {
            int rng = Random.Range(0, 2);
            Debug.Log(rng);
            if (rng == 0)
            {
                Instantiate(collectableBullet, gameObject.transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
