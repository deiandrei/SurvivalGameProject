using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController m_Controller;
    public Transform m_GroundCheck;

    public LayerMask m_GroundMask;

    public float Speed = 15.0f;
    public float Gravity = -9.81f;
    public float GroundDistance = 0.4f;

    public float JumpHeight = 3.0f;

    Vector3 Velocity;
    bool isGroundHit;

    // Update is called once per frame
    void Update()
    {
        isGroundHit = Physics.CheckSphere(m_GroundCheck.position, GroundDistance, m_GroundMask);

        if (isGroundHit && Velocity.y < 0)
        {
            Velocity.y = -1.0f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        m_Controller.Move(move * Speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            Velocity.y = Mathf.Sqrt(JumpHeight * -2.0f * Gravity);
        }

        Velocity.y += Gravity * Time.deltaTime;
        m_Controller.Move(Velocity * Time.deltaTime);
    }
}
