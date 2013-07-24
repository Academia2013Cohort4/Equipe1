using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	public GUIText helpText;
 
    void OnTriggerStay(Collider _collider) {
		if (_collider.tag == "Player") {
			helpText.text = "Press 'E' to pick up key";
			
			if (Input.GetKey(KeyCode.E)) {
    			helpText.text = "";
				
				Destroy(gameObject);

				// Add key to *GM
			}
		}
	}
	
	void OnTriggerExit(){
		helpText.text = "";
	}
}