using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_menu_nevigations : MonoBehaviour
{

    private Canvas main_menu_canvas;
    public Canvas choose_car_canvas;
    public UnityEngine.UI.Image preview;

    public Sprite[] sprites=new Sprite[26];
    




    // Start is called before the first frame update
    void Start()
    {
        
        main_menu_canvas=GetComponent<Canvas>();
        choose_car_canvas.enabled=false;
        preview.sprite=sprites[PlayerPrefs.GetInt("car_index")];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void start_method()
    {
        SceneManager.LoadScene("main_scene");
        Time.timeScale=1;
    }



    public void choose_car()
    {
        main_menu_canvas.enabled=false;
        choose_car_canvas.enabled=true;
    }


    public void selected_car(int car_index)
    {
        PlayerPrefs.SetInt("car_index",car_index);
        preview.sprite=sprites[PlayerPrefs.GetInt("car_index")];
    }





}
