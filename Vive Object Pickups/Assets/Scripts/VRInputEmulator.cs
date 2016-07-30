using UnityEngine;
using System.Collections;

public class VRInputEmulator : KeyboardInput {

	Vector3 temp;

	void Start (){
		temp.Set(0, 0, 0);
	}

	void Update (){
		updateInput();
	}

	protected override void aIsDown()
	{
		temp.Set(-0.1f, 0, 0);
		gameObject.transform.localPosition += temp;
	}
	protected override void dIsDown()
	{
		temp.Set(0.1f, 0, 0);
		gameObject.transform.localPosition += temp;
	}
	protected override void wIsDown()
	{
		temp.Set(0, 0, 0.1f);
		gameObject.transform.localPosition += temp;
	}
	protected override void sIsDown()
	{
		temp.Set(0, 0, -0.1f);
		gameObject.transform.localPosition += temp;
	}
	protected override void rIsDown()
	{
		temp.Set(0, 0.1f, 0);
		gameObject.transform.localPosition += temp;
	}
	protected override void fIsDown()
	{
		temp.Set(0, -0.1f, 0);
		gameObject.transform.localPosition += temp;
	}

}
