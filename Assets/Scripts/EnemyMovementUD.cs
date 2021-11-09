using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This code is from the tutorial video done by Lemau Dev found here: https://www.youtube.com/watch?v=ljQpwxGb7Jc
//I adapted it from a sidescroller to a top down by adding extra movement options
public class EnemyMovementUD : MonoBehaviour
{
    public float speed;
    //public bool MoveRight;
    public bool MoveUp;
   

    // Update is called once per frame
    void Update()
    {
        if (MoveUp)
        {
            transform.Translate(0, 1 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            transform.Translate(0, -1 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector2(1, 1);
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {

            if (MoveUp)
            {
                MoveUp = false;
            }
            else
            {
                MoveUp = true;
            }
        }

    }
}
