using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	public GUIText helpText;
	public GameObject gameManager;

    void OnTriggerStay(Collider _collider) {
		if (_collider.tag == "Player") {
			helpText.text = "Press 'E' to pick up key";
			
			if (Input.GetKey(KeyCode.E)) {
    			helpText.text = "";
				
				Destroy(gameObject);
				
				gameManager.GetComponent<HUD>().haskey=true;
			}
		}
	}
	
	void OnTriggerExit(){
		helpText.text = "";
	}
}