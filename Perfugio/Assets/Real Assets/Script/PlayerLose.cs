using UnityEngine;
using System.Collections;

public class PlayerLose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter ( Collider _collider )
	{ Debug.Log("why");
    	if (_collider.tag == "Player")
    	{
        	Application.LoadLevel ("GameOver");
    	}
	}
}
