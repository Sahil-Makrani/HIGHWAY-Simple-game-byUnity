using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider_detector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="npc")
        {
            Debug.Log("abe "+other.gameObject.name+" ne thok diya");
            Time.timeScale=0;
            Nevigations.nevigations.gameover_screen.enabled=true;
        }
    }
}
