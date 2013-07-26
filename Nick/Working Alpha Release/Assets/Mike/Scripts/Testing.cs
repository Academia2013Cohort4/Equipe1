using UnityEngine;
using System.Collections;

public class Testing : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter( Collider _collider ) { Debug.Log("here");
		if( _collider.tag == "Clown" ) {				
			Destroy(_collider);
			
			/*GameObject clown = gm.GetComponent<GameSettings>().clown;
			int clownAmount  = gm.GetComponent<GameSettings>().clownAmount;*/
			//gm.GetComponent<GameSettings>().SpawnClown();
			
		}
	}
}
