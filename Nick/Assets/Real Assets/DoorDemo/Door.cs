using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public float moveSpeed = 1;
	public float maxDoorYPosition = 2;
	public float minDoorYPosition = 0;
	
	private bool openDoor = false;
	
	// Update is called once per frame
	void Update () {
		if( openDoor ) {
			OpenDoor();	
		} else {
			CloseDoor();	
		}
	}
	
	void OnTriggerStay( Collider other ) {
        openDoor = true;
    }
	
	void OnTriggerExit( Collider other ) {
        openDoor = false;
    }
	
	void OpenDoor() {
		if( transform.position.y < maxDoorYPosition ) {
			transform.Translate( 0, 1 * moveSpeed * Time.deltaTime, 0 );
		} else {
			transform.position.Set( transform.position.x, maxDoorYPosition, transform.position.z );
		}
	}
	
	void CloseDoor() {
		if( transform.position.y > minDoorYPosition ) {
			transform.Translate( 0, -1 * moveSpeed * Time.deltaTime, 0 );
		} else {
			transform.position.Set( transform.position.x, minDoorYPosition, transform.position.y );
		}
	}
}
