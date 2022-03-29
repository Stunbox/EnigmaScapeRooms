using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uIManager;
    public GameObject cameraDead;
    public GameObject cameraMenu;
    public GameObject player;
    public Smiler smiler;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    public void StartGame(){
        cameraMenu.SetActive(false);
        player.SetActive(true);

        smiler.transform.position = smiler.startPos.position;
        smiler.gameObject.SetActive(false);

    }
    public void StartSmilerLvl(){
        smiler.target = player.transform;
        smiler.gameObject.SetActive(true);
    }
    public void EndGame(string howYouDie){
        player.SetActive(false);
        cameraDead.SetActive(true);
        uIManager.activeDiePanel(howYouDie);

    }
}
