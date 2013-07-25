using UnityEngine;
using System.Collections;

public class MoveClown : MonoBehaviour {
	public float minSpeed = 4;
	public float maxSpeed = 7;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.forward * Time.deltaTime * Random.Range(minSpeed, maxSpeed));
	}
}
