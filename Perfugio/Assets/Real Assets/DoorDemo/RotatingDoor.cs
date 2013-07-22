using UnityEngine;
using System.Collections;

public class RotatingDoor : MonoBehaviour {
	
	public float moveSpeed = 1;
	
	private bool spinDoor = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( spinDoor ) {
			SpinDoor();	
		} else {
			StopDoor();
		}
	}
	
	void OnTriggerEnter( Collider collider ) {
		spinDoor = true;
		Debug.Log( "in" );
	}
	
	void OnTriggerExit( Collider collider ) {
		spinDoor = false;
	}
	
	void SpinDoor() {
		transform.Rotate( 0, 1 * moveSpeed * Time.deltaTime, 0 );
	}
	
	void StopDoor() {
		transform.rotation = Quaternion.identity;
	}
}
