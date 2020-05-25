using System.Collections.Generic;
using UnityEngine;

namespace UnityHelpers.GameObjectHelpers
{
    public class GameObjectInstantiator : MonoBehaviour
    {
        public static List<GameObject> InstantiateItems(GameObject prefab, int amount, Transform parent)
        {
            List<GameObject> items = new List<GameObject>();

            for (int i = 0; i < amount; i++)
                items.Add(Instantiate(prefab, parent));

            return items;
        }
    }
}