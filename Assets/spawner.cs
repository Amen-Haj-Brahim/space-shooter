using UnityEngine;
public class spawner : MonoBehaviour
{
    float nextspawntime;
    public float spawnCD;
    public GameObject rock;
    public Transform[] spawnpoints;
    Transform randompoint;
    void Update()
    {
        if (Time.time>nextspawntime) 
        {
            nextspawntime = Time.time+spawnCD;
            randompoint = spawnpoints[Random.Range(0, spawnpoints.Length)];
            Instantiate(rock,randompoint.position,Quaternion.identity);
        }
    }
}
