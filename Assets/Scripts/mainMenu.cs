using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    private SFXManager2 sfxMan;

    // Use this for initialization
    void Start()
    {
        sfxMan = FindObjectOfType<SFXManager2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void jogar()
    {
        Debug.Log("jogar");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        sfxMan.readySound.Play();

    }

    public void jogarControles()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        sfxMan.readySound.Play();

    }
 
    public void jogarNovamente()
    {
        SceneManager.LoadScene("principal 1");
        sfxMan.readySound.Play();

    }




    public void créditos()
    {
        Debug.Log("creditos");
        SceneManager.LoadScene("créditos");
        sfxMan.selectSound.Play();

    }


    public void sair()
    {
        Debug.Log("sair");
        Application.Quit();
        sfxMan.selectSound.Play();

    }



}
