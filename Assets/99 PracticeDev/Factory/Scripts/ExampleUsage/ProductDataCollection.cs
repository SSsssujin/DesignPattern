using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ESDesignPatterns.Factory
{
    [CreateAssetMenu(menuName = "ScriptableObject/Factory/ProductList", fileName = "Products", order = 0)]
    public class ProductDataCollection : ScriptableObject
    {
        [SerializeField]
        private List<ProductData> ProductDataList;
    }
}
