using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            Destroy(gameObject, .2f);
        }
    }
}

