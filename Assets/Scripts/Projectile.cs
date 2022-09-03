using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{
    private int counter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor" || collision.gameObject.tag == "Back Wall")
        {
            counter++;
            Destroy(gameObject, .2f);

            if (counter == 3)
            {
                //GameOver
            }
        }
    }
}

