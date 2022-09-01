using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoachController : MonoBehaviour
{
    // Variable Declaration


    public GameObject slamBall; //weighted ball to be spawned
    public Transform spawnPoint; //point where the slam balls will spawn

    public float forwardMovement = 210.0f;
    public float height = 310.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ProjectileMovement", 1.0f, 1.5f);
    }

    void ProjectileMovement()
    {
        GameObject spawnedSlamBall = Instantiate(slamBall, spawnPoint.position, spawnPoint.rotation);
        spawnedSlamBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, height, forwardMovement));
        spawnedSlamBall.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();  
    }

    
}
