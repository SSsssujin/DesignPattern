using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    [Flags]
    enum Reptile
    {
        BlackMamba = 2,
        CottonMouth = 4,
        Wiper = 8,
        Crocodile = 16,
        Aligator = 32
    }
    
    public class Tester : MonoBehaviour
    {
        private void Start()
        {
            
            List<int> list = new List<int>() { 1, 296, 4984, 2, 2, 6, 56, 54165, 56, 156, };

            foreach (var number in GetValuesGreaterThan100ByValue(list))
            {
                Debug.Log(number);
                Debug.Log("Here");
                // Do Something with returned value
            }
        }

        public List<int> GetValuesGreaterThan100(List<int> masterCollection)
        {
            List<int> tempResult = new List<int>();
            foreach (var value in masterCollection)
            {
                if (value > 100)
                    tempResult.Add(value);
            }
            return tempResult;
        }
        
        public IEnumerable<int> GetValuesGreaterThan100ByValue(List<int> masterCollection)
        {
            foreach (var value in masterCollection)
            {
                if (value > 100)
                    yield return value;
            }
        }
    }
}
