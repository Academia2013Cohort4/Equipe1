using UnityEngine;
using System.Collections;

public class Elev : MonoBehaviour {
	
	public GameObject gameManager;	
	
	public GUIText helpText;
		
	 
    void OnTriggerStay(Collider _collider) {
		if (_collider.tag == "Player") {
	
			    	helpText.text = "Press 'E' to use";
			
			if (Input.GetKey(KeyCode.E)) { Debug.Log(gameManager.GetComponent<HUD>().haskey);
				if (gameManager.GetComponent<HUD>().haskey==true) {
						
			    	Application.LoadLevel("lvl 2");
			 			
						
		    	}else{
						Debug.Log("in3");
			        helpText.text = "You need a key";
						
						
					
					
	
				}
			}
		}
	}
	void OnTriggerExit(){
		helpText.text = "";
	}
}