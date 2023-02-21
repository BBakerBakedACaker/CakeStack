using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float leftBound = -5f;
    public float rightBound = 5f;
    private bool moveLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            fallDown();
        }
        else {
            // Move the cake slice left and right
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
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
    }
}
