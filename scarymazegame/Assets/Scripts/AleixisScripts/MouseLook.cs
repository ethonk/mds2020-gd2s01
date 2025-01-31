﻿//
// Bachelor of Software Engineering
// Media Design School
// Auckland
// New Zealand
//
// (c) 2020 Media Design School
//
// File Name : MouseLook.cs
// Description : MouseLook is responsible for the camera movement of the player
// Author : Aliexis Alvarez
// Mail : Aliexis.Alvarez@mediadesignschool.com
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
public bool m_CursorLocked = true;
public bool m_CameraLock = false;

    public float m_Spin = 0.0f;
    public float m_Tilt = 0.0f;
    public float m_Lean = 0.0f;

    public Vector2 m_TiltExtents = new Vector2(-85.0f, 85.0f);
    public float m_Sensitivity = 2.0f;

    void LockCursor()
    {
        Cursor.visible = !m_CursorLocked; //if visible, not visible and vice versa.
        Cursor.lockState = m_CursorLocked ? CursorLockMode.Locked : CursorLockMode.None; //bool ? if,true : if,false
    }
    void Start ()
    {
        LockCursor();
    }

    // Update is called once per frame
    void Update()
    {
        #region view control
        float x = Input.GetAxisRaw("Mouse X");
        float y = Input.GetAxisRaw("Mouse Y");

        m_Spin += x * m_Sensitivity;
        m_Tilt -= y * m_Sensitivity;

        m_Tilt = Mathf.Clamp(m_Tilt, m_TiltExtents.x, m_TiltExtents.y);

        if (!m_CameraLock)
        {
            transform.localEulerAngles = new Vector3(m_Tilt, m_Spin, m_Lean);
        }
        #endregion


    }
}
