using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour {
    Animator anim;
	
	void Start () {
        anim = GetComponent<Animator>();
        }
		
	void Update () {
        int changing;
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            changing = 5;
            anim.SetInteger("Change", changing);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            changing = 10;
            anim.SetInteger("Change", changing);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            changing = 15;
            anim.SetInteger("Change", changing);
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            changing = 20;
            anim.SetInteger("Change", changing);
        }


        
    }
}
