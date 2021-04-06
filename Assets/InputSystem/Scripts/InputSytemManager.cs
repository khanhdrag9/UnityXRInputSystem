using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KhanhAK.XR.InputSystem
{
    public class InputSytemManager : MonoBehaviour
    {
        private VRAction inputAction = null;
        public VRAction VRAction
        {
            get
            {
                if (inputAction == null)
                    inputAction = new VRAction();
                return inputAction;
            }
        }

        public static InputSytemManager Instance { get; private set; } = null;


        private void OnEnable()
        {
            Instance = this;
            VRAction.Enable();
        }

        private void OnDisable()
        {
            VRAction.Disable();
        }
    }
}
