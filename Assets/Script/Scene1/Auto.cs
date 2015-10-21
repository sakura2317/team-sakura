using UnityEngine;
using System.Collections;

public class Auto : MonoBehaviour {
	public GameObject target;
	public GameObject targitem;
	//public GameObject item;
	NavMeshAgent agent;
	
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = target.transform.position;
		//if(
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "jittai") {
			agent.destination = targitem.transform.position;
		}
	}

}