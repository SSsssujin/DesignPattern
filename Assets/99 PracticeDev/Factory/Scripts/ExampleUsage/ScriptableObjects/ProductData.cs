using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ESDesignPatterns.Factory
{
    [Serializable]
    public abstract class ProductData : ScriptableObject, IProduct
    {
        public string Name;
        public Object Item;

        public abstract void Initialize();
    }
}
