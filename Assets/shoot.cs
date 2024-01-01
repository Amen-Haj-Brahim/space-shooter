using Unity.Mathematics;
using UnityEngine;
public class shoot : MonoBehaviour
{
    public Transform canon,canon2,canon3;
    float counter;
    public float shootcd;
    public GameObject bullet;
    bool canshoot;
    quaternion c2, c3;
    //---multi bullets
    int bulletsnb;
    public float triplecd;
    public float triplecounter;
    public bool cantriple;
    public playerstats stats;
    void Start()
    {
        triplecounter = triplecd-0.5f;
    }
    void Update()
    {
        //---------single bullets
        counter += Time.deltaTime;
        canshoot = counter >= shootcd;
        if (Input.GetKey(KeyCode.Mouse0)&&canshoot)
        {
            Instantiate(bullet, canon.transform.position, transform.rotation);
            counter = 0;
        }
        //----------triple
        triplecounter += Time.deltaTime;
        cantriple = triplecounter >= triplecd;
        if (Input.GetKeyDown(KeyCode.Mouse1) && cantriple)
        {
            Instantiate(bullet, canon.transform.position, transform.rotation);
            for (global::System.Int32 i = 1; i < stats.bulletsnb; i++)
            {
                Instantiate(bullet, canon2.transform.position, transform.rotation * Quaternion.Euler(0, 0, 10*i));
                Instantiate(bullet, canon2.transform.position, transform.rotation * Quaternion.Euler(0, 0, -10 * i));
            }
            triplecounter = 0;
        }
        }
    }
