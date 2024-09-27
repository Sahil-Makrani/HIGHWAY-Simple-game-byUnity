using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    Transform npc_transform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        npc_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        npc_transform.position -= new Vector3(0,speed*Time.deltaTime,0);
        if (npc_transform.position.y<-9)
        {
            Destroy(npc_transform.gameObject);
        }
    }
}
