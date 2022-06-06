using UnityEngine;
using System.Collections;

public class drabina : MonoBehaviour
{

	public float speed;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player" && Input.GetKey(KeyCode.W))
		{
			other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
		}
		else if (other.tag == "Player" && Input.GetKey(KeyCode.S))
		{
			other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
		}
	}
}