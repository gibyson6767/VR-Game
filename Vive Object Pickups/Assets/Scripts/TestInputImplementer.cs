using UnityEngine;

class TestInputImplementer : VRControllerInput {

	GameObject me;

	public override void setTrackedObject()
	{
		controllerObject = me.GetComponent<SteamVR_TrackedObject>();
        Debug.Log("I AM ATTATCHED TO: " + me.name);
    }

	public void Start()
	{
		me = gameObject;
	}

	void FixedUpdate()
	{
		updateInput();
	}

	protected override void triggerPressDown()
	{
		Debug.Log("Trigger has been pressed!");
	}

	protected override void gripPressDown()
	{
		Debug.Log("Grip has been pressed!");
	}

	protected override void appButtonPressDown()
	{
		Debug.Log("App Button has been pressed!");
	}

	protected override void touchpadPressDown()
	{
		Debug.Log("Touchpad has been pressed!");
	}

}
