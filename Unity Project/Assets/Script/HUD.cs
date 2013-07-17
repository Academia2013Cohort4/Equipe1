using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour 
{
	public static bool HasFlashlight;
	
	public static float batteryLife;
	
	private float staminaAmount;
	
	void Update() {
		batteryLife	= GameObject.Find( "Flashlight_Model" ).GetComponent<FlashlightToggle>().BatteryLife;
		//Debug.Log( batteryLife );
		
		
		
		staminaAmount = GameObject.FindGameObjectWithTag("Player").GetComponent<FPSInputController>().stamina;
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
		
		GUI.Label(new Rect(190,40,80,30), "Stamina");
		GUI.Label(new Rect(280,40,80,30), ((int)staminaAmount).ToString() );	
	}
	
	// C#

public class GUITest : MonoBehaviour {

	void OnGUI () {
		// Fixed Layout
		GUI.Button (new Rect (25,25,100,30), "I am a Fixed Layout Button");

		// Automatic Layout
		GUILayout.Button ("I am an Automatic Layout Button");
	}

}
}
