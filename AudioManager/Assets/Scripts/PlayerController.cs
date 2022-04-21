using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpSpeed;

	private Rigidbody2D myRB;

	public GameObject projectile;
	public Transform shootPoint;

	// Use this for initialization
	void Start() {
		myRB = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
		myRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, myRB.velocity.y);

		if(Input.GetButtonDown("Jump"))
		{
			myRB.velocity = new Vector2(myRB.velocity.x, jumpSpeed);
		}

		if(Input.GetButtonDown("Fire1"))
		{
			Instantiate(projectile, shootPoint.position, shootPoint.rotation);
		}
	}
}