using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ESDesignPatterns.Factory
{
    [Serializable]
    [CreateAssetMenu(menuName = "ScriptableObject/Factory/Product", fileName = "Product", order = 1)]
    public class ProductData : ScriptableObject, IProduct
    {
        public string Name;
        
        public FactoryType FactoryType;
        public Object Item;
        
        public void Initialize()
        {
            
        }
    }
}
