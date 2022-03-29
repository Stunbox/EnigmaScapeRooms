using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSmilerTouchYou : MonoBehaviour
{
    public Smiler smiler;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider collided)
    {
        if(collided.gameObject.tag == "Player"){
            gameManager.EndGame(smiler.howHeKillYou);
        }
    }
}
