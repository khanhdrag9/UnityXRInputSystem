using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KhanhAK.XR.InputSystem
{
    class SmoothMovementHandler : LocomotionBase
    {
        CharacterController characterController;

        private void Start()
        {
            characterController = TargetTransform.GetComponent<CharacterController>();
        }

        private void Update()
        {
            if (TargetTransform == null)
                return;

            var smoothMovement = Input.VRAction.VRLeftHand.SmoothMovement;
            var moveDelta = smoothMovement.ReadValue<Vector2>();

            Vector3 move = new Vector3(moveDelta.x, 0, moveDelta.y);    // Convert to 3D direction

            // Get direction
            if(DirectTransform)
                move = DirectTransform.TransformDirection(move);
            else
                move = DirectTransform.TransformDirection(move);

            // Handle movement
            if (characterController)
            {
                characterController.SimpleMove(move);
            }
            else
            {
                TargetTransform.position += move * Time.deltaTime;
            }
        }
    }
}
