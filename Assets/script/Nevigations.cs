using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Nevigations : MonoBehaviour
{


    private Canvas pause_menu;

    public Canvas gameover_screen;

    public static Nevigations nevigations;



    // Start is called before the first frame update
    void Start()
    {
        pause_menu=GetComponent<Canvas>();
        pause_menu.enabled=false;
    }

    public Nevigations()
    {
        nevigations=this;
    }



    // Update is called once per frame
    void Update()
    {
        
    }



    public void pause_method()
    {   
        pause_menu.enabled=true;
        Time.timeScale=0;
    }


    public void resume_method()
    {
        pause_menu.enabled=false;
        Time.timeScale=1;
    }


    public void restart_method()
    {
        pause_menu.enabled=false;
        Time.timeScale=1;
        SceneManager.LoadScene("main_scene");
    }


    public void main_manu_method()
    {
        SceneManager.LoadScene("main_menu");
    }


    public void start_method()
    {
        SceneManager.LoadScene("main_scene");
    }
}
