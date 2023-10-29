using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody2D myRigidbody2D;
    private Animator m_Animator;

    private bool B_FacingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        m_Animator = transform.Find("BURLY-MAN_1_swordsman_model").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        // Set the MoveSpeed parameter in the Animator based on the magnitude of velocity.
        float velocityMagnitude = myRigidbody2D.velocity.magnitude;
        m_Animator.SetFloat("MoveSpeed", velocityMagnitude);

        if (velocityMagnitude > 0.1f)
        {
            // If the player is moving, flip the character if needed.
            if (myRigidbody2D.velocity.x > 0 && !B_FacingRight)
            {
                Flip();
            }
            else if (myRigidbody2D.velocity.x < 0 && B_FacingRight)
            {
                Flip();
            }
        }
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * moveSpeed;
        myRigidbody2D.velocity = movement;
    }

    // Character Flip
    void Flip()
    {
        B_FacingRight = !B_FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}