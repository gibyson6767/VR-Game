using UnityEngine;
using System.Collections;

public class ButtonColliderHandler : MonoBehaviour {

	public bool colliding;
	public GameObject button;

	void Start (){
		colliding = false;
	}

	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "Button")
		{
			button = collider.gameObject;
			colliding = true;
		}
	}

}
