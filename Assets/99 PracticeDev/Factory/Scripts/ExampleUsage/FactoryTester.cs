using System;
using ESDesignPatterns.Factory;
using UnityEngine;

namespace DesignPatterns
{
    public class FactoryTester : MonoBehaviour
    {
        private void Start()
        {
            var product = FactoryManager.Instance.GetFactory(FactoryType.TRex).GetProduct();
            product.Initialize();
        }

        void Hello()
        {
            var lazyTester = new Lazy<FactoryTester>();
            FactoryTester lft = lazyTester.Value;

            FactoryTester ft = new FactoryTester();
        }
    }
}
