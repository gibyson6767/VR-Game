using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour {
	
	void OnTriggerEnter(Collider colliderObj)
	{
		Debug.Log("I hit " + colliderObj.gameObject.name);
	}

}
