using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KhanhAK.XR.InputSystem
{
    class RotationHandler : LocomotionBase
    {
        [SerializeField] float minimumY = -60f;
        [SerializeField] float maximumY = 60f;
        [SerializeField] bool lockRotation = false;

        private float rotY;

        private void Update()
        {
            var look = Input.VRAction.Locomotion.Rotation.ReadValue<Vector2>();

            if (!lockRotation)
            {
                float rotX = DirectTransform.localEulerAngles.y + look.x;

                rotY += look.y;
                rotY = Mathf.Clamp(rotY, minimumY, maximumY);

                DirectTransform.localRotation = Quaternion.Euler(new Vector3(-rotY, rotX, 0));
            }
        }
    }
}
