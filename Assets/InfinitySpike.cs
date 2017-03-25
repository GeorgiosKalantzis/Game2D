using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitySpike : MonoBehaviour {

    public GameObject respike;
    Vector2 can;
	
    void Start ()
    {
        can.y = 2;	
    }
	
    void Update () 
    {
        can.x = transform.position.x;
	    
        can.x += 14;
	    
        transform.position = can;
	    
        Instantiate(respike, transform.position, transform.rotation);

	}
}
