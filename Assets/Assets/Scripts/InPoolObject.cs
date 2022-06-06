using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPoolObject : MonoBehaviour
{
    public ObjectPool poolReference;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void setObjectPool(ObjectPool pool)
    {
        this.poolReference = pool;
    }
}
