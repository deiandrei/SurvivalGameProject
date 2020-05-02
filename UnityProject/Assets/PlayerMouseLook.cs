using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseLook : MonoBehaviour
{
    public const float m_MouseSensitivity = 100.0f;

    public Transform m_playerBody;
    float xRotation;
    bool m_IsPlaying = false;

    public void StartPlay()
    {
        m_IsPlaying = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        //Debug.Log("2");

    }

    // Update is called once per frame
    void Update()
    {
        if (!m_IsPlaying) return;

        float mouseX = Input.GetAxis("Mouse X") * m_MouseSensitivity * Time.deltaTime;
        
        float mouseY = Input.GetAxis("Mouse Y") * m_MouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);
        transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        
        m_playerBody.Rotate(Vector3.up * mouseX);

    }
}
