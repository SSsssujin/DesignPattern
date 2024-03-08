using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ESDesignPatterns.Factory
{
    public enum FactoryType
    {
        Monster,
    }
    
    public class FactoryManager : MonoBehaviour
    {
        //private Pro
        private Dictionary<FactoryType, Factory> _factoryList = new();

        private void Start()
        {

        }

        private void _CreateFactory(ProductData data)
        {
            var lazyFactory = new Lazy<Factory>(() => new Factory(data));
            Factory factory = lazyFactory.Value;
        }

        private Factory _GetFactory(FactoryType type)
        {
            Factory factory;
            if (!_factoryList.TryGetValue(type, out factory))
            {
                var lazyFactory = new Lazy<Factory>();
                _factoryList.Add(type, lazyFactory.Value);
            }
            return factory;
        }
    }
}
