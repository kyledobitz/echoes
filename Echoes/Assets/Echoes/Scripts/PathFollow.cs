using UnityEngine;
using System.Collections;

public class PathFollow : MonoBehaviour {

	public GameObject[] path;
	public int nextStop = 0;
	public float maxSpeed = 2f;
	public float viewAngle = 30f;
	public float viewDistance = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 walkTowards = path[nextStop].transform.position;
		Vector3 intendedDirection = (walkTowards - transform.position).normalized;
		float excitement = GetExcitementLevel(intendedDirection);
		transform.position += Time.deltaTime*maxSpeed*excitement*intendedDirection;

		if((transform.position - walkTowards).magnitude < 0.01){
			nextStop++;
			nextStop = nextStop % path.Length;
		}
	}

	float GetExcitementLevel(Vector3 intendedDirection){
		var player = GameObject.FindGameObjectWithTag("Player");
		var playerVector = player.transform.position - transform.position;
		if((playerVector).magnitude>viewDistance)
			return 1f;
		if(Vector3.Angle(playerVector,intendedDirection)>viewAngle)
			return 1f;
		return 3f;
	}
}
