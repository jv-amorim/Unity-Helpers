using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions
{
    /// <summary>
    /// Recursive method that return an IEnumerable with all children GameObjects that contains the specified tag.
    /// </summary>
    /// <param name="parent"></param>
    /// <param name="tag"></param>
    /// <returns></returns>
    public static IEnumerable<GameObject> FindChildrenGameObjectsWithTag(this GameObject parent, string tag)
    {
        Transform parentTransform = parent.transform;

        List<GameObject> taggedGameObjects = new List<GameObject>();

        for (int i = 0; i < parentTransform.childCount; i++)
        {
            Transform child = parentTransform.GetChild(i);

            if (child.CompareTag(tag))
                taggedGameObjects.Add(child.gameObject);

            if (child.childCount > 0)
                taggedGameObjects.AddRange(FindChildrenGameObjectsWithTag(child.gameObject, tag));
        }

        return taggedGameObjects;
    }
}