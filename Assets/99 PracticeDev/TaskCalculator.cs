using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public class TaskCalculator : MonoBehaviour
    {
        private void Start()
        {
            // 문제에서 제시된 Vertex의 좌표 
            Vector3 V0 = new Vector3(1, 2, 0);
            Vector3 V1 = new Vector3(9, 1, 0);
            Vector3 V2 = new Vector3(5,4, 0);
            Vector3 V3 = new Vector3(6,7, 0);

            // 인접한 Edge들의 좌표
            Vector3 E1 = V1 - V0;
            Vector3 E2 = V2 - V1;
            Vector3 E3 = V3 - V2;
            Vector3 E4 = V0 - V3;
            
            // 결과
            Debug.Log(CalculateVectorCross(E1, E2)); // 20
            Debug.Log(CalculateVectorCross(E2, E3)); // -15
            Debug.Log(CalculateVectorCross(E3, E4)); // 10
            Debug.Log(CalculateVectorCross(E4, E1)); // 45
        }

        private Vector3 CalculateVectorCross(Vector3 v1, Vector3 v2)
        {
           return Vector3.Cross(v1, v2);
        }
    }
}

