using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private float vertical, horizontal;

    private Rigidbody2D myRigidbody2D;
    
    Transform m_tran;
    
    Animator m_Animator;
    
    private float h = 0;
    
    private float v = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        m_tran = this.transform;
        m_Animator = this.transform.Find("BURLY-MAN_1_swordsman_model").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * moveSpeed;
    
        myRigidbody2D.velocity = movement;

        // Flip the character if needed
        if (horizontalInput > 0 && !B_FacingRight)
        {
            Filp();
        }
        else if (horizontalInput < 0 && B_FacingRight)
        {
            Filp();
        }
    }

    
    // character Filp 
    bool B_Attack = true;
    bool B_FacingRight = false;

    void Filp()
    {
        B_FacingRight = !B_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;

        m_tran.localScale = theScale;
    }
}
