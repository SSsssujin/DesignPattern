using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace ESDesignPatterns.Factory
{
    [Serializable]
    public class Factory
    {
        [SerializeField]
        private FactoryType _type;
        [SerializeField]
        private ProductData _item;

        public Factory(ProductData product)
        {
            _item = product;
        }

        public virtual IProduct GetProduct()
        {
            return _item;
        }

        public FactoryType Type => _type;
        public ProductData Item => _item;
    }
}
