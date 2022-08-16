using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoachController : MonoBehaviour
{
    // Variable Declaration

    public GameObject slamBall; //weighted ball to be spawned
    public Transform spawnPoint; //point where the slam balls will spawn
    public float launchVelocity = 5.0f; // the force at which the slamBall spawns
                                    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSlamBalls()
    {
        GameObject spawnedSlamBall = Instantiate(slamBall, spawnPoint.position, spawnPoint.rotation);
        _ = spawnedSlamBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
           
    }
}
