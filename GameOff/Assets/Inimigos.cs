using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Inimigos : MonoBehaviour
{
    public GameObject personagem;
    public Transform posicaopersonagem;
    public  static GameObject inimigo;
    public NavMeshAgent ai_npc;
    public Animator animador;
    public GameObject particula;

    // Use this for initialization
    void Start()
    {
        inimigo = gameObject;
        animador = gameObject.GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        float dist2 = Vector3.Distance(posicaopersonagem.position, transform.position);
       
        if (dist2 <= 6)
        {
            ai_npc.GetComponent<NavMeshAgent>().enabled = true;
            ai_npc.destination = posicaopersonagem.position;
            animador.SetInteger("parado", 1);

        }
        if (dist2 >= 6) 
        {
            ai_npc.GetComponent<NavMeshAgent>().enabled = false;
            animador.SetInteger("parado", 0);
            

        }
   
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }

    }

}
