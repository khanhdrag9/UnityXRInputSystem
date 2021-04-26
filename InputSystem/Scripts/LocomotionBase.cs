using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KhanhAK.XR.InputSystem
{
    public class LocomotionBase : MonoBehaviour
    {
        [SerializeField] Transform targetTransform = null;
        [SerializeField] Transform directTransform = null;

        public Transform TargetTransform => targetTransform;
        public Transform DirectTransform => directTransform == null ? targetTransform : directTransform;

        protected InputSytemManager Input => InputSytemManager.Instance;
    }
}
