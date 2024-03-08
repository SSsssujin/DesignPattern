using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ESDesignPatterns.Factory
{
    [CreateAssetMenu(menuName = "ScriptableObject/Factory/ProductList", fileName = "Products", order = 0)]
    public class ProductDataCollection : ScriptableObject
    {
        private const int _space = 10;

        [Header("[ Character ]")]
        [SerializeField]
        private List<ProductData> MonsterList;
        [SerializeField]
        private List<ProductData> PlayerList;
        
        [Space(_space)]
        
        [Header("[ Item ]")]
        [SerializeField]
        private List<ProductData> HPItemList;
    }
}
