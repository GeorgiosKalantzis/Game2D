using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inifity : MonoBehaviour {

    public GameObject regrasstop;
    Vector2 can;

	
	void Start () {

        can.y = transform.position.y;
        
}
	
	void Update () {

        can.x = transform.position.x;
        can.x += 3;
        transform.position = can;
        Instantiate(regrasstop, transform.position, transform.rotation);

    }
}
