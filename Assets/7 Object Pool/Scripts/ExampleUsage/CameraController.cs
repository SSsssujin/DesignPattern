using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public class CameraController : MonoBehaviour
    {
        public Transform Target;
        public Vector3 Distance;

        void Update()
        {
            transform.position = Target.position + Distance;
        }
    }
}
