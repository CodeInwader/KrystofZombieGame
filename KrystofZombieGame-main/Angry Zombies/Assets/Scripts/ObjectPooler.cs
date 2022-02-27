using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Sharedinstance;
    public List<GameObject> pooledObjects;
    public GameObject objectPool;
    public int amoutToPool;


     void Awake()
    {
        Sharedinstance = this;
    }


    private void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;

        for (int i = 0; i < amoutToPool; i++)
        {
            tmp = Instantiate(objectPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amoutToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];

            }
        }
        return null;
    }

}
