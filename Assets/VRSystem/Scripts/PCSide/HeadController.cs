using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeadController : MonoBehaviour
{
    [SerializeField] InputAction rotation = null;
    [SerializeField] float minimumY = -60f;
    [SerializeField] float maximumY = 60f;
    [SerializeField] float sensitivity = 0.5f;
    [SerializeField] public bool lockRotation = false;

    float rotY;

    void Start()
    {
        rotation.performed += OnRotation;
    }

    private void OnEnable()
    {
        rotation.Enable();
    }

    private void OnDisable()
    {
        rotation.Disable();
    }

    private void OnRotation(InputAction.CallbackContext context)
    {
        var look = context.ReadValue<Vector2>();

        if (!lockRotation)
        {
            float rotX = transform.localEulerAngles.y + look.x * sensitivity;

            rotY += look.y * sensitivity;
            rotY = Mathf.Clamp(rotY, minimumY, maximumY);

            transform.localRotation = Quaternion.Euler(new Vector3(-rotY, rotX, 0));
        }
    }


}
