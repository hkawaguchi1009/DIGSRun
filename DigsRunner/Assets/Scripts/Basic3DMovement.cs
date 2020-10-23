using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3DMovement : MonoBehaviour
{
    public float m_Speed = 12f;
    public float m_Strafe = 9f;

    private Vector3 movement;
    private float m_VerticalInputValue;
    private float m_HorizontalInputValue;
    private Rigidbody m_Rigidbody;


    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_VerticalInputValue = Input.GetAxis("Vertical");
        m_HorizontalInputValue = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        move();
    }

    private void move()
    {
        // Create a vector in the direction the player is facing with a magnitude based on the input, speed and the time between frames.
        Vector3 verticalMovement = transform.forward * m_VerticalInputValue * m_Speed * Time.deltaTime;
        Vector3 horizontalMovement = transform.right * m_HorizontalInputValue * m_Strafe * Time.deltaTime;

        //Create a force for addforce method
        Vector3 moveForce = new Vector3(m_HorizontalInputValue * m_Strafe * Time.deltaTime, 0, m_VerticalInputValue * m_Speed * Time.deltaTime);

        // Apply this movement to the rigidbody's position.
        //m_Rigidbody.MovePosition(m_Rigidbody.position + verticalMovement + horizontalMovement);

        //Addforce method of movement
        //m_Rigidbody.AddForce(moveForce);

        //Modifying Velocity Directly is bad form, but solves some short term problems.
        m_Rigidbody.velocity = moveForce; 
    }
}
