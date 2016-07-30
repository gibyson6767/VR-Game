using UnityEngine;

public abstract class VRControllerInput : MonoBehaviour{

	private bool objectDefined;
	protected SteamVR_TrackedObject controllerObject;
	protected SteamVR_Controller.Device controller;

	//Use this method to set controllerObject to the component SteamVR_TrackedObject
	public abstract void setTrackedObject();

	//CONSTRUCTOR
	public VRControllerInput(){
		Debug.Log("Constructor called!");
		objectDefined = controllerObject != null; //IF SOMETHING GOES WRONG DEBUG THIS PART FIRST
		if (!objectDefined)
		{
			setTrackedObject();
			objectDefined = controllerObject != null;
		}
		else
		{
			Debug.Log("The tracked object was already defined?!");
		}
	}

	//Defines controller and sends a handling input message
	public void updateInput()
	{
		if (objectDefined)
		{
			controller = SteamVR_Controller.Input((int)controllerObject.index);
			handleInput();
		}
		else
		{
			Debug.Log("The controller was never defined?!?!");
			setTrackedObject();
            objectDefined = controllerObject != null;
        }
	}

	//Calls apropriate methods from input
	private void handleInput()
	{
		if (controller.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerIsTouched();
		}
		if (controller.GetTouch(SteamVR_Controller.ButtonMask.Grip))
		{
			gripIsTouched();
		}
		if (controller.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadIsTouched();
		}
		if (controller.GetTouch(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonIsTouched();
		}
		if (controller.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerTouchDown();
		}
		if (controller.GetTouchDown(SteamVR_Controller.ButtonMask.Grip))
		{
			gripTouchDown();
		}
		if (controller.GetTouchDown(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadTouchDown();
		}
		if (controller.GetTouchDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonTouchDown();
		}
		if (controller.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerTouchUp();
		}
		if (controller.GetTouchUp(SteamVR_Controller.ButtonMask.Grip))
		{
			gripTouchUp();
		}
		if (controller.GetTouchUp(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadTouchUp();
		}
		if (controller.GetTouchUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonTouchUp();
		}
		if (controller.GetPress(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerIsPressed();
		}
		if (controller.GetPress(SteamVR_Controller.ButtonMask.Grip))
		{
			gripIsPressed();
		}
		if (controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadIsPressed();
		}
		if (controller.GetPress(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonIsPressed();
		}
		if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerPressDown();
		}
		if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
		{
			gripPressDown();
		}
		if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadPressDown();
		}
		if (controller.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonPressDown();
		}
		if (controller.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
		{
			triggerPressUp();
		}
		if (controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
		{
			gripPressUp();
		}
		if (controller.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
		{
			touchpadPressUp();
		}
		if (controller.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
		{
			appButtonPressUp();
		}
	}

	//All button press and touch inputs for overriding
	protected virtual void triggerIsTouched() { }
	protected virtual void triggerTouchDown() { }
	protected virtual void triggerTouchUp() { }
	protected virtual void gripIsTouched() { }
	protected virtual void gripTouchDown() { }
	protected virtual void gripTouchUp() { }
	protected virtual void touchpadIsTouched() { }
	protected virtual void touchpadTouchDown() { }
	protected virtual void touchpadTouchUp() { }
	protected virtual void appButtonIsTouched() { }
	protected virtual void appButtonTouchDown() { }
	protected virtual void appButtonTouchUp() { }
	protected virtual void triggerIsPressed() { }
	protected virtual void triggerPressDown() { }
	protected virtual void triggerPressUp() { }
	protected virtual void gripIsPressed() { }
	protected virtual void gripPressDown() { }
	protected virtual void gripPressUp() { }
	protected virtual void touchpadIsPressed() { }
	protected virtual void touchpadPressDown() { }
	protected virtual void touchpadPressUp() { }
	protected virtual void appButtonIsPressed() { }
	protected virtual void appButtonPressDown() { }
	protected virtual void appButtonPressUp() { }

}
