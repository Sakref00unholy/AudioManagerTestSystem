using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float moveSpeed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, transform.position.x + 10f, Time.deltaTime * moveSpeed), transform.position.y, transform.position.z);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(gameObject);
	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
