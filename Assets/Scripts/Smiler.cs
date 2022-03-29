using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Smiler : MonoBehaviour
{
    public string howHeKillYou = "El smiler te ha estrangulado";
    public Transform startPos;
    public Transform target; 
    NavMeshAgent nav; 
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.position);
    }
}
