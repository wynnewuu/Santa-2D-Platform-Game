using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	private bool isSafe = false;
	public Rigidbody rb;
	public float playerspeed = 20f;
	public float maxVelocity = 10f;
	public bool IsOnTheGround = true;

	//basic... super basic.. player character script

	public bool IsSafe
	{
		get { return isSafe; }
		set { isSafe = value; }
	}

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-1, 0, 0) * playerspeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(1, 0, 0) * playerspeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0, 0, 1) * playerspeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0, 0, -1) * playerspeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Space) && IsOnTheGround == true) //jump
		{
			rb.AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
			IsOnTheGround = false;
		}
			if (rb.velocity.magnitude >= maxVelocity)
		{
			Vector3 v = rb.velocity.normalized * maxVelocity;
			rb.velocity = v;
		}

		//ToDo: make this thing take user input via force application
	}

	public void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Ground") {
			IsOnTheGround = true;
		}
	}
}
