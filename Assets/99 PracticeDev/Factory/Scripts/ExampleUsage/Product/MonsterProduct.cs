using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ESDesignPatterns.Factory
{
    [CreateAssetMenu(menuName = "ScriptableObject/Factory/Product/Monster", fileName = "Product", order = 1)]
    public class MonsterProduct : ProductData
    {
        public override void Initialize()
        {
            
        }

        public GameObject Instantiate()
        {
            return GameObject.Instantiate(Item) as GameObject;
        }
    }
}
