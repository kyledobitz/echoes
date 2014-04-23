using UnityEngine;
using System.Collections;

public class RoomTransition : MonoBehaviour {

	public string nextScene = "Area1Scene";

	void Update(){
		transform.position += Vector3.zero;
	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log("On Trigger Enter");
		if(collider.gameObject.tag == "Player")
			Application.LoadLevel (nextScene);

	}
}
