using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Transform player_transform;
    public float speed=3,rotation_speed=35;

    bool left_btn_pressed=false,right_btn_pressed=false;


    public GameObject[] player=new GameObject[26];

    private GameObject go;
    
    
    

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(player[PlayerPrefs.GetInt("car_index")].gameObject.name+" spawn succesfully");
        go=Instantiate(player[PlayerPrefs.GetInt("car_index")],transform.position,quaternion.identity);
        
        




        player_transform=go.transform;
        Nevigations.nevigations.gameover_screen.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) || right_btn_pressed)
        {
            player_transform.position += new Vector3(speed*Time.deltaTime,0,0);
            //player_transform.eulerAngles = new Vector3(0,0,335);
            player_transform.rotation = Quaternion.Lerp(player_transform.rotation,Quaternion.Euler(0,0,-14),rotation_speed*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.LeftArrow) || left_btn_pressed)
        {
            player_transform.position -= new Vector3(speed*Time.deltaTime,0,0);
            //player_transform.eulerAngles =new Vector3(0,0,25);
            player_transform.rotation = Quaternion.Lerp(player_transform.rotation,Quaternion.Euler(0,0,14),rotation_speed*Time.deltaTime);
        }



        // if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        // {
        //     player_transform.eulerAngles =new Vector3(0,0,0);
        // }



        if(!(right_btn_pressed || left_btn_pressed))
        {
            player_transform.eulerAngles =new Vector3(0,0,0);
        }


        


        Vector3 a=player_transform.position;
        a.x=Mathf.Clamp(a.x,-2.27f,2.22f);
        player_transform.position=a;

        // if(player_transform.position.x < -2.27)
        // {
        //     player_transform.position = new Vector3(-2.27f,player_transform.position.y,player_transform.position.z);
        // }
        // else if(player_transform.position.x > 2.22)
        // {
        //     player_transform.position = new Vector3(2.22f,player_transform.position.y,player_transform.position.z);
        // }



    }


    


    public void if_left_buttton_pressed()
    {
        left_btn_pressed=true;
    }



    public void if_right_buttton_pressed()
    {
        right_btn_pressed=true;
    }


    public void if_left_buttton_up()
    {
        left_btn_pressed=false;
    }    



    public void if_right_buttton_up()
    {
        right_btn_pressed=false;
    }



    
}

