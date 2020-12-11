using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public GameObject playerCharacter;
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = playerCharacter.transform.position + new Vector3(0,10,-10);
		transform.LookAt(GameObject.Find("Player1").transform.position);
	}
}
