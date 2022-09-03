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

    public TextMeshProUGUI prompt;
    public int turn;
    public string[] whichSide = { "Left", "Right" };
    public string wallTurn;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("TurnPrompt");
        InvokeRepeating("ProjectileMovement", 1.0f, 1.5f);
        
    }

    void ProjectileMovement()
    {
        StartCoroutine("TurnPrompt");
        GameObject spawnedSlamBall = Instantiate(slamBall, spawnPoint.position, spawnPoint.rotation);
        spawnedSlamBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, height, forwardMovement));
        spawnedSlamBall.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        
    }

    IEnumerator TurnPrompt()
    {
        yield return new WaitForSeconds(1.0f);

        while (true)
        {
            yield return new WaitForSeconds(1.5f);

            turn = Random.Range(0, 2);
            wallTurn = whichSide[turn];

            prompt.text = "Throw: " + wallTurn;

            
        }

    } 
}
