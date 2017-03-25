using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public float speed = 10f;
 
    Vector2 can;

	void Start () {
        
	}
	
	
	void Update () {

        transform.Translate(speed * Time.deltaTime/3, 0, 0);
        can.x = transform.position.x;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            can.y = transform.position.y;
            can.y += 3;
            transform.position = can;
            can.x = transform.position.x;
            can.x += 1;
            transform.position = can;
        }


	}

    
}
