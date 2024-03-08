using System;
using UnityEngine;

namespace ESDesignPatterns.Factory
{
    public class Factory
    {
        private ProductData _data;
        
        public Factory(ProductData data)
        {
            _data = data;
        }
        
        public IProduct GetProduct(Vector3 position)
        {
            return _data;
        }
    }
}
