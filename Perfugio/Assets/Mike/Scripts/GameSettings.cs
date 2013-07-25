using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {
	public Vector3 minPos;
	public Vector3 maxPos;
	
	public GameObject clown; 
	public int clownAmount = 5;
	
	// Use this for initialization
	void Start () {
		for (int count = 0; count < clownAmount; count++) {
			SpawnClown();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SpawnClown() {
		Instantiate(clown, new Vector3(Random.Range(minPos.x, maxPos.x), Random.Range(minPos.y, maxPos.y), Random.Range(minPos.z, maxPos.z)), Quaternion.Euler(0, Random.Range(0, 360), 0));
	}
		
}
