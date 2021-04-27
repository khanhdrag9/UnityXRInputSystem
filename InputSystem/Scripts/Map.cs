using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KhanhAK.XR.InputSystem
{
    public class Map : MonoBehaviour
    {
        #region Generic
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

        public static Map Instance { get; private set; } = null;

        private void OnEnable()
        {
            Instance = this;
            VRAction.Enable();
        }

        private void OnDisable()
        {
            VRAction.Disable();
        }
        #endregion

        static VRAction action => Instance.VRAction;
        public class VRInput
        {
            public static InputAction A_Input => action.Keys.A;
            public static InputAction B_Input => action.Keys.B;
            public static InputAction X_Input => action.Keys.X;
            public static InputAction Y_Input => action.Keys.Y;
            public static InputAction RTrigger_Input => action.Keys.RTrigger;
            public static InputAction LTrigger_Input => action.Keys.LTrigger;

            public static bool A_Pressed => A_Input.ReadValue<float>() > 0;
            public static bool B_Pressed => B_Input.ReadValue<float>() > 0;
            public static bool X_Pressed => X_Input.ReadValue<float>() > 0;
            public static bool Y_Pressed => Y_Input.ReadValue<float>() > 0;
            public static bool RTrigger_Pressed => RTrigger_Input.ReadValue<float>() > 0.75f;
            public static bool LTrigger_Pressed => LTrigger_Input.ReadValue<float>() > 0.75f;
        }
    }
}
