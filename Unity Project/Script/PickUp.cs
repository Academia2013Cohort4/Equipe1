using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
	public enum Item 
	{ 
		Flashlight,
		Battery
	}
	
	public Item item;
	
	void OnTriggerEnter()
	{
		if (item == Item.Flashlight)
		{
			HUD.HasFlashlight = true;
		}
		else
			HUD.batteryLife++;
		
      	Destroy (gameObject);
	}	
}
