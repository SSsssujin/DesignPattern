using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;

namespace ESDesignPatterns.Factory
{
    [CreateAssetMenu(menuName = "ScriptableObject/Factory/ProductList", fileName = "Products", order = 0)]
    public class FactoryDataCollection : ScriptableObject
    {
        private const int _space = 10;

        //[Header("[ Monster ]")]
        [SerializeField]
        private List<Factory> factoryList;

        private void OnEnable()
        {
            StringBuilder debug = new();
            foreach (FactoryType type in Enum.GetValues(typeof(FactoryType)))
            {
                var find = factoryList.FindAll(x => x.Type == type);
                if (find.Count > 1)
                    Debug.LogError(type + " has more than one data. The factory can create only one product.");

                debug.AppendLine($"===== [{type}] =====");
                find.ForEach(x=> debug.AppendLine(x.Item.name) );
            }
            Debug.Log(debug.ToString());
        }
        
        public IReadOnlyCollection<Factory> FactoryList => factoryList;
    }
}
