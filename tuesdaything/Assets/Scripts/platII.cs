using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platII : MonoBehaviour
{ 

    float dirX, moveSpeed = 8f;
	bool moveUp = true;

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y > 20f)
			moveUp = false;
		if (transform.position.y < -18f)
			moveUp = true;

		if (moveUp)
			transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
		else
			transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
	}

}