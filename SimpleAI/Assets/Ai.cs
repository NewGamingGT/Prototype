using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour {

    NavMeshAgent navMeshAgent;

    Transform TargetPos;
    GameObject targetPos;
    Vector3 Target;

	// Use this for initialization
	void Start () {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();

        targetPos = GameObject.Find("Target");
        TargetPos = targetPos.transform; 
        //Finds the game object then get the transform position and store it

        Target.z = TargetPos.position.z;
        Target.x = TargetPos.position.x;
    }

    // Update is called once per frame
    void Update () {
        navMeshAgent.SetDestination(Target);
	}
}
