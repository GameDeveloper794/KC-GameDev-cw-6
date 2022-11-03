using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float limits;
    public float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the player pressed  
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -1*limits)
        {
            transform.position = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
        }
       else if  (Input.GetKeyDown(KeyCode.D) && transform.position.x != limits)
        {
            transform.position = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
        }
        
    }
}
