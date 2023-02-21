using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMovement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float moveSpeed = 2f;
    public float leftBound = -5f;
    public float rightBound = 5f;
    private bool moveLeft = true;
    private bool falling = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                fallDown();
            }
        }
        // Move the cake slice left and right
        if(!falling) 
        {
            moveCake();
        }
    }

    public void moveCake() {
        // Getting the x position
        if(moveLeft){
            if(transform.position.x >= leftBound){
                transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
            }
            else {
                moveLeft = false;
            }
        }
        else {
            if(transform.position.x <= rightBound){
                transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
            }
            else {
                moveLeft = true;
            }
        }
    }

    public void fallDown() {
        myRigidBody.gravityScale = 1;
        falling = true;
    }
}
