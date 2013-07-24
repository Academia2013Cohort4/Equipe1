using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public bool haskey = false;	
	public GameObject player;
	
	public static bool HasFlashlight;
	
	public static float batteryLife;
	
	//private float staminaAmount;
	
	void Update() {
		batteryLife	= player.GetComponent<FlashlightToggle>().BatteryLife;
//		Debug.Log( batteryLife );
		
		//staminaAmount = GameObject.FindGameObjectWithTag("Player").GetComponent<RunForestRun>();
	}
	
	void OnGUI()	
	{
		if(!HasFlashlight)
		{
			GUI.Label(new Rect(10,10,80,30), "Flashlight");
			//GUI.Label(new Rect(70,10,80,90), Flashlight.BatteryLife.ToString("F2"));	
		}
				
		GUI.Label(new Rect(10,40,80,30), "Battery Life");
		GUI.Label(new Rect(100,40,80,30), ((int)batteryLife).ToString() );		
		
		//GUI.Label(new Rect(190,40,80,30), "Stamina");
		//GUI.Label(new Rect(280,40,80,30), ((int)staminaAmount).ToString() );	
	}
	
}