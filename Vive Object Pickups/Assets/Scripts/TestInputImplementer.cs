using UnityEngine;

public class TestInputImplementer : VRControllerInput {

	GameObject me;

	public override void setTrackedObject()
	{
		controllerObject = me.GetComponent<SteamVR_TrackedObject>();
	}

	void Start()
	{
		me = gameObject;
	}

	void FixedUpdate()
	{
		updateInput();
	}

}
