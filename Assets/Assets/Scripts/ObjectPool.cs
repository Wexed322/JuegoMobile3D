using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public static class ExtensionClass 
{
    public static void setObjectPool(this MonoBehaviour mon, ObjectPool pool) 
    {
       
    }
}*/
public class ObjectPool : MonoBehaviour
{
    public List<InPoolObject> options;

    public List<InPoolObject> pool;

    public void fullStartPool(int cantidadInicial) 
    {
        InPoolObject tmp;
        for (int i = 0; i < cantidadInicial; i++)
        {
            tmp = Instantiate(options[Random.Range(0, options.Count)], this.transform.position, this.transform.rotation);
            pool.Add(tmp);
            tmp.setObjectPool(this);
            tmp.transform.SetParent(this.transform);
            tmp.gameObject.SetActive(false);
        }
    }
    public void getObject() 
    {
        InPoolObject tmp;

        if (pool.Count == 0)
        {
            tmp = Instantiate(options[Random.Range(0, options.Count)], this.transform.position, this.transform.rotation);
            tmp.transform.SetParent(this.transform);
            tmp.setObjectPool(this);
            tmp.gameObject.SetActive(true);
        }
        else 
        {
            tmp = pool[Random.Range(0, pool.Count)];
            pool.Remove(tmp);
            tmp.gameObject.SetActive(true);
        }
    }

}
