using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Camera : MonoBehaviour {
	
    public float speed = 10f;
    public float time = 500;
	
    void Update () 
    {
        transform.Translate(speed * Time.deltaTime / 3, 0, 0);
	    
        time -= Time.deltaTime;
	    
        if (time <= 0)
		
        {
            SceneManager.LoadScene(1);
        }
    }
}
