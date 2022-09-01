using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int wallPoints = 0;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        //scoreManager.UpdateScore(5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Slam Ball")
        {
            scoreManager.UpdateScore(wallPoints);
            Destroy(collision.gameObject);
        }
        
    }
}
   