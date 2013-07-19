using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour 
{
	public static bool HasFlashlight;
	
	public static float batteryLife;
	
	void Update() {
		batteryLife	= GameObject.Find( "Flashlight_Model" ).GetComponent<FlashlightToggle>().BatteryLife;
		//Debug.Log( batteryLife );
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
	}	
}
