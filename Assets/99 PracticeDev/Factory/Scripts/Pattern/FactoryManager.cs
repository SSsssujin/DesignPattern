using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ESDesignPatterns.Factory
{
    public enum FactoryType
    {
        Monster,
        TRex,
    }
    
    public class FactoryManager : MonoBehaviour
    {
        private static FactoryManager _instance;
        
        [SerializeField]
        private FactoryDataCollection _factoryData;
        
        private Dictionary<FactoryType, Lazy<Factory>> _factoryList = new();

        // Lazy initialization
        public Factory GetFactory(FactoryType type)
        {
            if (!_factoryList.TryGetValue(type, out var factory))
            {
                var lazyFactory = new Lazy<Factory>(() => new Factory(_FindProduct(type)));
                _factoryList.Add(type, lazyFactory);
                factory = lazyFactory;
            }
            return factory?.Value;
        }

        private ProductData _FindProduct(FactoryType type)
        {
            var factoryList = _factoryData.FactoryList;
            return factoryList.FirstOrDefault(x => x.Type == type)?.Item;
        }
        
        // 사실 그냥 이렇게 하면 됨
        // Lazy initialization이 유효하려면 ScriptableObject와의 연동을 끊어야할듯?
        private Factory _FindFactoryFromData(FactoryType type)
        {
            var factoryList = _factoryData.FactoryList;
            return factoryList.FirstOrDefault(x => x.Type == type);
        }

        public static FactoryManager Instance => FindFirstObjectByType<FactoryManager>();
    }
}
