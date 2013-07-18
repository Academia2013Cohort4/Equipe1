using UnityEngine;
using System.Collections;

public class FlashlightToggle : MonoBehaviour 
{
	public float BatteryLife = 100;
	
	public float batteryGiveBack = 3.0f;
	
	private GameObject HeadLight;
	public float BatteryReductionSpeed = 3.0f;
	
	void Start()
	{
		HeadLight = GameObject.FindWithTag( "Flashlight Light" );
		HeadLight.active = false;
	}
	
	void Update()
	{
		if( BatteryLife >= 100 ) {
				BatteryLife = 100;
		}
		
		if(HeadLight.active)
		{
			BatteryLife -= BatteryReductionSpeed * Time.deltaTime;
			HeadLight.light.intensity -= ( BatteryReductionSpeed * Time.deltaTime )/100;
			Debug.Log(BatteryLife);
		}
		
		if (Input.GetKeyDown(KeyCode.F) /*&& HUD.HasFlashlight*/ && !HeadLight.active)
		{ Debug.Log( "in" );
			
			HeadLight.active = true;
		}
		else if(Input.GetKeyDown(KeyCode.F) /*&& HUD.HasFlashlight*/ && HeadLight.active)
		{
			HeadLight.active = false;
		}
		else if(Input.GetKeyDown(KeyCode.R))
		{
			if( BatteryLife >= 100 ) {
				BatteryLife = 100;
				HeadLight.light.intensity = 1;
			} else {
				BatteryLife += batteryGiveBack;	
				HeadLight.light.intensity += ( BatteryReductionSpeed * Time.deltaTime );
			}
		}
		
		if(BatteryLife <= 0)
		{
			BatteryLife = 0;
			HeadLight.active = false;
		}
     }
}	
		
	