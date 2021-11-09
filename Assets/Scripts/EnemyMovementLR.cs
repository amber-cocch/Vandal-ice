using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This code is from the tutorial video done by Lemau Dev found here: https://www.youtube.com/watch?v=ljQpwxGb7Jc
//I adapted it from a sidescroller to a top down by adding extra movement options
public class EnemyMovementLR : MonoBehaviour
{
    // Start is called before the first frame update

	public float speed;
	public bool MoveRight;
	//public bool MoveUp;
	

	// Use this for initialization
	void Update()
	{
		// Use this for initialization
		if (MoveRight)
		{
			transform.Translate(2 * Time.deltaTime * speed, 0, 0);
			//transform.localScale = new Vector2(1, 1);
		}
		else
		{
			transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
			//transform.localScale = new Vector2(-1, 1);
		}
	}
	void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.CompareTag("turn"))
		{

			if (MoveRight)
			{
				MoveRight = false;
			}
			else 
			{
				MoveRight = true;
			}
		}
	}
}


