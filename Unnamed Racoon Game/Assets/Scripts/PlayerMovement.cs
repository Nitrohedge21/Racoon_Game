using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// If i wanted to make a button appear on the unity editor instead of opening the script everytime.
// I could simply add [SerializeField] before the function declarations! This is really poggers.
//You could apparently also set the functions to public but [SerializeField] is like protected in C++
public class PlayerMovement : MonoBehaviour
{
    //Function reference needed for the movement
    private Rigidbody2D rb;

    //Function reference to make the sprites change.
    private Animator anim;

    // Doesn't matter if you initialise directionX to a default value or not. 
    float directionX = 0f;

    [SerializeField] private LayerMask jumpableGround;

    // I can change the default values for the speed and jump height in here
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpHeight = 14f;

    private BoxCollider2D coll;

    private enum MovementState {idle, running, jumping, falling }
    //private MovementState state = MovementState.idle;

    //The code to flip the sprites. Use it to make a sprite look at left or right.

    private SpriteRenderer sprite;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    //This part is for the button mapping
    private void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(directionX * moveSpeed, rb.velocity.y);


        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        UpdateAnimations();
       
    }

    private void UpdateAnimations()
    {
        MovementState state;

        if (directionX > 0f)
        {
            //anim.SetBool("Running_State", true);
            state = MovementState.running;
            //The code that makes the sprite look right
            //sprite.flipY = true;   // NOPE! This made to character upside down but still look at left. :P
            sprite.flipX = false;
        }
        else if (directionX < 0f)
        {
            state = MovementState.running;
            //The code that makes the sprite look left
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }

        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("State", (int)state);
        // Turns enum state into integer when i use (int)
    }

    private bool isGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
