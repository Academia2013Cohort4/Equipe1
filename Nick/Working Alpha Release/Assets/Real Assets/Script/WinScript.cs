using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {
	
	public GameObject gameManager;	
	
	public GUIText win;
		
	 
    void OnTriggerStay(Collider _collider) {
		if (_collider.tag == "Player") {
	
			    	win.text = "Press 'E' to to enter your room";
			
			if (Input.GetKey(KeyCode.E)){
			    Application.LoadLevel("WinScene");
			}
		}
	}
	
	void OnTriggerExit(){
		win.text = "";
	}
}