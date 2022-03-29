using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject uIMenu;
    public GameObject uIDiePanel;
    public TMP_Text dieReasonTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickPlay(){
        uIMenu.SetActive(false);
        gameManager.StartGame();
    }
    public void activeDiePanel(string reason){
        dieReasonTxt.text = reason;
        uIDiePanel.SetActive(true);
    }
}
