using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public class FactoryTester : MonoBehaviour
    {
        void Hello()
        {
            var lazyTester = new Lazy<FactoryTester>();
            FactoryTester lft = lazyTester.Value;

            FactoryTester ft = new FactoryTester();
        }
    }
}
