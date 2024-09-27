using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public MeshRenderer highway_renderer;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 y_offset;
        // y_offset=highway_renderer.material.mainTextureOffset;
        // y_offset.y+=Time.deltaTime*speed;
        // highway_renderer.material.mainTextureOffset=y_offset;
        highway_renderer.material.mainTextureOffset += new Vector2(0.0f,speed*Time.deltaTime);
    }
    
}
