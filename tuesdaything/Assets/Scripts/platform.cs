using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{

	float dirX, moveSpeed = 6f;
	bool moveRight = true;

	// Update is called once per frame
	void Update()
	{
		if (transform.position.x > 70f)
			moveRight = false;
		if (transform.position.x < 50f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}

}
