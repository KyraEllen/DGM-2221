using UnityEngine;

public class Vector3 : MonoBehaviour
{
    public float moveSpeed = 5f; //Speed at which the player will move
    private Vector2 movement; //Store the player's x,y position for movement 
    public Vector2 vel; 
    private Rigidbody2D rb;
    
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //For Left, Right Movement
        movement.y = Input.GetAxis("Vertical"); //For Up, Down Movement 
    }

        //Set number of calls per frame works best with physics
    void FixedUpdate()
    {
        //Apply physics and move the charater
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    void UpdateDirection()

    {
        Vector2 vel = new Vector2(movement.x, movement.y); //vel stands for velocity

         if (vel.magnitude != 0)
        {
            //direction = vel;
        }

        rb.velocity = vel * moveSpeed;
    }
    
}