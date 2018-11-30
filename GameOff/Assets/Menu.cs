using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void iniciajogo()
    {
        SceneManager.LoadScene("Carregando");
    }
    public void creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}
