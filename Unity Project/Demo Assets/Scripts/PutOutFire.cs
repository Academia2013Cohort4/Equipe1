using UnityEngine;
using System.Collections;

public class PutOutFire : MonoBehaviour {

	void OnTriggerEnter( Collider collider ) {		
		Destroy( gameObject );

	}
}

