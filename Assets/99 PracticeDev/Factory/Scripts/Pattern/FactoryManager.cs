using System;
using System.Collections.Generic;
using System.Linq;
using TMPro.EditorUtilities;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Serialization;

namespace ESDesignPatterns.Factory
{
    public enum FactoryType
    {
        Monster,
    }
    
    public class FactoryManager : MonoBehaviour
    {
        private static FactoryManager _instance;
        
        [SerializeField]
        private FactoryDataCollection _factoryData;
        
        private Dictionary<FactoryType, Lazy<Factory>> _factoryList = new();

        // Lazy initialization
        private Factory _GetFactory(FactoryType type)
        {
            if (!_factoryList.TryGetValue(type, out var factory))
            {
                var lazyFactory = new Lazy<Factory>(() => new Factory(_FindProduct(type)));
                _factoryList.Add(type, lazyFactory);
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

        public static FactoryManager Instance => _instance ??= FindFirstObjectByType<FactoryManager>();
    }
}
