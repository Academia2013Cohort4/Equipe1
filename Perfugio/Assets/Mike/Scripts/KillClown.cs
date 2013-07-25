using UnityEngine;
using System.Collections;

public class KillClown : MonoBehaviour {
	private GameObject gm;
	
	void Awake() {
		gm = GameObject.Find("*GM");
	}
	
	void OnTriggerEnter( Collider _collider ) { 
		if( _collider.tag == "Clown" ) {			
			Destroy(_collider.gameObject);
			
			/*GameObject clown = gm.GetComponent<GameSettings>().clown;
			int clownAmount  = gm.GetComponent<GameSettings>().clownAmount;*/
			gm.GetComponent<GameSettings>().SpawnClown();
			
		}
	}
}
