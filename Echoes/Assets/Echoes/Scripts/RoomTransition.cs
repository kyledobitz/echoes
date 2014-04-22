using UnityEngine;
using System.Collections;

public class RoomTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Triggered Started!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		Destroy(collider.gameObject);
		Debug.Log("Triggered!");
		if(collider.gameObject.tag == "Player")
			Debug.Log("player entering next level");

	}
}
