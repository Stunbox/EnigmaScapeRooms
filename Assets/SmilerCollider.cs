using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmilerCollider : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider collided)
    {
        if(collided.gameObject.tag == "Player"){
            gameManager.StartSmilerLvl();
        }
    }
}
