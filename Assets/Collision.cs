using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collision : MonoBehaviour {
  
	public bool flag;
        public GUISkin message;

	void Start () 
	{
		
        flag = false;
		
	}
	
        void OnCollisionEnter2D(Collision2D collision)
        {
		
        flag = true;
		
	}

	void OnGUI()  
	{
        if (flag == true) 
	{
            GUI.skin = message;
		
            GUI.Label(new Rect(100, 100, 100, 100), "Collision");
		
            System.Threading.Thread.Sleep(2000);
		
            SceneManager.LoadScene(1);
        }
     }    
}
