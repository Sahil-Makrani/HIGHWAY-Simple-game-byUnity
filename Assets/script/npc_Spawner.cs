
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class npc_Spawner : MonoBehaviour
{

    public GameObject[] npc_cars=new GameObject[26];


    // 1.79,0.6,-0.63,-1.85
    private float[] spawn_cordinets={1.79f,0.6f,-0.63f,-1.85f};
    
    List<int> temp=new List<int>(),temp_cars=new List<int>();


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn_cars());

    }

    // Update is called once per frame
    void Update()
    {

    }


    void cars_and_coordinates(int occurrance)
    {
        int coordinates;

        for (int i = 0; i < occurrance; i++)
        {
            coordinates=UnityEngine.Random.Range(0,4);

            if(temp.Contains(coordinates))
            {
                i--;
                continue;
            }
            else
            {
                temp.Add(coordinates);
                temp_cars.Add(UnityEngine.Random.Range(0,26));
            }
            
        }

        for (int i = 0; i < temp.Count; i++)
        {
            Instantiate(npc_cars[temp_cars[i]],new Vector3(spawn_cordinets[temp[i]],7,0),quaternion.identity);
        }

        temp.Clear();
        temp_cars.Clear();

        
        
    }

    IEnumerator spawn_cars()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.7f);
            int occurrence=UnityEngine.Random.Range(1,4);
            cars_and_coordinates(occurrence); 
        }
    }

}
