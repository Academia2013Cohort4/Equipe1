using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {
	
	public GameObject _gameObject;
	
	public float moveSpeed  = 1.0f;
	public float minHeight = 0.0f; 
	public float maxHeight = 5.0f; 
	
	private bool onElevator = false;
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		if( onElevator ) {
			if( _gameObject.transform.position.y < maxHeight ) {
				_gameObject.transform.Translate( 0,moveSpeed * Time.deltaTime, 0 );	
			} else {
				_gameObject.transform.position.Set( _gameObject.transform.position.x, maxHeight, _gameObject.transform.position.z );	
			}
		} else {
			if( _gameObject.transform.position.y > minHeight ) {
				_gameObject.transform.Translate( 0, -moveSpeed * Time.deltaTime, 0 );	
			} else {
				_gameObject.transform.position.Set( _gameObject.transform.position.x, minHeight, _gameObject.transform.position.z );	
			}
		}
	}
	
	/// <summary>
	/// Raises the trigger enter event.
	/// </summary>
	/// <param name='_collider'>
	/// _collider.
	/// </param>
	void OnTriggerEnter( Collider _collider ) {
		if( _collider.collider.tag == "Player" ) {
			onElevator = true;	
		}
	}
	
	/// <summary>
	/// Raises the trigger exit event.
	/// </summary>
	/// <param name='_collider'>
	/// _collider.
	/// </param>
	void OnTriggerExit( Collider _collider ) {
		onElevator = false;
	}
}
