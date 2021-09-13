using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f;
    public float leftAndRightSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement in the environment
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);

        //if pressing A or Left Arrow key
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //then the player can move left
            transform.Translate(Vector3.left * Time.deltaTime * leftAndRightSpeed);
        }
        //if pressing the D or the Right Arrow key
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //then the player can move right
            //-1 is for the right direction the player is going so it would be going in the opposite direction
            //of left
            transform.Translate(Vector3.left * Time.deltaTime * leftAndRightSpeed * -1);
        }
    }
}
