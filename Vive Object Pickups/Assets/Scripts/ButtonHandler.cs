using UnityEngine;
using System.Collections;
using System;

public class ButtonHandler : MonoBehaviour {

	bool overButton;
	SteamVR_TrackedObject track;
	GameObject colliderObj;
	SteamVR_Controller.Device device;

	void Start()
	{
		Debug.Log("Button Handler Started!");
		Awake();
	}

	//Called when controller is instanititated or game starts
	void Awake() /*Using start may cause errors with the tracked object finding*/ {

		Debug.Log("Button Handler initializing...");
		overButton = false;
		track = GetComponent<SteamVR_TrackedObject>();
		foreach(Transform child in transform.parent)
		{
			if(child.name == "Sphere")
			{
				colliderObj = child.gameObject;
				Debug.Log("Collider Object found!");
			}
		}

	}
	
	//Called every tick
	void FixedUpdate() {

		device = SteamVR_Controller.Input((int)track.index);
		handleControllerInput(device);
		overButton = colliderObj.GetComponent<ButtonColliderHandler>().colliding;

	}

	//Calls appropriate method from an action on the controller, called once per tick
	void handleControllerInput(SteamVR_Controller.Device source)
	{
		if (source.GetTouch(SteamVR_Controller.ButtonMask.Trigger)/*Don't question it just accept it*/){
			triggerIsSlightlySqueezed();
		}
		if (source.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)){
			triggerSlightlySqueezed();
		}
		if (source.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger)){
			triggerNoLongerSlightlySqueezed();
		}
		if (source.GetTouch(SteamVR_Controller.ButtonMask.Grip))
		{
			gripIsSlightlySqueezed();
		}
		if (source.GetTouchDown(SteamVR_Controller.ButtonMask.Grip))
		{
			gripSlightlySqueezed();
		}
		if (source.GetTouchUp(SteamVR_Controller.ButtonMask.Grip))
		{
			gripNoLongerSlightlySqueezed();
		}
		if (source.GetPress(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerIsSqueezed();
		}
		if (source.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerSqueezed();
		}
		if (source.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerNoLongerSqueezed();
		}
		if (source.GetPress(SteamVR_Controller.ButtonMask.Grip))
		{
			gripIsSqueezed();
		}
		if (source.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
		{
			gripSqueezed();
		}
		if (source.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
		{
			gripNoLongerSqueezed();
		}
		if (source.GetPress(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonIsPressed();
		}
		if (source.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonPressed();
		}
		if (source.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonNoLongerPressed();
		}
		if (source.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadIsPressed();
		}
		if (source.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadPressed();
		}
		if (source.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadNoLongerPressed();
		}
	}

	//Called every tick the trigger is slightly down
	void triggerIsSlightlySqueezed()
	{
		
	}

	//Called when the trigger is first BEING pressed down
	void triggerSlightlySqueezed()
	{
		Debug.Log("Trigger is now slightly squeezed.");
	}

	//Called when trigger is fully released
	void triggerNoLongerSlightlySqueezed()
	{
		Debug.Log("Trigger isn't slightly squeezed.");
	}

	//Called every tick while grip is touched
	void gripIsSlightlySqueezed()
	{

	}

	//Called once grip is first touched
	void gripSlightlySqueezed()
	{
		Debug.Log("Grip Pressed");
	}

	//Called when grip is no longer touched
	void gripNoLongerSlightlySqueezed()
	{
		Debug.Log("Grip isn't slightly squeezed.");
	}

	//Called every tick while trigger is all the way down
	void triggerIsSqueezed()
	{

	}

	//Called when trigger is all the way down; If colliderObj is detecting collision when this is called, the button performs it's assigned action
	void triggerSqueezed()
	{
		Debug.Log("Trigger pressed!");
		if (overButton)
		{
			colliderObj.GetComponent<ButtonColliderHandler>().button.GetComponent<ButtonController>().performAction();
			Debug.Log("Button should have outputted message to Log.");
		}
		else
		{
			Debug.Log("Trigger was squeezed, but no button was detected!");
		}
	}

	//Called once trigger is no longer fully squeezed
	void triggerNoLongerSqueezed()
	{

	}

	//Called every tick while either grip button is pressed
	void gripIsSqueezed()
	{

	}

	//Called once a grip button is down
	void gripSqueezed()
	{

	}

	//Called when the grip button is released
	void gripNoLongerSqueezed()
	{

	}

	//Called every tick while app button is held down
	void appButtonIsPressed()
	{

	}

	//Called once app button pressed
	void appButtonPressed()
	{

	}

	//Called once app button is released
	void appButtonNoLongerPressed()
	{

	}

	//Called every tick while touchpad is being held down
	void touchpadIsPressed()
	{

	}

	//Called once touchpad is pressed
	void touchpadPressed()
	{

	}

	//Called once touchpad is released
	void touchpadNoLongerPressed()
	{

	}

}
