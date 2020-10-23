using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicForceMove : MonoBehaviour
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
       

        //Create a force for addforce method
        Vector3 moveForce = new Vector3(m_HorizontalInputValue * m_Strafe * Time.deltaTime, 0, m_VerticalInputValue * m_Speed * Time.deltaTime);

        //This is for example AI
        //Vector3 moveForce = new Vector3(1 * m_Strafe * Time.deltaTime, 0, 1 * m_Speed * Time.deltaTime);
        
  

        //Addforce method of movement
        m_Rigidbody.AddForce(moveForce);


    }
}
