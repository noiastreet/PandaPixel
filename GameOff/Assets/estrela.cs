using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class estrela : MonoBehaviour
{
  
    public Transform posicaopersonagem;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist2 = Vector3.Distance(posicaopersonagem.position, transform.position);

        if (dist2 <= 1)
        {
            Destroy(gameObject);
            Jogador.vitoria = Jogador.vitoria + 1;
           
        }
      
    }

}
