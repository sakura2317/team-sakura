using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}

/*
	private Transform target;
	private Vector3 vec;
	private float speed = 1.07f;
	private bool isTriggered;

	void TriggerStay (Collider Other)
	{
		isTriggered = true;
	}

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("item").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isTriggered) {
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation,
			                                       (target.position - transform.position), 0.07f);
			transform.position += transform.forward * speed;
		}
	}
*/
}
